﻿using System.Web;
using System.Web.Mvc;

namespace mvc_ui_dotnet_framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
