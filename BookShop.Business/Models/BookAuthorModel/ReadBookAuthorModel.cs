﻿using BookShop.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Models.BookAuthorModel
{
    public class ReadBookAuthorModel : BaseEntity
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}
