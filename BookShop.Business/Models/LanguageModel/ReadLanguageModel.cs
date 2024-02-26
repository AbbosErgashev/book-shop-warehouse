using BookShop.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Models.LanguageModel
{
    public class ReadLanguageModel : BaseEntity
    {
        public string Language { get; set; } = null!;
    }
}
