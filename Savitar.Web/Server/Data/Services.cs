using System;
using System.Collections.Generic;
using Savitar.Web.Client.Models;

namespace Savitar.Web.Server.Data
{
    public static class Services
    {
        public static IEnumerable<Service> GetAll()
        {
            return new List<Service>
            {
                new Service("Software Development Services", $@"<p>Specialising in cross platform .NET technologies, I am a full stack dev for hire.</p>
<p>I have been in software development for {DateTime.Now.Year - 1986} years, with {DateTime.Now.Year - 1996} of them being professionally - and don't plan to change it any time soon. This gives you the promise of code written with passion.</p>
<p>You can purchase my time in a multitude of flexible ways, including...</p>
<ul class='entry-content'>
    <li>Per Module</li>
    <li>Per Project</li>    
    <li>Per Hour</li>
    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangment.</li>
</ul>
<p>Your invoice will come from Savitar IT (VAT registered).</p>"),
                new Service("Complete Systems", @"From the ground up, I can build you a new system or web application, adhering to the most current standards and specifications.
<br/><br/>
Enterprise systems built on top of open source .NET Core.
                "),
                new Service("Conversions/Upgrades", @"Having many years experience in a multitude of languages and frameworks (please see <a href='/skillsmatrix'>Skills Matrix</a>), I can assist with upgrading legacy language/framework systems to more modern languages and frameworks.
<br/><br/>
<b>Use Cases</b>
<ul class='entry-content'>
    <li>.NET Framework to .NET Core/Standard</li>
    <li>C/C++/Delphi to C#</li>
</ul>"),
                new Service("Mentoring", @"I can help your juniors accellerate their learning curves. I love to talk and teach code!")
            };
        }
    }
}