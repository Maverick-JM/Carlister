using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Common.DTO
{
    public interface IEnquiry
    {
        int EnquiryID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        int CarID { get; set; }
    }
}
