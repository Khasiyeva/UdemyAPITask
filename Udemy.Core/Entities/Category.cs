using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Core.Entities.Common;

namespace Udemy.Core.Entities
{
    public class Category:BaseAuditableEntity
    {
        public string Title { get; set; }
        public string ParentId { get; set; }
    }
}
