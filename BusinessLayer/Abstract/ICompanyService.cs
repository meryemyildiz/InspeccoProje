using EntityLayer.Models;
using EntityLayer.ResultsModel;
using EntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface ICompanyService
    {
        IDataResult<ICollection<CompanyViewModel>> GetAllCompany(Expression<Func<CompanyViewModel,bool>> filter);
        IDataResult<CompanyViewModel>GetFirstOrDefault(Expression<Func<CompanyViewModel, bool>> filter);
        IDataResult<CompanyViewModel> GetById(int id);
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
        
    }
}
