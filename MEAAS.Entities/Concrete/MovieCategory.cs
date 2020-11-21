using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Abstract;

namespace MEAAS.Entities.Concrete
{
    public class MovieCategory:IEntity
    {
        public int MovieCategoryId { get; set; }
        public string MovieCategoryName { get; set; }
    }
}
