using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TyTyShop.Model.Models;
using TyTyShop.Web.Models;

namespace TyTyShop.Web.Infrastructure.extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this Postcategory postcategory, PostCategoryViewModel postCategoryViewModel)
        {
            postcategory.ID = postCategoryViewModel.ID;
            postcategory.Name = postCategoryViewModel.Name;
            postcategory.Alias = postCategoryViewModel.Alias;
            postcategory.Description = postCategoryViewModel.Description;
            postcategory.ParentID = postCategoryViewModel.ParentID;
            postcategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postcategory.Image = postCategoryViewModel.Image;
            postcategory.HomeFlag = postCategoryViewModel.HomeFlag;

            postcategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postcategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postcategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postcategory.UpdatedBy = postCategoryViewModel.UpdatedBy;
            postcategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postcategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postcategory.Status = postCategoryViewModel.Status;

        }
        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.Description = postViewModel.Description;
            post.CategoryID = postViewModel.CategoryID;
            post.Content = postViewModel.Content;
            post.Image = postViewModel.Image;
            post.HomeFlag = postViewModel.HomeFlag;
            post.ViewCount = postViewModel.ViewCount;

            post.CreatedDate = postViewModel.CreatedDate;
            post.CreatedBy = postViewModel.CreatedBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.MetaDescription = postViewModel.MetaDescription;
            post.Status = postViewModel.Status;
        }
    }
}
