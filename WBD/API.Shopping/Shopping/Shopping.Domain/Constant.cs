using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Shopping.Domain
{
    public static class Constant
    {
        public enum SP
        {
            [Description("sp_GetCategories")]
            sp_GetCategories,
            [Description("sp_GetCategoryById")]
            sp_GetCategoryById,
            [Description("sp_CreateCategory")]
            sp_CreateCategory,
            [Description("sp_CreateCategory2")]
            sp_CreateCategory2
        }
    }
}
