﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Reporter
{
    public interface IEmployeeReportBuilder
    {

        //IEmployeeReportBuilder BuildHeader();

        IEmployeeReportBuilder BuildBody();

        IEmployeeReportBuilder BuildFooter();
        //IEmployeeReportBuilder SetName(string Name);
        


        EmployeeReport GetReport();
    }
}
