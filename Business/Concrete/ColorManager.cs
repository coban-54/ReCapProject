﻿using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }
    }
}
