using System;
using System.Collections.Generic;
using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.Shared.CV;

namespace Savitar.Infrastructure.Repository.CV
{
    internal class Technologies : ITechnologies
    {       
        internal static readonly ProjectTechnology CSharp = new("C#", new DateTime(2001, 6, 1), TechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology DotNetFramework = new(".NET Framework", new DateTime(2001, 6, 1), TechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology DotNetCore = new(".NET Core", new DateTime(2014, 11, 1), TechnologyCategories.Framework, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology DotNet5 = new(".NET 5", new DateTime(2021, 1, 1), TechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology Blazor = new("Blazor", new DateTime(2020, 5, 1), TechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology SQLServer = new("SQL Server", new DateTime(1998, 6, 1), TechnologyCategories.Database, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology PostgreSQL = new("PostgreSQL", new DateTime(2020, 1, 1), TechnologyCategories.Database, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Automapper = new("Automapper", new DateTime(2015, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology StructureMap = new("Structure Map", new DateTime(2015, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology VisualStudio = new("Visual Studio", new DateTime(2003, 1, 1), TechnologyCategories.IDE, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Postman = new("Postman", new DateTime(2015, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology TurboPascal = new("Turbo Pascal", new DateTime(1990, 1, 1), TechnologyCategories.Language, new DateTime(1993, 1, 1), Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Delphi = new("Delphi", new DateTime(1995, 2, 1), TechnologyCategories.Language, new DateTime(2007, 1, 1), Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Excel = new("Excel", new DateTime(1995, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology AS400 = new("AS400 Mainframe", new DateTime(1997, 10, 1), TechnologyCategories.Database, new DateTime(1999, 2, 1), Frequencies.Frequently, Proficiencies.Basic);
        internal static readonly ProjectTechnology VBA = new("VBA", new DateTime(1996, 6, 1), TechnologyCategories.Language, new DateTime(1998, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology VisualBasic = new("Visual Basic", new DateTime(1997, 10, 1), TechnologyCategories.Language, new DateTime(2014, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology VisualBasicNet = new("Visual Basic.NET", new DateTime(2010, 1, 1), TechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Daily, Proficiencies.Intermediate);       
        internal static readonly ProjectTechnology WebServices = new("Web Services", new DateTime(2003, 11, 1), TechnologyCategories.Framework, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology WebAPI = new("Web/REST API", new DateTime(2010, 1, 1), TechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology MSAccess = new("Microsoft Access", new DateTime(2000, 1, 1), TechnologyCategories.Database, null, Frequencies.Sometimes, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology CPP = new("C++", new DateTime(1994, 6, 1), TechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly ProjectTechnology EntityFramework = new("Entity Framework", new DateTime(2015, 1, 1), TechnologyCategories.ORM, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology NHibernate = new("nHibernate", new DateTime(2014, 1, 1), TechnologyCategories.ORM, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology Javascript = new("Javascript", new DateTime(2010, 1, 1), TechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology RabbitMQ = new("RabbitMQ", new DateTime(2020, 4, 1), TechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Python = new("Python", new DateTime(2020, 5, 1), TechnologyCategories.Language, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology VUE = new("VUE", new DateTime(2020, 5, 1), TechnologyCategories.Framework, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology PyCharm = new("PyCharm", new DateTime(2020, 5, 1), TechnologyCategories.IDE, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology VSCode = new("VS Code", new DateTime(2018, 6, 1), TechnologyCategories.IDE, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology PowerShell = new("PowerShell", new DateTime(2015, 1, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology BorlandDeveloperStudio = new("Borland Developer Studio", new DateTime(2005, 3, 1), TechnologyCategories.IDE, new DateTime(2010, 1, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly ProjectTechnology ApacheSpark = new("Apache Spark", new DateTime(2020, 6, 1), TechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Docker = new("Docker", new DateTime(2019, 6, 1), TechnologyCategories.Tool, null, Frequencies.Sometimes, Proficiencies.Basic);
        internal static readonly ProjectTechnology MudBlazor = new("MudBlazor", new DateTime(2021, 7, 1), TechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);

        public IEnumerable<ProjectTechnology> GetAll()
        {
            return new List<ProjectTechnology>
            {
                AS400, Automapper, Blazor, CPP, CSharp, Delphi, DotNetCore, DotNetFramework,
                Excel, MSAccess, Postman, SQLServer, StructureMap, VisualBasic, VisualBasicNet,
                VisualStudio, WebServices, EntityFramework, PostgreSQL, NHibernate, WebAPI, TurboPascal, Javascript,
                RabbitMQ, Python, VUE, PyCharm, VSCode, PowerShell, BorlandDeveloperStudio, ApacheSpark, Docker, DotNet5, MudBlazor
            };
        }
    }
}