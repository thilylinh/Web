using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TyTyShop.Model.Models;
using TyTyShop.Web.Models;

namespace TyTyShop.Web.Mapping
{
    public class AutoMapperConfigruation
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<Postcategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}