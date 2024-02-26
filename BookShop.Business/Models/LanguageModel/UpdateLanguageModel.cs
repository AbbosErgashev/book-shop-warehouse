using BookShop.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Models.LanguageModel
{
    public class UpdateLanguageModel : BaseEntity
    {
        public string BookLanguage { get; set; } = null!;
    }
}
