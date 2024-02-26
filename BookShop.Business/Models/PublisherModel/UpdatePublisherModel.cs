using BookShop.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Models.PublisherModel
{
    public class UpdatePublisherModel : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
