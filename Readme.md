-- Put this in the server .csproj
 <ItemGroup>
    <Watch Include="..\**\*.razor" />
    <Watch Include="..\**\*.scss" />
    <Watch Include="..\**\*.cs" />
  </ItemGroup>

  -- Then run this from the command line in server root.
dotnet watch run debug