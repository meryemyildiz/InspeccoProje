using AutoMapper;
using EntityLayer.Models;
using EntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Mappings
{
   public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Company, CompanyViewModel>().ReverseMap();
        }
       
    }
}
