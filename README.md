
# Print Kicker

[Download Package](url)


![GitHub repo size](https://img.shields.io/github/repo-size/c0der4t/printkicker?color=purple&label=Repo%20Size&style=for-the-badge)|  ![GitHub](https://img.shields.io/github/license/c0der4t/printkicker?style=for-the-badge)
:-------------------------:|:-------------------------:

Interface that calls the kick command on a printer with the given kick string.

Use with command line calls to integrate into existing software or use as a standalone testing utility
## Features

- Supports command line calls
- Auto RDP printer correction, i.e Full RDP Support
- IQRetail Integration provided
- Easy to use
- Small Package Size

  
## Usage/Examples

The command line call accepts 3 arguments:

- Full Printer Name of Target Printer
- Full Kick String in Format : 000-000-000-000-000
- [optional] Debug Mode

If arg #3 is set to 'debug' additional pop ups will appear while the interface processes requests to assist with testing and setup

### Command Line

#### Structure
```batch
powershell start-process ''exePath'' -ArgumentList {"""printername"""; "kickstring"; "debug"} -WindowStyle Hidden
```

#### Full Example
```batch
powershell start-process ''exePath'' -ArgumentList {"""EPSON Slip (redirected 257)"""; "027-112-048-055-121"; "debug"} -WindowStyle Hidden
```


### Integration into IQRetail

```pascal

{Copy and paste the following code into any IQ report.
Once added to a report, you can call the kick function in the report using : IQPrintKickPlugin;
Remember to change the following values:
IQPrinterKick_InstallPath = The location of the IQPrinterKick.exe
KickString = The Kickstring for your printer
DebugMode = If set to debug additional messages will be presented informing you of what the system is doing}

procedure IQPrintKickPlugin;
const
IQPrinterKick_InstallPath = 'C:\Users\Public\Documents\IQPrinterKicker\IQPrinterKicker.exe';
KickString = '027-112-048-055-121';
DebugMode = '';                                          
var
qryTerminalSetup : TfrxDBI4Query;
sTargetPrinter,sTempBatFileName : string;
begin
   if <Original> then
   begin

   qryTerminalSetup := TfrxDBI4Query.Create(nil);
   qryTerminalSetup.SQL.Clear;
   with qryTerminalSetup.SQL do
   begin
   Add('SELECT *');
   Add('FROM "' + <ProgramPath> + 'Companys\TERMINALSETUP' + '"');
   ADD('WHERE TerminalNo = ' + inttostr(<Till>)  + ' and Company = ' + IQQuoteString(<CurrentCompany>));
   end;
   qryTerminalSetup.ExecSQL;
   sTargetPrinter := qryTerminalSetup.FieldByName('PosPrinterPort').AsString;

   sTempBatFileName := IQGetUniqueTableName('temp') + '.bat';
   qryTerminalSetup.SQL.Clear;
   with qryTerminalSetup.SQL do
   begin
   ADD('@echo off');
   ADD('powershell start-process ''' + IQPrinterKick_InstallPath + ''' -ArgumentList {"""' + sTargetPrinter + '"""; "' + KickString + '"; "' + DebugMode + '"} -WindowStyle Hidden');
   Add('del ' + sTempBatFileName + '.vbs');
   Add('del ' + sTempBatFileName );
   end;
   qryTerminalSetup.SQL.SaveToFile(sTempBatFileName) ;

   qryTerminalSetup.SQL.Clear;
   with qryTerminalSetup.SQL do
   begin
   ADD('Set WshShell = CreateObject("WScript.Shell") ');
   ADD('WshShell.Run chr(34) & "' + sTempBatFileName + '" & Chr(34), 0');
   ADD('Set WshShell = Nothing');
   end;
   qryTerminalSetup.SQL.SaveToFile(sTempBatFileName + '.vbs') ;

   IQExecute(sTempBatFileName + '.vbs')

   end; //Is Original
end;

```
  
## Preview

![App Screenshot](https://www.ekronds.co.za/img/PrinterKicker/TestPage.PNG)

  
## Contributing

Contributions are always welcome!

  
## Authors

|  [Montè Ekron (c0der4t)](https://www.github.com/c0der4t)          | [Follow me on Twitter](https://twitter.com/EkronMonte)    
:-------------------------:|:-------------------------:
