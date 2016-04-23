using System.Linq;

namespace Carlister.Common.Data
{
    public interface IEnquiryDataSource : IDataSource
    {
        IQueryable<DTO.IEnquiry> GetEnquiries();
        DTO.IEnquiry GetEnquiry(int enquiryID);
    }
}
