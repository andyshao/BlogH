﻿using Blog.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application
{
   public interface IBlogService
    {
        void PublishBlog(Domain.Blog blog);

        IList<BlogModel> GetBlogModels(int pageIndex, int pageSize);
    }
}
