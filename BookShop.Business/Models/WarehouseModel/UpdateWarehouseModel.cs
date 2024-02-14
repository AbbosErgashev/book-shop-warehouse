﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Business.Models.CategoryModel
{
    public class UpdateWarehouseModel
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
    }
}
