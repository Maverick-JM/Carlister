﻿using Carlister.Common.DTO;
using Carlister.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Tests.Mocking
{
    public class Car : ICar
    {
        public int CarID { get; set; }
        public SaleType SaleType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public PriceType PriceType { get; set; }
        public decimal? EgcPrice { get; set; }
        public decimal? DapPrice { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string DealerABN { get; set; }
        public string Comments { get; set; }
    }
}
