﻿using MarieCurie.Interview.Assets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MarieCurie.Web.Repositories;
using MarieCurie.Web.Models;
using MarieCurie.HelperServices.Utilities;

namespace MarieCurie.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<HelperService> getHelperServices()
        {
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            return repo.getCenters();
            
        }

        public string getStyle(HelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            if (HelperServicesUtility.checkOpenningHours(DayOfWeek, Hour, center))
                return $"panel panel-warning col-md-3";
            else
                return $"panel panel-default col-md-3";
        }
        public string getNextOpenning(HelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            return HelperServicesUtility.nextOpenningHours(DayOfWeek, Hour, center);




        }
    }
}