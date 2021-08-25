using System.Collections.Generic;
using Savitar.Domain.Models;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class ServicesSeedData
    {
        public static IEnumerable<Service> GetAll()
        {
            int id = 1;
            return new List<Service>
            {
                new Service(id++, "Software Development Services", $@"<p>Specialising in cross platform .NET technologies, we are full stack devs for hire.</p>
<br />
<p>You can purchase time in a multitude of flexible ways, including...</p>
<ul>
    <li>Per Module</li>
    <li>Per Project</li>    
    <li>Per Hour</li>
    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangment.</li>
</ul>
<br />
<p>Your invoice will come from Savitar IT (VAT registered).</p>" ),

                new Service(id++, "Complete Systems", @"From the ground up, we can build you a new system adhering to the most current standards and specifications and on top of the latest technologies." ),
                new Service(id++, "Conversions/Upgrades", @"Having many years experience in a multitude of languages and frameworks, we can assist with upgrading legacy language/framework systems to more modern languages and frameworks.
<br/><br/>
<b>Use Cases</b>
<ul>
    <li>Angular / React / Vue TO Blazor WebAssembly</li>
    <li>WPF (Windows Presentation Foundation) or Silverlight to Blazor (WebAssembly or Server)</li>    
    <li>.NET Framework TO .NET 5</li>
    <li>C / C++ / Delphi / Visual Basic TO C#</li>
    <li>Desktop application to Web application</li>
</ul>" )
        //        new Service(id++, "Mentoring", @"I can help your juniors accellerate their learning curves. I love to talk and teach code!" )
            };
        }
    }
}