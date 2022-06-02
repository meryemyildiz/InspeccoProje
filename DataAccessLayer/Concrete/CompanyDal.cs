using DataAccessLayer.Abstract;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class CompanyDal : BaseRepository<Company, int>,ICompanyDal
    {
        public CompanyDal(MyContext myContext) : base(myContext)
        {
        }
    }
}
