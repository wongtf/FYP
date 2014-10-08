Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("Citibank DPS Reporting")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("Datasonic Corporation Sdn Bhd")> 
<Assembly: AssemblyProduct("CitiRep")> 
<Assembly: AssemblyCopyright("")> 
<Assembly: AssemblyTrademark("")> 
<Assembly: CLSCompliant(True)> 

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("743BEE96-33CB-4908-97E3-8CA22691266C")> 

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:

<Assembly: AssemblyVersion("2.0.0.3")> 

'version 20701, danny lim, 20100927, added mechanics to:-
'                       - check for duplicated AWBs and reset AWBs mechanics in frmScan.vb 
'                        - added bug fix on logic frmscan.btndone on checking of EOF on scanning
'version 20702, danny lim, 20110524, added mechanics to:-
'                       - add a text box in uploadfilesetup.vb for file extension to be used.
'                       - relays to frmcnprint
'version 20703, dannylim, 20110608, modconvfunction.vb/formatfiledetails addin external condition of substition of BT character shld data is empty, 
'else will default to 'empty space'