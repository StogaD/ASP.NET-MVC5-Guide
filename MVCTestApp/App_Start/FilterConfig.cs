﻿using MVCTestApp.Controllers.AttributesExamples;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RangeExceptionAttribute());
        }
    }
}
