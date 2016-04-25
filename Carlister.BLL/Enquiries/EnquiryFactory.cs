using Carlister.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.BLL.Enquiries
{
    public static class EnquiryFactory
    {
        public static Enquiry CreateEnquiry(IEnquiry enquiryData)
        {
            return new Enquiry(enquiryData);
        }
    }
}
