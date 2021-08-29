using System;
using System.Collections.Generic;
using Savitar.Domain;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class ProjectTechnologiesSeedData
    {
        static int id = 1;
        internal static readonly DevelopmentTechnology CSharp = new(id++, "C#", new DateTime(2001, 6, 1), DevelopmentTechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology DotNetFramework = new(id++, ".NET Framework", new DateTime(2001, 6, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology DotNetCore = new(id++, ".NET Core", new DateTime(2014, 11, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology DotNet5 = new(id++, ".NET 5", new DateTime(2021, 1, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology BlazorServer = new(id++, "Blazor Server", new DateTime(2020, 5, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology BlazorWebAssembly = new(id++, "Blazor WebAssembly", new DateTime(2020, 5, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology SQLServer = new(id++, "SQL Server", new DateTime(1998, 6, 1), DevelopmentTechnologyCategories.Database, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology PostgreSQL = new(id++, "PostgreSQL", new DateTime(2020, 1, 1), DevelopmentTechnologyCategories.Database, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology Automapper = new(id++, "Automapper", new DateTime(2015, 1, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology StructureMap = new(id++, "Structure Map", new DateTime(2015, 1, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology VisualStudio = new(id++, "Visual Studio", new DateTime(2003, 1, 1), DevelopmentTechnologyCategories.IDE, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology Postman = new(id++, "Postman", new DateTime(2015, 1, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology TurboPascal = new(id++, "Turbo Pascal", new DateTime(1990, 1, 1), DevelopmentTechnologyCategories.Language, new DateTime(1993, 1, 1), Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology Delphi = new(id++, "Delphi", new DateTime(1995, 2, 1), DevelopmentTechnologyCategories.Language, new DateTime(2007, 1, 1), Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology Excel = new(id++, "Excel", new DateTime(1995, 1, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        
        internal static readonly DevelopmentTechnology AS400 = new(id++, "AS400 Mainframe", new DateTime(1997, 10, 1), DevelopmentTechnologyCategories.Database, new DateTime(1999, 2, 1), Frequencies.Frequently, Proficiencies.Basic);
        
        internal static readonly DevelopmentTechnology VBA = new(id++, "VBA", new DateTime(1996, 6, 1), DevelopmentTechnologyCategories.Language, new DateTime(1998, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology VisualBasic = new(id++, "Visual Basic", new DateTime(1997, 10, 1), DevelopmentTechnologyCategories.Language, new DateTime(2014, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology VisualBasicNet = new(id++, "Visual Basic.NET", new DateTime(2010, 1, 1), DevelopmentTechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Daily, Proficiencies.Intermediate);       
        internal static readonly DevelopmentTechnology WebServices = new(id++, "Web Services", new DateTime(2003, 11, 1), DevelopmentTechnologyCategories.Framework, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology WebAPI = new(id++, "Web/REST API", new DateTime(2010, 1, 1), DevelopmentTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology MSAccess = new(id++, "Microsoft Access", new DateTime(2000, 1, 1), DevelopmentTechnologyCategories.Database, null, Frequencies.Sometimes, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology CPP = new(id++, "C++", new DateTime(1994, 6, 1), DevelopmentTechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology EntityFramework = new(id++, "Entity Framework", new DateTime(2015, 1, 1), DevelopmentTechnologyCategories.ORM, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology NHibernate = new(id++, "nHibernate", new DateTime(2014, 1, 1), DevelopmentTechnologyCategories.ORM, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology Javascript = new(id++, "Javascript", new DateTime(2010, 1, 1), DevelopmentTechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology RabbitMQ = new(id++, "RabbitMQ", new DateTime(2020, 4, 1), DevelopmentTechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology Python = new(id++, "Python", new DateTime(2020, 5, 1), DevelopmentTechnologyCategories.Language, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology VUE = new(id++, "VUE", new DateTime(2020, 5, 1), DevelopmentTechnologyCategories.Framework, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology PyCharm = new(id++, "PyCharm", new DateTime(2020, 5, 1), DevelopmentTechnologyCategories.IDE, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology VSCode = new(id++, "VS Code", new DateTime(2018, 6, 1), DevelopmentTechnologyCategories.IDE, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly DevelopmentTechnology PowerShell = new(id++, "PowerShell", new DateTime(2015, 1, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology BorlandDeveloperStudio = new(id++, "Borland Developer Studio", new DateTime(2005, 3, 1), DevelopmentTechnologyCategories.IDE, new DateTime(2010, 1, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly DevelopmentTechnology ApacheSpark = new(id++, "Apache Spark", new DateTime(2020, 6, 1), DevelopmentTechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology Docker = new(id++, "Docker", new DateTime(2019, 6, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Sometimes, Proficiencies.Basic);
        internal static readonly DevelopmentTechnology MudBlazor = new(id++, "MudBlazor", new DateTime(2021, 7, 1), DevelopmentTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);

        public static IEnumerable<DevelopmentTechnology> GetAll()
        {
            return new List<DevelopmentTechnology>
            {
                AS400 , Automapper, BlazorServer, BlazorWebAssembly, CPP, CSharp, Delphi, DotNetCore, DotNetFramework,
                Excel, MSAccess, Postman, SQLServer, StructureMap, VisualBasic, VisualBasicNet,
                VisualStudio, WebServices, EntityFramework, PostgreSQL, NHibernate, WebAPI, TurboPascal, Javascript,
                RabbitMQ, Python, VUE, PyCharm, VSCode, PowerShell, BorlandDeveloperStudio, ApacheSpark, Docker, DotNet5, MudBlazor
            };
        }
    }
}