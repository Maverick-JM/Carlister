using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.DAL
{
    public class Enquiry : Common.DTO.IEnquiry
    {
        public int EnquiryID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CarID { get; set; }

        public virtual Car Car { get; set; }
    }
}
