using System;
using System.Collections.Generic;
using Savitar.Web.Domain.Models;
using Savitar.Web.Infrastructure.Repository.Contracts.CV;

namespace Savitar.Web.Infrastructure.Repository.CV
{
    internal class Services : IServices
    {
        public IEnumerable<Service> GetAll()
        {
            return new List<Service>
            {
                new Service() { Id = 1, Title = "Software Development Services", Description = $@"<p>Specialising in cross platform .NET technologies, I am a full stack dev for hire.</p>
<p>I have been in software development for {DateTime.Now.Year - 1986} years, with {DateTime.Now.Year - 1996} of them being professionally - and don't plan to change it any time soon. This gives you the promise of code written with passion.</p>
<br />
<p>You can purchase my time in a multitude of flexible ways, including...</p>
<ul>
    <li>Per Module</li>
    <li>Per Project</li>    
    <li>Per Hour</li>
    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangment.</li>
</ul>
<br />
<p>Your invoice will come from Savitar IT (VAT registered).</p>" },

                new Service() { Id = 2, Title = "Complete Systems", Description = @"From the ground up, I can build you a new system adhering to the most current standards and specifications.
<br/><br/>
Enterprise systems built on top of open source .NET Core.
                " },
                new Service() { Id = 3, Title = "Conversions/Upgrades", Description = @"Having many years experience in a multitude of languages and frameworks (please see <a href='/skillsmatrix'>Skills Matrix</a>), I can assist with upgrading legacy language/framework systems to more modern languages and frameworks.
<br/><br/>
<b>Use Cases</b>
<ul>
    <li>Angular / React / Vue TO Blazor WebAssembly</li>
    <li>WPF (Windows Presentation Foundation) or Silverlight to Blazor (WebAssembly or Server)</li>    
    <li>.NET Framework TO .NET 5</li>
    <li>C / C++ / Delphi / Visual Basic TO C#</li>
    <li>Desktop application to Web application</li>
</ul>" },
                new Service() { Id = 4, Title = "Mentoring", Description = @"I can help your juniors accellerate their learning curves. I love to talk and teach code!" }
            };
        }
    }
}