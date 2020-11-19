using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Abstract;

namespace MEAAS.Entities.Concrete
{
    public class Admin:IEntity
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminGender { get; set; }
        public string AdminPassword { get; set; }
    }
}
