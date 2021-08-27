using System;
using System.Collections.Generic;
using Savitar.Domain;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class ProjectTechnologiesSeedData
    {
        static int id = 1;
        internal static readonly ProjectTechnology CSharp = new(id++, "C#", new DateTime(2001, 6, 1), ProjectTechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology DotNetFramework = new(id++, ".NET Framework", new DateTime(2001, 6, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology DotNetCore = new(id++, ".NET Core", new DateTime(2014, 11, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology DotNet5 = new(id++, ".NET 5", new DateTime(2021, 1, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology BlazorServer = new(id++, "Blazor Server", new DateTime(2020, 5, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology BlazorWebAssembly = new(id++, "Blazor WebAssembly", new DateTime(2020, 5, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology SQLServer = new(id++, "SQL Server", new DateTime(1998, 6, 1), ProjectTechnologyCategories.Database, DateTime.Now.Date, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology PostgreSQL = new(id++, "PostgreSQL", new DateTime(2020, 1, 1), ProjectTechnologyCategories.Database, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Automapper = new(id++, "Automapper", new DateTime(2015, 1, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology StructureMap = new(id++, "Structure Map", new DateTime(2015, 1, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology VisualStudio = new(id++, "Visual Studio", new DateTime(2003, 1, 1), ProjectTechnologyCategories.IDE, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Postman = new(id++, "Postman", new DateTime(2015, 1, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology TurboPascal = new(id++, "Turbo Pascal", new DateTime(1990, 1, 1), ProjectTechnologyCategories.Language, new DateTime(1993, 1, 1), Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Delphi = new(id++, "Delphi", new DateTime(1995, 2, 1), ProjectTechnologyCategories.Language, new DateTime(2007, 1, 1), Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology Excel = new(id++, "Excel", new DateTime(1995, 1, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);
        
        internal static readonly ProjectTechnology AS400 = new(id++, "AS400 Mainframe", new DateTime(1997, 10, 1), ProjectTechnologyCategories.Database, new DateTime(1999, 2, 1), Frequencies.Frequently, Proficiencies.Basic);
        
        internal static readonly ProjectTechnology VBA = new(id++, "VBA", new DateTime(1996, 6, 1), ProjectTechnologyCategories.Language, new DateTime(1998, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology VisualBasic = new(id++, "Visual Basic", new DateTime(1997, 10, 1), ProjectTechnologyCategories.Language, new DateTime(2014, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology VisualBasicNet = new(id++, "Visual Basic.NET", new DateTime(2010, 1, 1), ProjectTechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Daily, Proficiencies.Intermediate);       
        internal static readonly ProjectTechnology WebServices = new(id++, "Web Services", new DateTime(2003, 11, 1), ProjectTechnologyCategories.Framework, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology WebAPI = new(id++, "Web/REST API", new DateTime(2010, 1, 1), ProjectTechnologyCategories.Framework, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology MSAccess = new(id++, "Microsoft Access", new DateTime(2000, 1, 1), ProjectTechnologyCategories.Database, null, Frequencies.Sometimes, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology CPP = new(id++, "C++", new DateTime(1994, 6, 1), ProjectTechnologyCategories.Language, new DateTime(2010, 6, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly ProjectTechnology EntityFramework = new(id++, "Entity Framework", new DateTime(2015, 1, 1), ProjectTechnologyCategories.ORM, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology NHibernate = new(id++, "nHibernate", new DateTime(2014, 1, 1), ProjectTechnologyCategories.ORM, new DateTime(2015, 1, 1), Frequencies.Rarely, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology Javascript = new(id++, "Javascript", new DateTime(2010, 1, 1), ProjectTechnologyCategories.Language, null, Frequencies.Daily, Proficiencies.Advanced);
        internal static readonly ProjectTechnology RabbitMQ = new(id++, "RabbitMQ", new DateTime(2020, 4, 1), ProjectTechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Python = new(id++, "Python", new DateTime(2020, 5, 1), ProjectTechnologyCategories.Language, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology VUE = new(id++, "VUE", new DateTime(2020, 5, 1), ProjectTechnologyCategories.Framework, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology PyCharm = new(id++, "PyCharm", new DateTime(2020, 5, 1), ProjectTechnologyCategories.IDE, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology VSCode = new(id++, "VS Code", new DateTime(2018, 6, 1), ProjectTechnologyCategories.IDE, null, Frequencies.Frequently, Proficiencies.Intermediate);
        internal static readonly ProjectTechnology PowerShell = new(id++, "PowerShell", new DateTime(2015, 1, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Advanced);
        internal static readonly ProjectTechnology BorlandDeveloperStudio = new(id++, "Borland Developer Studio", new DateTime(2005, 3, 1), ProjectTechnologyCategories.IDE, new DateTime(2010, 1, 1), Frequencies.Rarely, Proficiencies.Advanced);
        internal static readonly ProjectTechnology ApacheSpark = new(id++, "Apache Spark", new DateTime(2020, 6, 1), ProjectTechnologyCategories.Tool, new DateTime(2020, 9, 1), Frequencies.Rarely, Proficiencies.Basic);
        internal static readonly ProjectTechnology Docker = new(id++, "Docker", new DateTime(2019, 6, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Sometimes, Proficiencies.Basic);
        internal static readonly ProjectTechnology MudBlazor = new(id++, "MudBlazor", new DateTime(2021, 7, 1), ProjectTechnologyCategories.Tool, null, Frequencies.Frequently, Proficiencies.Intermediate);

        public static IEnumerable<ProjectTechnology> GetAll()
        {
            return new List<ProjectTechnology>
            {
                AS400 , Automapper, BlazorServer, BlazorWebAssembly, CPP, CSharp, Delphi, DotNetCore, DotNetFramework,
                Excel, MSAccess, Postman, SQLServer, StructureMap, VisualBasic, VisualBasicNet,
                VisualStudio, WebServices, EntityFramework, PostgreSQL, NHibernate, WebAPI, TurboPascal, Javascript,
                RabbitMQ, Python, VUE, PyCharm, VSCode, PowerShell, BorlandDeveloperStudio, ApacheSpark, Docker, DotNet5, MudBlazor
            };
        }
    }
}