﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Çıplak Class Kalmasın

    public interface ICategoryDal:IEntityRepository<Category>
    {
   
    }
}
