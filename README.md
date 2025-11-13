# ExcelCSX

**ExcelCSX** is an Excel add-in that enables executing **C# Scripts** directly inside Microsoft Excel.

With ExcelCSX, you can automate and manipulate Excel workbooks using C# Script with the same convenience as VBA, while leveraging the power of the Roslyn scripting engine.

For an introduction to using C# Script with Excel, refer to:

- [Welcome to the Excel C# Script Tutorial!](http://mokumokucsharp.hateblo.jp/entry/2016/07/13/140602)

---

## Project Status

As of **2019-04-22**, this project is **no longer under active development**.  
No further improvements or new feature requests will be accepted.

Binary distributions have been discontinued; however, **the source code remains available**.

> **Note:**  
> The build process requires a code-signing certificate.  
> Please generate and use a self-signed certificate if needed.

You may freely use this project as:

- A reference implementation for embedding DSL runtimes into Excel  
- A sample for using Roslyn Scripting within Office add-ins

---

## How It Works

ExcelCSX uses **Roslyn for Scripting** to evaluate and run C# Script within Excel.

The scripting syntax follows the conventions of Roslyn’s official scripting APIs:  
<https://github.com/dotnet/roslyn/wiki/Scripting-API-Samples>

To make Excel manipulation easier, ExcelCSX provides several convenience features:

- Additional default reference assemblies  
- Simplified access to the `Excel.Application` object

---

## Requirements

- Windows 7 or later  
- .NET Framework 4.6 or later  
- Microsoft Excel 2007 or later

---

## License

- [MIT License](https://github.com/dck-jp/ExcelCSX/blob/master/LICENSE.txt)

This software is released under the MIT License as open-source, free software.
