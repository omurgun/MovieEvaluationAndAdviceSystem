﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Concrete;

namespace MEAAS.DataAccess.Abstract
{
    interface IUserDal:IEntityRepository<User>
    {
    }
}