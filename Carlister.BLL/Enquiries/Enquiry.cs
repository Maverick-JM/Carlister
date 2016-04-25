using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlister.Common.DTO;
using Carlister.Common.Data;

namespace Carlister.BLL.Enquiries
{
    public class Enquiry : IEnquiry
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
            this.Name = enquiryData.Name;
            this.Email = enquiryData.Email;
            this.CarID = enquiryData.CarID;
        }

        public void Insert(IEnquiryDataSource db)
        {
            db.Add(this);
            db.SaveChanges();
        }

        public static List<Enquiry> GetEnquiries(IEnquiryDataSource db)
        {
            return db.GetEnquiries()
                .ToList()   // Fetch from DB
                .Select(e => EnquiryFactory.CreateEnquiry(e))
                .ToList();
        }
    }
}
