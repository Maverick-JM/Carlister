using Carlister.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Common.DTO
{
    public interface ICar
    {
        int CarID { get; set; }
        SaleType SaleType { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        int PriceType { get; set; }
        decimal? EgcPrice { get; set; }
        decimal? DapPrice { get; set; }
        string Email { get; set; }
        string ContactName { get; set; }
        string Phone { get; set; }
        string DealerABN { get; set; }
        string Comments { get; set; }
    }
}
