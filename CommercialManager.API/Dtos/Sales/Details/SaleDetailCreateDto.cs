﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialManager.API.Dtos.Sales.Details
{
    public class SaleDetailCreateDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }
        public double UnitPrice { get; set; }
        
    }
}
