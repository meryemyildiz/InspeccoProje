using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using System.Linq;
using EntityLayer.ResultsModel;
using EntityLayer.ViewModels;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        IMapper _mapper;

        public CompanyManager(ICompanyDal companyDal, IMapper mapper)
        {
            _companyDal = companyDal;
            _mapper = mapper;
        }

        public IResult Add(Company company)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Company company)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ICollection<CompanyViewModel>> GetAllCompany(Expression<Func<CompanyViewModel, bool>> filter)
        {
            try
            {
                var result = _mapper.Map<Expression<Func<CompanyViewModel, bool>>, Expression<Func<Company, bool>>>(filter);
                var companies = _companyDal.GetAll(result, includeEntities: "Companies").ToList();

                ICollection<CompanyViewModel> list = new List<CompanyViewModel>();
                foreach (var item in companies)
                {
                    CompanyViewModel c = new CompanyViewModel()
                    {
                        Id = item.Id,
                        CreatedDate = item.CreatedDate,
                        CompanyName = item.CompanyName
                    };
                    list.Add(c);
                }

                return new SuccessDataResult<ICollection<CompanyViewModel>>(list, "Şirketler listelendi");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<CompanyViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CompanyViewModel> GetFirstOrDefault(Expression<Func<CompanyViewModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
