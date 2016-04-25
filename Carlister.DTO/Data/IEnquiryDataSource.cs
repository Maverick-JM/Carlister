using System.Linq;

namespace Carlister.Common.Data
{
    public interface IEnquiryDataSource : IDataSource<DTO.IEnquiry>
    {
        IQueryable<DTO.IEnquiry> GetEnquiries();
        DTO.IEnquiry GetEnquiry(int enquiryID);
    }
}
