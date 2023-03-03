# Cross Assembly Reference Example
Demonstrates how to use Babel Obfuscator to perform cross-assembly obfuscation on a .NET application that references an external NuGet package, and how to modify the deployment package to include the obfuscated assemblies.

The full example documentation is available in the [Babel Obfuscator Manual](https://docs.babelfor.net/examples/cross-assembly-renaming/publish-.net-app)

## Instructions

Copy the babel.licenses license file inside the project folder then use the following commands to create the deployable package:

`dotnet pack`

To run the application from command line use:

`dotnet run`

