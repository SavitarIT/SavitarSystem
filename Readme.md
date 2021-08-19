## Savitar.Server has Swagger support now.
http://localhost:5001/swagger/index.html

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

# Sensitive settings in appsettings.json can be set in environment variables on the dev machine.

**Quick Access**
* Powershell: cd d:\Software\Savitar\Applications\SavitarSystem\Savitar.Web\Server\; dotnet watch run debug;
* Browser: http://savitar.local:5000/

## If errors on live, add the following to the <aspNetCore>... section in web.config. Errors will show up then. Remove once done.
<environmentVariables>
    <environmentVariable name="ASPNETCORE_ENVIRONMENT" value="Development" />
</environmentVariables>


## To-Do
* My Work: Can be flattened a bit. Remove the Client surrounding group, and introduce Client into the project. Display if set.
* My Work: Show most important at the top, with the rest hidden under a "More" link.
* Google meta tags.
* Localise the app perhaps. Afrikaans is a good second language for this.
    https://channel9.msdn.com/Events/Build/2020/BOD104?ocid=AID3012654&WT.mc_id=build2020-azuredevtips-micrum
    Go to 30 mins in.
* Set decent icons - all over.


## Handy links
* https://github.com/SteveSandersonMS/CarChecker
* https://www.matblazor.com/
* https://www.clipartmax.com/