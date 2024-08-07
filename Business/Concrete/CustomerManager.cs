﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);        }

        public void GetAll(Customer customer)
        {
            _customerDal.GetAll();
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);

        }
    }
}
