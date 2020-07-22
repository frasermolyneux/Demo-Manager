﻿using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using log4net.Config;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("XI Demo Manager")]
[assembly: AssemblyDescription("Enables easy management and sharing of CoD2, CoD4, CoD:WaW demo files.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("XtremeIdiots")]
[assembly: AssemblyProduct("XI Demo Manager")]
[assembly: AssemblyCopyright("Copyright © 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4c85d50b-c493-4059-b53e-b3feedc5811f")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.1.0")]
[assembly: AssemblyFileVersion("1.1.1.0")]
[assembly: NeutralResourcesLanguage("en")]

[assembly: XmlConfigurator(ConfigFile = "Log4Net.config", Watch = true)]