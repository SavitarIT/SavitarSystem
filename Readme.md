## Debugging
**Put this in the server .csproj**
 ```
 <ItemGroup>
    <Watch Include="..\**\*.razor" />
    <Watch Include="..\**\*.scss" />
    <Watch Include="..\**\*.cs" />
  </ItemGroup>
  ```
**Then run this from the command line in server root.**
*`dotnet watch run debug`

It's not as good as hot reloads, but Blazor is new - so hang in there. Hot reloads are coming...

**Quick Access**
* Powershell: cd d:\Software\Savitar\Applications\SavitarSystem\Savitar.Web\Server\; dotnet watch run debug;
* Browser: http://savitar.local:5000/


## To-Do
* My Work: Can be flattened a bit. Remove the Client surrounding group, and introduce Client into the project. Display if set.
* My Work: Show most important at the top, with the rest hidden under a "More" link.
* Contact: This must be made to look better. Find a template online.
* Services: Look at other .NET freelancers and see how they advertise. Take from the best, and implement.
* Google meta tags.
* Localise the app perhaps. Afrikaans is a good second language for this.
    https://channel9.msdn.com/Events/Build/2020/BOD104?ocid=AID3012654&WT.mc_id=build2020-azuredevtips-micrum
    Go to 30 mins in.
* Set decent icons - all over.
* Contact information to the top. Email, cell, whatsapp, etc... Format for call href: tel:+27609101010


## Handy links
* https://github.com/SteveSandersonMS/CarChecker
* https://www.matblazor.com/
* https://www.clipartmax.com/