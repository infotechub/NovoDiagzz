using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    public class Support
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public string Status { get; set; }

        public string ReplyBy { get; set; }

        public string CreatedOn { get; set; }

        public string UpdatedOn { get; set; }
    }
}
