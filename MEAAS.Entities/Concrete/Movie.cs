using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Abstract;

namespace MEAAS.Entities.Concrete
{
    public class Movie:IEntity
    {
        public int Id { get; set; }
        public int MovieCategoryId { get; set; }
        public string MovieName { get; set; }
        public string MovieThumbnail { get; set; }
    }
}
