## Debugging
**Put this in the server .csproj**
 <ItemGroup>
    <Watch Include="..\**\*.razor" />
    <Watch Include="..\**\*.scss" />
    <Watch Include="..\**\*.cs" />
  </ItemGroup>

**Then run this from the command line in server root.**
dotnet watch run debug

It's not as good as hot reloads, but Blazor is new - so hang in there. Hot reloads are coming...
Host: http://savitar.local:5000/