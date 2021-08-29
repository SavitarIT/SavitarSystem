using System;
using System.Collections.Generic;
using System.Linq;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class ClientsAndProjectsSeedData
    {
        static readonly int clientId = 1;
        private static int projectId = 1;

        private static readonly IEnumerable<Client> Clients = new List<Client>
        {
            new Client(clientId++, "Savitar IT Solutions")
            {
                Projects = new List<Project>
                {
                    new Project(projectId++, "# Savitar WebAssembly and Server : This website :)")
                    {
                        Description = @"Wanting to learn the new Microsoft Blazor technology, I decided to build this site using the technology to gain some needed experience.<br/><br/>
                        The aim is to introduce different concepts over time, add tools, and just generarlly showcase what Blazor is capable of, and what I can do with it.",                       
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNet5, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.BlazorWebAssembly, ProjectTechnologiesSeedData.MudBlazor, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.WebAPI }
                    },
                    new Project(projectId++, "dBit : MWeb Payment Module")
                    {
                        Description = "The company already had a web application built off DotNetNuke. I simply built them a DNN module that facilitated online payments.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetCore, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Absolute Systems")
                    {
                        Description = @"Application written to enable the setting up, tracking and cash reconciliation of Nedbank ATM canisters around South Africa.
I wrote the web application for the system that enabled users to setup the canisters, track their locations, monitor the status and reconcile cash-up once the canisters arrived at the cash centre.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.WebServices }
                    },
                    new Project(projectId++, "Adcheck Contractor")
                    {
                        Description = @"Contracted to Adcheck for a number of projects that I am unable to elaborate on due to an NDA in effect",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Artemis Red Robot")
                    {
                        Description = @"<ul>
    <li>Traffic violation system installed on freeways and at intersections, and any other deemed to be an area speed or red robot violations are committed.</li>
    <li>Speed is determined based on data fed to the system via pizzo lines laid under the road, or a laser system mounted to the camera unit. The system communicates with a Canon camera of image taking.</li>
    <li>Red robot status is determined by data fed to the system via the traffic lights.</li>
    <li>System can handle red robot violations, speed violations or both.</li>
    <li>System is user configurable for different speed triggers, pizzo line distances, laser calibration, camera flash settings, day/night setup and camera capture delay.</li>
    <li>Speed can determine when cars or trucks are passing over the lines. This is needed so the side of a truck is not snapped when a truck commits a violation. A laser is used to determine if there is a “blockage”. If so, the snap is delayed until the blockage flag is reset.</li>
    <li>Data is stored internally on the camera in a SQL Server 2005 Express database and provides statistics of violations per hour, line passings per hour, etc…</li>
    <li>Data is retrieved by a traffic office by inserting a memory stick into the camera USB port. The system automatically detects the memory stick and transfers data to the memory stick.</li>
    <li>All images and data are stored in files encrypted using triple DES encryption. Data is overlaid on the images before storage as well as being stored alongside the images in the file for retrieval later.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Artemis Mobile Edition")
                    {
                        Description = @"<ul>
    <li>Similar application to Artemis Red Robot, but this version streams feed from a video camera and freezes the image when a violation is recorded. The system is also a mobile system. The PC is embedded in a hardened plastic suitcase and powered off a 12v battery.</li>
    <li>Speed is recorded via a hand held or tripod mounted laser.</li>
    <li>Red robot violations cannot be handled by this system.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Athletics South Africa")
                    {
                        Description = @"Company web application for advertising athletic events, handling athlete profiles, athlete event registration and displaying event results.

This web application was content managed to enable ASA to add and maintain their own pages without the need for a developer.

Savitar IT was also responsible for the hosting and maintenance of this website for a few years.",

                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualBasic, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.Excel }
                    },
                    new Project(projectId++, "Brilliant Accounting - Point of Sale")
                    {
                        Description = @"Build the Point of Sale module that is integrated in the Brilliant Account package.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Canoe Kayak World")
                    {
                        Description = "Canoe Kayak World required a website to display products sold in store and to advertise events organized.",                        
                        TechStack = new List<ProjectTechnology>{ ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "CheckMyTicket")
                    {
                        Description = @"<ul>
    <li>Web application for monitoring winning lotto numbers and notifies end users of winning number combinations.</li>
    <li>End users would SMS the numbers they required notififcation for to a 5 digit number (like advertised on TV). The SMS is sent via the ClickATell gateway to the website and loaded into the database against the users cell number. Depending on the code entered, the end user would receive notifications for 2, 4 or 8 week periods.</li>
    <li>The web application owner would load the winning numbers after each draw. If any of the notifications in the system matched the winning numbers, an SMS would be sent to the end users via the ClickATell gateway notifying them of their winning numbers.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "CV Magic Worldwide")
                    {
                        Description = @"<ul>
                            <li>Web application catering to both the employer and employee. The system ran very much in the same way PNet does but with some unique ideas provided by the client. This system was also targeted initially at the Nigerian market with the aim of going world wide at a later date.</li>
                            <li>Users gained access to the system via scratch card numbers. The scratch cards are provided at various outlets around Nigeria. The employee user is able to register an account and setup their CV. They are however not able to print the CV or submit to potential employers until a valid scratch card number has been entered.</li>
                            <li>Scratch card numbers are imported into the system via a flat file CSV format. These numbers are then used to verify the numbers entered in by the end user.</li>
                            <li>When the CV information has been input, the end user is then able to locate potential employers based on matching criteria and similarly, employers are able to locate employees via a similar mechanism.</li>
                        </ul>",                        
                        TechStack = new List<ProjectTechnology>{ ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Dawn Wing")
                    {
                        Description = @"Dawn wing reached a point where their in-house software had too many problems for the software to be usable. I was contracted to assist them with ironing out the problems and getting the software to a stable position again.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.VisualBasicNet }
                    },
                    new Project(projectId++, "Ferdinandplan")
                    {
                        Description = @"<ul>
    <li>Winforms application to handle insurance contracts sold to owners of exotic cars like Ferrari, Lamborghini, etc...</li>
    <li>The system tracked teh insurance value and start/end dates.</li>
    <li>When all data was loaded into the system, the system generates a contract for the client. Contract is signed, scanned back into the system and linked to the clients profile.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Franchise Management System")
                    {
                        Description = @"This was a system owned / maintained by Savitar IT Solutions for about 8 years, and in use in the hospitality industry.
<ul>
    <li>Targets both the Franchisee and Franchisor.</li>
    <li>Multiple levels of security and access. Franchisee, franchisor and administrator. Each of these levels could further define their own security and permissions based on needs.</li>
    <li>Franchisees could manually capture their daily sales, or upload them automatically using our RESTful API. Stock, supplier, etc... information was manually captured.</li>
    <li>Franchisors could monitor sales, reconcile sales information, generate franshisee fees (and invoice), provide upper management GP reports, setup menu items (by store, group or region), manage stock (including pricing across regions), suppliers, agents, etc...</li>
</ul>",                        
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Hygeria")
                    {
                        Description = @"Web application to display the companies profile and related products.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Incredible Connection Marquee")
                    {
                        Description = @"Simple user control that plugged into Incredible Connection's existing intranet that would scroll data by branch. Data was supplied via XML.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Media Magic")
                    {
                        Description = @"<ul>
    <li>Winforms application for cataloging and provide lookup/search functionality of various media.</li>
    <li>In addition, when audio CD's are inserted, the ID of the disc is read and a lookup done to the CD-DB API to retrieve information about the disc.</li>
    <li>Media can be played directly out of Media Magic. All the user has to do is search for the media they want to listen to, then insert the </li>
    <li>System had the ability to rate titles to facilitate lookups by tempo, genre, year, etc...</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.MSAccess }
                    },
                    new Project(projectId++, "Mondi Recyling RMS")
                    {
                        Description = @"Basic system to handle the management of recycled paper and exporting data to JD Edwards.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "MWeb Business")
                    {
                        Description  = @"MWeb Business outsourced a number of web applications to us to do on their behalf. Unable to disclose further information due to an NDA, but a noteworthy entry anyway.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Pacify")
                    {
                        Description = @"Web application to display companies profile and products available",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Project Watch")
                    {
                        Description = @"<ul>
    <li>Web application for handling timesheets and time invoicing.</li>
    <li>System catered to companies, staff and users.</li>
    <li>Invoices auto or manually emailed. Users could log in to manage/view timesheets, invoices and payments.</li>    
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "PSCBC")
                    {
                        Description = @"Converted the PSCBC web application from .NET 1.1 to .NET 3.5, updated SQL Server, and migrated data.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "RoadAngle")
                    {
                        Description = @"Web application to handle product information and warranty returns for the RoadAngle GPS product.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Rockwatch.NET")
                    {
                        Description = "Application for importing and analysing data fed into the system via XML files, to assist them in determining the structural integrity of the panel's worked in by the miners in the mine. NDA prevents further information.",
                        TechStack = new List<ProjectTechnology>{ ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Roto-Platics")
                    {
                        Description = @"<ul>
    <li>Winforms application to assist in the manufacturing of plastic materials at Roto-Plastics.</li>
    <li>Enables end users to create recipes based on plastics, colours, dy, material and design.</li>
</ul>",
                        TechStack = new List<ProjectTechnology>{ ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Savitar RC")
                    {
                        Description = @"Web application for handling the distribution of radio controlled helicopters and accessories.
<ul>
    <li>Dual purpose website for both distributors and vendors with pricing to match login.</li>
    <li>The system handles ordering, checkout and shipping tracking. Stock control is maintained on invoice and stock levels are automatically adjusted</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Signal Systems")
                    {
                        Description = @"Web application to display company information and available products",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp }
                    },
                    new Project(projectId++, "Signature Placements")
                    {
                        Description = "Simple web application advertising the companies services",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp }
                    },
                    new Project(projectId++, "SmartAd")
                    {
                        Description = @"<ul>
    <li>Windows application for the SABC marketing department. The application handled the cataloging and retrieval of adverts that were recorded for use on the various radio stations.</li>
    <li>A custom database backend was developed for use in this application employing the use of C++ structs. The custom database also supported indexing for fast retrieval.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.CPP }
                    },
                    new Project(projectId++, "Videotown")
                    {
                        Description = "eCommerce web application for advertising, leasing and selling movies and video games.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "Winace Frontend")
                    {
                        Description = @"This application was written back in the Windows For Workgroups days as a frontend to the command line only tool, WinAce. It offered a graphical user interface to the end user for configuring archive settings, storage location and encryption mechanism. Data was then fed via the cmd line to Winace to do the actual work.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.CPP }
                    },
                    new Project(projectId++, "Winamp Monitor")
                    {
                        Description = @"<ul>
    <li>Winamp 2.x plugin</li>
    <li>Hooks all winamp windows and log internal window messages sent between the various Winamp windows. The plugin is a developer tool to assist plugin developers of Winamp plugins to easily work out which messages to intercept.
This was released free to the community and assisted me with further Winamp development.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi }
                    },
                    new Project(projectId++, "Winamp Ratings")
                    {
                        Description = @"<ul>
    <li>Winamp 2.x plugin</li>
    <li>Winamp had no mechanism to rate tracks or set tempo. This plug-in enabled a user to rate tracks and set the tempo
via global hot keys (Winamp did not need focus to handle the hotkeys). Tracks could then be loaded via these
settings by the end user.</li>
</ul>",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.MSAccess }
                    },
                    new Project(projectId++, "Xheli")
                    {
                        Description = "eCommerce web application for radio controlled helicopters and accessories.",
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    }
                }
            },
            new Client(clientId++, "Aberdare Cables")
            {
                Url = "https://www.aberdare.co.za",
                Projects = new List<Project>
                {
                    new Project(projectId++, "AS400ToIntranet")
                    {
                        Description = @"Management required production information from the factory floor. 
The IT Manager wanted a system coded in VB, but the order of the required software was taking time, so I made a plan using Microsoft Excel (VBA) to extract the information required from the AS400, generate graphs and tables, and dump it on the companies LAN.

This system remained in use for around 15 years after I moved on!

Being the first PC developer in the company, I was also responsible for assisting with network installation, PC builds, etc...",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility },
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.AS400, ProjectTechnologiesSeedData.Excel, ProjectTechnologiesSeedData.VisualBasic }
                    }
                }
            },
            new Client(clientId++, "Accutrak Pty (Ltd)")
            {
                Url = "https://www.accutrak.co.za",
                Projects = new List<Project>
                {
                    new Project(projectId++)
                    {
                        Name = "Smartrail",
                        Url = "https://www.accutrak.co.za/our-products-2/smartrail",
                        Description = @"Smartrail combines state of the art in-line weighbridge technology with low power RFiD tracking technology to give you real time accounting of your production volumes available on surface.

    I was involved with the server development. This consisted of a Windows Service and IIS Website. The Windows Service took care or ETL and maintenance tasks, and the website for master data, reporting, etc...

When this project started in 2005, my client only had installation files for the first version of their software. It was a Winforms application on the .NET 1 framework. I reverse engineered the system and extracted the required sources. The system was then upgraded to .NET Framework 2, and later to a web application. It then got a re-write about 6 years ago to the system it is currently.",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility, ResponsibilitiesSeedData.MentorResponsibility },
                        TechStack        = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.Automapper, ProjectTechnologiesSeedData.StructureMap, ProjectTechnologiesSeedData.Postman }
                    },
                    new Project(projectId++)
                    {
                        Name = "Minegaze",
                        Url = "https://www.accutrak.co.za/our-products-2/minegaze/",
                        Description = "Minegaze is a GPS based tracking and weighing solution for the surface or open cast trackless mining environments. Minegaze makes use of the GSM network to upload collected data into the cloud with the objective of optimising production.",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility, ResponsibilitiesSeedData.MentorResponsibility },
                        TechStack        = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.Automapper, ProjectTechnologiesSeedData.StructureMap, ProjectTechnologiesSeedData.Postman }
                    },
                    new Project(projectId++)
                    {
                        Name = "Accuchip",
                        Url = "https://www.accutrak.co.za/our-products-2/accuchip/",
                        Description = "Accuchip is an RFid tracking solution for material cars and general rolling stock. This is an RFid solution that can be applied to various rolling stock items and high value equipment to provide proximity detection and location reporting.",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility, ResponsibilitiesSeedData.MentorResponsibility },
                        TechStack        = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.Automapper, ProjectTechnologiesSeedData.StructureMap, ProjectTechnologiesSeedData.Postman }
                    },
                    new Project(projectId++)
                    {
                        Name = "Trucktrak",
                        Url = "https://www.accutrak.co.za/our-products-2/outset/",
                        Description = "Trucktrak is a production management system designed specifically for mechanised underground mining operations. Since there is no GPS available underground from which to obtain position, Trucktrak makes use of discretely distributed long life battery operated beacons to obtain position.",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility, ResponsibilitiesSeedData.MentorResponsibility },
                        TechStack        = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.Automapper, ProjectTechnologiesSeedData.StructureMap, ProjectTechnologiesSeedData.Postman }
                    }

                }
            },
            new Client(clientId++, "Cosoft")
            {
                Projects = new List<Project>
                {
                    new Project(projectId++, "Aura")
                    {
                        Description = @"<ul>
                            <li>Point Of Sale solution serving the hospitality industry. In use by Steers Holdings (Steers, Debonairs, etc..), Fishaways, Something Fishy, Hotdog Café, Scooters, and more.</li>
                            <li>The system had a front end workstation for the till operators to perform sales and a back office for management to generate sales reports, setup menus, and more.</li>
                            <li>All sales were uploaded nightly at the Alphapos Enterprise server – via FTP - to be imported into a data warehouse solution to enable the franchisor to view sales statistics for all franchises and outlets country wide.</li>
                            <li>The application is extremely feature rich and catered to both the franchisee and franchisor needs.</li>
                        </ul>",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.LeadDevResponsibility, ResponsibilitiesSeedData.MentorResponsibility },
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.Delphi, ProjectTechnologiesSeedData.SQLServer }
                    }
                }
            },
            new Client(clientId++, "Smartec Technologies")
            {
                Projects = new List<Project>
                {
                    new Project(projectId++, "Top-It-Up")
                    {
                        Description = @"This is a pre-paid airtime vending system.                            
                            <ul>
                                <li>Vending machines are installed around the country with an interface to enable customers to purchase pre-paid airtime.</li>
                                <li>The vending machine communicates with a server via GPRS/EDGE/3D/HSDPA depending on the signal available at the installed location.</li>
                                <li>Accounts for the vending machine owner are maintained on the server and data is synchronized with the vending machine from time to time.</li>
                                <li>All vending machines are loaded with enough stock to last 2 days. As soon as the stock levels for any product reach 8 hours, the vending machine uploads all sales, and downloads new stock to replenish its-self based on items needed to see it through for the next 2 days.The quantities are determined by calculating average daily sales over the last 14 days. This prevents the terminal from having too little stock and therefore connecting too often or having too much thereby preventing sales from being uploaded regularly.</li>
                                <li>Vending machines use Web Services via the SOAP protocol to communicate with the server.</li>
                                <li>The service side has a complete management web interface to enable staff to setup vending machines, deploy settings to vending machines, manage accounts, funds, import stock, generate GP reports, etc…</li>
                                <li>The server solution had to calculate commissions for account holders based on sales and pre-configured percentage settings.Account holders were also able to login to the web frontend to view sales statistics, draw reports and support queries.</li>
                            </ul>",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.SeniorDevResponsibility},
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer }
                    },
                    new Project(projectId++, "CellC Distributor / Vendor Management System")
                    {
                        Description = @"<ul>
    <li>System to handle the management of starter packs sold to distributors, then to vendors - and generated commission.</li>
    <li>Allows for distributor and vendor login to enable the rendering of reports for cash balances, stock orders, commissions generated, payments made, etc...</li>
    <li>Starter packs are sold by CellC to a distributor (Hi-Fi Corp, etc...). The stock is sent to the system via flat file and loaded into SQL Server. Vendors then purchase the stock at Point Of Sale terminals at the distributor, with communications via SOAP Web Services in real time.</li>    
</ul>",
                        Responsibilities = new List<ProjectResponsibility> { ResponsibilitiesSeedData.SeniorDevResponsibility},
                        TechStack = new List<ProjectTechnology> { ProjectTechnologiesSeedData.VisualStudio, ProjectTechnologiesSeedData.DotNetFramework, ProjectTechnologiesSeedData.CSharp, ProjectTechnologiesSeedData.SQLServer, ProjectTechnologiesSeedData.WebServices }

                    }
                }
            }
        };

        private static void SetClientIds()
        {
            var id = 1;

            foreach (var client in Clients)
            {
                client.Id = id++;

                foreach (var project in client.Projects)
                    project.Client = client;
            }
        }

        public static IEnumerable<Project> GetProjects()
        {
            var projects = GetClients()
                .SelectMany(x => x.Projects
                    .Select(project => project))
                .ToList();

            return projects;
        }

        public static IEnumerable<Client> GetClients()
        {
            SetClientIds();

            return Clients;
        }
    }
}
