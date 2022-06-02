using DataAccessLayer.Concrete;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICompanyDal : IBaseRepository<Company,int>
    {
    }
}
