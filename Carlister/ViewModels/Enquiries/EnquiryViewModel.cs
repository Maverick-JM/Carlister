using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Carlister.Web.ViewModels.Enquiries
{
    public class EnquiryViewModel : Common.DTO.IEnquiry
    {
        [HiddenInput]
        public int CarID { get; set; }
        [HiddenInput]
        public int EnquiryID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public EnquiryViewModel()
        {

        }

        public EnquiryViewModel(int carID)
        {
            this.CarID = carID;
        }
    }
}
