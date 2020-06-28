using System;
using System.Collections.Generic;
using Savitar.Web.Shared.Models;

namespace Savitar.Web.Server.Data
{
    public static class Technologies
    {
        public static readonly ProjectTechnology CSharp = new ProjectTechnology("C#", new DateTime(2001, 6, 1), TechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology DotNetFramework = new ProjectTechnology(".NET Framework", new DateTime(2001, 6, 1), TechnologyCategories.Framework, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology DotNetCore = new ProjectTechnology(".NET Core", new DateTime(2014, 11, 1), TechnologyCategories.Framework, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology SQLServer = new ProjectTechnology("SQL Server", new DateTime(1998, 6, 1), TechnologyCategories.Database, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology PostgreSQL = new ProjectTechnology("PostgreSQL", new DateTime(2020, 1, 1), TechnologyCategories.Database, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology Automapper = new ProjectTechnology("Automapper", new DateTime(2015, 1, 1), TechnologyCategories.Tool, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Advanced);
        public static readonly ProjectTechnology StructureMap = new ProjectTechnology("Structure Map", new DateTime(2015, 1, 1), TechnologyCategories.Tool, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Advanced);
        public static readonly ProjectTechnology VisualStudio = new ProjectTechnology("Visual Studio", new DateTime(2003, 1, 1), TechnologyCategories.IDE, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology Postman = new ProjectTechnology("Postman", new DateTime(2015, 1, 1), TechnologyCategories.Tool, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology TurboPascal = new ProjectTechnology("Turbo Pascal", new DateTime(1990, 1, 1), TechnologyCategories.Language, new DateTime(1993, 1, 1), Frequencies.Frequently, Proficiencies.Advanced);
        public static readonly ProjectTechnology Delphi = new ProjectTechnology("Delphi", new DateTime(1995, 2, 1), TechnologyCategories.Language, new DateTime(2007, 1, 1), Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology Excel = new ProjectTechnology("Excel", new DateTime(1995, 1, 1), TechnologyCategories.Tool, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology AS400 = new ProjectTechnology("AS400 Mainframe", new DateTime(1997, 10, 1), TechnologyCategories.Database, new DateTime(1999, 2, 1), Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology VisualBasic = new ProjectTechnology("Visual Basic", new DateTime(1997, 10, 1), TechnologyCategories.Language, new DateTime(2014, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        public static readonly ProjectTechnology VisualBasicNet = new ProjectTechnology("Visual Basic.NET", new DateTime(2010, 1, 1), TechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Daily, Proficiencies.Intermediate);
        public static readonly ProjectTechnology Blazor = new ProjectTechnology("Blazor", new DateTime(2020, 5, 1), TechnologyCategories.Tool, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology WebServices = new ProjectTechnology("Web Services", new DateTime(2003, 11, 1), TechnologyCategories.Framework, DateTime.Now.Date, Frequencies.Rarely, Proficiencies.Intermediate);
        public static readonly ProjectTechnology WebAPI = new ProjectTechnology("Web/REST API", new DateTime(2010, 1, 1), TechnologyCategories.Framework, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        public static readonly ProjectTechnology MSAccess = new ProjectTechnology("Microsoft Access", new DateTime(2000, 1, 1), TechnologyCategories.Database, DateTime.Now.Date, Frequencies.Rarely, Proficiencies.Intermediate);
        public static readonly ProjectTechnology CPP = new ProjectTechnology("C++", new DateTime(1994, 6, 1), TechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Frequently, Proficiencies.Advanced);
        public static readonly ProjectTechnology EntityFramework = new ProjectTechnology("Entity Framework", new DateTime(2015, 1, 1), TechnologyCategories.ORM, DateTime.Now.Date, Frequencies.Frequently, Proficiencies.Advanced);
        public static readonly ProjectTechnology NHibernate = new ProjectTechnology("nHibernate", new DateTime(2014, 1, 1), TechnologyCategories.ORM, new DateTime(2015, 1, 1), Frequencies.Daily, Proficiencies.Intermediate);
        public static readonly ProjectTechnology Javascript = new ProjectTechnology("Javascript", new DateTime(2010, 1, 1), TechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Intermediate);
        public static readonly ProjectTechnology RabbitMQ = new ProjectTechnology("RabbitMQ", new DateTime(2020, 4, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology Python = new ProjectTechnology("Python", new DateTime(2020, 5, 1), TechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Basic);
        public static readonly ProjectTechnology VUE = new ProjectTechnology("VUE", new DateTime(2020, 5, 1), TechnologyCategories.Framework, null, Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology PyCharm = new ProjectTechnology("PyCharm", new DateTime(2020, 5, 1), TechnologyCategories.IDE, null, Frequencies.Rarely, Proficiencies.Basic);
        public static readonly ProjectTechnology VSCode = new ProjectTechnology("VS Code", new DateTime(2018, 6, 1), TechnologyCategories.IDE, null, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology PowerShell = new ProjectTechnology("PowerShell", new DateTime(2015, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology BorlandDeveloperStudio = new ProjectTechnology("Borland Developer Studio", new DateTime(2005, 3, 1), TechnologyCategories.IDE, null, Frequencies.Frequently, Proficiencies.Intermediate);
        public static readonly ProjectTechnology ApacheSpark = new ProjectTechnology("Apache Spark", new DateTime(2020, 6, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Basic);
        public static readonly ProjectTechnology Docker = new ProjectTechnology("Docker", new DateTime(2019, 6, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Basic);

        public static IEnumerable<ProjectTechnology> GetAll()
        {
            return new List<ProjectTechnology>
            {
                AS400, Automapper, Blazor, CPP, CSharp, Delphi, DotNetCore, DotNetFramework,
                Excel, MSAccess, Postman, SQLServer, StructureMap, VisualBasic, VisualBasicNet,
                VisualStudio, WebServices, EntityFramework, PostgreSQL, NHibernate, WebAPI, TurboPascal, Javascript,
                RabbitMQ, Python, VUE, PyCharm, VSCode, PowerShell, BorlandDeveloperStudio, ApacheSpark, Docker
            };
        }
    }
}