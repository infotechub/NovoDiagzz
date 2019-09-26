using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoDiagnosis.Data;
using NovoDiagnosis.Models;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Security.Cryptography;

namespace NovoDiagnosis.Controllers
{

    [Authorize]
    public class DiagnosisDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private static Random random = new Random();


        public DiagnosisDetailsController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        // GET: DiagnosisDetails2
        public async Task<IActionResult> Index()
        {

            var user = await _userManager.GetUserAsync(User);
            return View();
        }

        // GET: DiagnosisDetails2
        public async Task<IActionResult> AppointmentList()
        {
            return View(await _context.DiagnosisDetails.ToListAsync());
        }

        public async Task<IActionResult> MyAppointment()
        {
            var user = await _userManager.GetUserAsync(User);
            var myappointment = _context.DiagnosisDetails.Where(x => x.UserName == user.UserName);
            ViewBag.UserName = myappointment;
            if (myappointment == null)
            {
                return RedirectToAction("Details", "DiagnosisDetails");
            }
            return View(myappointment);
        }

        // GET: DiagnosisDetails2/Details/5
        public async Task<IActionResult> Details()
        {
            var user = await _userManager.GetUserAsync(User);
            var diagnosisDetails = await _context.DiagnosisDetails
                .LastOrDefaultAsync(m => m.StaffId == user.UserName);
            if (diagnosisDetails != null)
            {
                return View(diagnosisDetails);
            }

            ViewBag.Error = "You currently have no appointment, Kindly create one.";
            return RedirectToAction("Create", "DiagnosisDetails");


        }

        public IActionResult NoRecordFound()
        {
            return View();
        }

        // GET: DiagnosisDetails2/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

       


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( DiagnosisDetails diagnosisDetails, string Email, string AppointmentDate, string Provider, string AuthorizationCode)
        {

           
            var user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                _context.Add(diagnosisDetails);
                await _context.SaveChangesAsync();

                try
                {
                    //instantiate a new MimeMessage
                    var message = new MimeMessage();
                    //Setting the To e-mail address
                    message.To.Add(new MailboxAddress(Email));

                    message.Bcc.Add(new MailboxAddress("akinbamidelea@novohealthafrica.org"));
                    //Setting the From e-mail address
                    message.From.Add(new MailboxAddress("E-mail From Name", "noreply@novohealthafrica.org"));
                    //E-mail subject 
                    message.Subject = "Appointment Successfully Created";
                    //E-mail message body
                    message.Body = new TextPart(TextFormat.Html)
                    {
                        Text = "<p>Dear esteemed client,</p><br/>" +
                        "<p>Thank you for creating a new appointment using the Novo Annual Medical Check App.</p>" +
                        "<p>Your annual medical checkup have been scheduled to take place at <b>" + Provider + "</b> at <b>" + AppointmentDate + "</b>. </p><p></p><p>Your Authorization Code is <b>" + AuthorizationCode + "</b>.<br/> Kindly go to the Hospital with this code.</p>" +
                        "<p>You have been authorized for the following Medical Checks: </p>" +
                        "<ul><li>Routine Clinic Examinations</li><li>Physical Examination</li><li>Urinalysis</li><li>Hepatitis B (HBaAg)</li><li>PCV, Fasting Blood Sugar</li><li>ECG</li><li>E/U/CR (Kidney Function Test)</li><li>Liver Function Test</li><li>Lipid Profile</li></ul>" +


                        "<br/><br><br/><p>Thank you for choosing Novo Health Africa</p>"
                    };
                
                    //Configure the e-mail
                    using (var emailClient = new SmtpClient())
                    {
                        emailClient.Connect("smtp.office365.com", 587, false);
                        emailClient.Authenticate("noreply@novohealthafrica.org", "Requestpassword2007");
                        emailClient.Send(message);
                        emailClient.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Oops! We have a problem here {ex.Message}";
                }
                return RedirectToAction("Details", "DiagnosisDetails");
            }
           
            
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosisDetails = await _context.DiagnosisDetails.FindAsync(id);
            if (diagnosisDetails == null)
            {
                return NotFound();
            }
            return View(diagnosisDetails);
        }

        // POST: DiagnosisDetails2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,StaffId,Provider,State,Email,PhoneNumber,AppointmentDate,AppointmentTime,CompletedAnnualMedical,Approve,Reject,CreatedOn,UpdatedOn,AuthorizationCode,Recommendation,UserName,Status,History,PresentingComplain,Diagnosis,PlanTest")] DiagnosisDetails diagnosisDetails)
        {
            if (id != diagnosisDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diagnosisDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosisDetailsExists(diagnosisDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "DiagnosisDetails");
            }
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosisDetails = await _context.DiagnosisDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diagnosisDetails == null)
            {
                return NotFound();
            }

            return View(diagnosisDetails);
        }

        // POST: DiagnosisDetails2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnosisDetails = await _context.DiagnosisDetails.FindAsync(id);
            _context.DiagnosisDetails.Remove(diagnosisDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosisDetailsExists(int id)
        {
            return _context.DiagnosisDetails.Any(e => e.Id == id);
        }
    }
}
