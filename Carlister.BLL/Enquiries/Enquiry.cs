using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlister.Common.DTO;

namespace Carlister.BLL.Enquiries
{
    public class Enquiry
    {
        public int EnquiryID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CarID { get; set; }

        public Enquiry()
        {

        }

        public Enquiry(IEnquiry enquiryData)
        {

        }
    }
}
