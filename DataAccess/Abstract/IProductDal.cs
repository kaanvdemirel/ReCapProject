﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAll();
        List<Car> GetAllByBrandId(int BrandId);
    }
}
