﻿; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Prism"
#include "version.txt"
#define MyAppPublisher ""
#define MyAppURL ""
#define MyAppExeName "Prism.Program.exe"
#define MyAppMigratorExeName "Prism.DatabaseMigrator.exe"
#define MyAppExeConfigName MyAppExeName + ".config"
#define MyAssemblyVersionString StringChange(MyAppVersion, ".", "_")
#define DevExpressPath GetEnv('DEV_EXPRESS14_PATH')
#define PrizmExternalPath GetEnv('PRIZM_EXTERNAL')
#define PrizmRoot "Prism"

;#define MyFileVersion GetFileVersion("{app}\{#MyAppExeName}")
;it is decided not to use FileVersion yet. Assembly version will be used.


[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{005BEC4A-C754-479A-869A-B365E509EF78}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#PrizmRoot}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=..\install\Release
OutputBaseFilename=setup_prism_{#MyAssemblyVersionString}
Compression=lzma
ArchitecturesInstallIn64BitMode=x64
SolidCompression=yes
ShowTasksTreeLines=True
AlwaysShowDirOnReadyPage=True
PrivilegesRequired=none
DisableWelcomePage=True
DisableReadyPage=True
DisableReadyMemo=True
MinVersion=0,6.1
UninstallDisplayIcon={uninstallexe}
UsePreviousAppDir=False
UsePreviousGroup=False
CreateUninstallRegKey=no
DirExistsWarning=no
WizardSmallImageFile=small_logo.bmp
WizardImageStretch=False
WizardImageFile=big_logo.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"


[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{app}\Languages\Strings*.txt"; DestDir: "{app}\Languages-{code:GetTodaysName}"; Flags: external setntfscompression skipifsourcedoesntexist
Source: "..\src\bin\Release\*.exe"; DestDir: "{app}"; Flags: ignoreversion; Excludes: "*vshost*"
Source: "..\src\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\src\bin\Release\*.config"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: "*vshost*"
Source: "..\src\bin\Release\*.manifest"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: "*vshost*"
Source: "{#DevExpressPath}DevExpress.Charts.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Data.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Mvvm.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Office.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.PivotGrid.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Printing.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.RichEdit.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Sparkline.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Utils.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Utils.v14.2.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.Xpo.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraBars.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraCharts.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraEditors.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraGauges.v14.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraGrid.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraLayout.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraPrinting.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraReports.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraTreeList.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.DataAccess.v14.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DevExpressPath}DevExpress.XtraReports.v14.2.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PrizmExternalPath}\external\DotNetFX45\dotnetfx45_full_x86_x64.exe"; DestDir: "{tmp}"; DestName: "dotnetfx45_full_x86_x64.exe"; Flags: ignoreversion nocompression; Check: not IsRequiredDotNetDetected
Source: "{#PrizmExternalPath}\external\LocalDb\SqlLocaLDB_x86.MSI"; DestDir: "{tmp}"; DestName: "SqlLocalDB.MSI"; Flags: ignoreversion nocompression; Check: not Is64BitInstallMode and not IsLocalDb11Installed
Source: "{#PrizmExternalPath}\external\LocalDb\SqlLocalDB_x64.MSI"; DestDir: "{tmp}"; DestName: "SqlLocalDB.MSI"; Flags: ignoreversion nocompression; Check: Is64BitInstallMode and not IsLocalDb11Installed
Source: "{#PrizmExternalPath}\external\msodbcsql\msodbcsql_x86.msi"; DestDir: "{tmp}"; DestName: "msodbcsql.msi"; Flags: ignoreversion nocompression; Check: not Is64BitInstallMode and not IsMsOdbcSqlInstalled
Source: "{#PrizmExternalPath}\external\msodbcsql\msodbcsql_x64.msi"; DestDir: "{tmp}"; DestName: "msodbcsql.msi"; Flags: ignoreversion nocompression; Check: Is64BitInstallMode and not IsMsOdbcSqlInstalled
Source: "{#PrizmExternalPath}\external\Lang\ResGen.exe"; DestDir: "{app}\Languages\Resources"; Flags: ignoreversion
Source: ".\Lang\run.bat"; DestDir: "{app}\Languages"; Flags: ignoreversion
Source: ".\Lang\cultures.txt"; DestDir: "{app}\Languages"; Flags: ignoreversion
Source: ".\Lang\!ReadMe.txt"; DestDir: "{app}\Languages"; Flags: ignoreversion
Source: ".\Lang\Res\*.resources"; DestDir: "{app}\Languages\Resources"; Flags: ignoreversion
Source: "..\src\PrizmMainProject\Languages\LocalizedStrings\*.txt"; DestDir: "{app}\Languages"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: ".\Seeding\defectList.txt"; DestDir: "{app}\Seeding"; DestName: "defectList.txt"; Flags: ignoreversion; Attribs: hidden; Permissions: everyone-full

[Icons]
Name: "{group}\{#MyAppName}-{code:GetProjectName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}-{code:GetProjectName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}-{code:GetProjectName}"; Filename: {uninstallexe}


[Run]
Filename: "{app}\{#MyAppExeName}"; Flags: nowait postinstall skipifsilent; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}-{code:GetProjectName}"
Filename: "{tmp}\dotnetfx45_full_x86_x64.exe"; Parameters: "/passive /norestart"; WorkingDir: "{tmp}"; Description: "Windows system requirements"; StatusMsg: "{cm:InstallingNet45}"; Check: not IsRequiredDotNetDetected
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.MSI"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; WorkingDir: "{tmp}"; Description: "{cm:InstallingSQLLocalDb}"; StatusMsg: "{cm:InstallingSQLLocalDb}"; Check: not IsLocalDb11Installed
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\msodbcsql.msi"" /qn IACCEPTMSODBCSQLLICENSETERMS=YES"; WorkingDir: "{tmp}"; Description: "{cm:InstallingMsOdbcSql}"; StatusMsg: "{cm:InstallingMsOdbcSql}"; Check: not IsMsOdbcSqlInstalled
Filename: "{app}\{#MyAppMigratorExeName}"; Parameters: "0"; WorkingDir: "{app}"; Flags: runhidden; Description: "{cm:CreatingPrizmDatabase}"; StatusMsg: "{cm:CreatingPrizmDatabase}"; BeforeInstall: UpdateConfig; AfterInstall: PrepareDatabase

[Dirs]
Name: "{app}\Data"; Attribs: hidden; Permissions: everyone-full
Name: "{app}\Languages"; Permissions: everyone-full
Name: "{app}\Languages\Resources"; Attribs: hidden; Permissions: everyone-full
Name: "{app}\Logs"; Attribs: hidden; Permissions: everyone-full
Name: "{app}\Seeding"; Attribs: hidden; Permissions: everyone-full
Name: "{app}\Importing"; Attribs: hidden; Permissions: everyone-full

[CustomMessages]
english.InstallingSQLLocalDb=Installing SQL LocalDb
russian.InstallingSQLLocalDb=Инсталяция SQL LocalDb
english.CreatingPrizmDatabase=Creating Prism Database
russian.CreatingPrizmDatabase=Создание Базы Данных
english.UpdateConfigurationFile=Update Configuration File
russian.UpdateConfigurationFile=Обновление файлов конфигурации
english.InstallingNet45=Installing Microsoft Framework 4.5. Please wait...
russian.InstallingNet45=Идет установка .NET Framework 4.5. Это может занять несколько минут...
english.ErrorCreateDB=Error while creating Prism Database. Please, contact system administrator
russian.ErrorCreateDB=Ошибка во время создания базы данных. Свяжитесь с администратором
english.UnInstallingDBSubCaption=Deleting database files
russian.UnInstallingDBSubCaption=Удаление базы данных
english.UnInstallingDB=Do you want to delete Database files and Project settings?
russian.UnInstallingDB=Вы хотите удалить файлы Базы Данных и настройки проекта?
english.UnInstallingDBCheck=Delete All
russian.UnInstallingDBCheck=Удалить все
english.UsagePageCaption=Installation mode
russian.UsagePageCaption=Режим инсталяции
english.UsagePageDescription=Please, select installation mode
russian.UsagePageDescription=Выберите режим инсталяции
english.UsagePageSubCaption=Please, select installation mode:
russian.UsagePageSubCaption=Пожалуйста, выберите режим инсталяции программы:
english.UsagePageInstallOption=Install new project
russian.UsagePageInstallOption=Установить новый проект
english.UsagePageUpgradeOption=Update existing project
russian.UsagePageUpgradeOption=Обновить существующий проект
english.NewProductPageCaption=Installing New Project
russian.NewProductPageCaption=Установка Нового Проекта
english.NewProductPageDescription=Specify new Project settings
russian.NewProductPageDescription=Укажите настройки нового Проекта
english.NewProductPageSubCaption=Please, specify the name of new Project. Name should be unique on this PC. If name is already registered, you will be notified. 
russian.NewProductPageSubCaption=Пожалуйста, введите название нового Проекта. Название Проекта должно быть уникальным на этом компьютере. Если введенное имя уже зарегистрировано, система сообщит Вам об этом.
english.NewProductPageProjectName=Project Name:
russian.NewProductPageProjectName=Название Проекта:
english.NewProductPageNewWorkstationType=Workstation Type:
russian.NewProductPageNewWorkstationType=Тип Рабочей Станции:
english.NewProductPageNewWorkstationTypeOption1=Master  
russian.NewProductPageNewWorkstationTypeOption1=Мастер
english.NewProductPageNewWorkstationTypeOption2=Mill
russian.NewProductPageNewWorkstationTypeOption2=Завод
english.NewProductPageNewWorkstationTypeOption3=Construction
russian.NewProductPageNewWorkstationTypeOption3=Строительство
english.SpecifyProjectName=Project Name can't be empty
russian.SpecifyProjectName=Пожалуйста, укажите Имя Проекта
english.ProjectNameNotUnique=Project Name is not unique. Please, specify other name
russian.ProjectNameNotUnique=Название Проекта не уникально. Пожалуйста, укажите другое название
english.ProgressPageCaption=Searching existing Projects
russian.ProgressPageCaption=Поиск установленных Проектов
english.ProgressPageDescription=Now we are trying to search all Projects installed on your PC
russian.ProgressPageDescription=Сейчас осуществляется поиск Проектов установленных на этот компьютер
english.ProgressPageSubCaption=Searching existing Projects...
russian.ProgressPageSubCaption=Поиск установленных Проектов...
english.NoInstalledProjects=There are no Projects installed on this PC. Please, install new Project
russian.NoInstalledProjects=На этом компьютере не обнаружено установленных проектов. Пожалуйста установите новый проект
english.UpdateProductPageCaption=Updating Existing Project
russian.UpdateProductPageCaption=Обновление существующего Проекта
english.UpdateProductPageDescription=Updating Existing Project binaries and database
russian.UpdateProductPageDescription=Обновление программных файлов и базы данных
english.UpdateProductPageSubCaption=Please, select the name of existing Project that will be updated to version %1:
russian.UpdateProductPageSubCaption=Пожалуйста, укажите название установленного Проекта, который необходимо обновить до версии %1:
english.SpecifyExistingProjectName=Please, select the name of existing Project
russian.SpecifyExistingProjectName=Выберите название существующего Проекта
english.ProjectNameValidation=Please, use English letters or digits. Don't start with digit. Dont use system name master, model.
russian.ProjectNameValidation=Пожайлуста, используйте английские буквы и цифры. Не начинайте с цифры. Не используйте зарезервированные имена master, model. 
english.ConfirmDowngrade=Version of current installation (%1) is lower or the same as installed version (%2). Do you really want to continue update?
russian.ConfirmDowngrade=Версия текущей инсталяции (%1) меньше либо равна уже установленной версии (%2). Вы действительно хотите продолжить?
english.InstallingMsOdbcSql=Installing Microsoft ODBC Driver for SQL Server
russian.InstallingMsOdbcSql=Установка Microsoft ODBC Driver for SQL Server


[Registry]
Root: HKLM; Subkey: "Software\{#PrizmRoot}"; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: "Software\{#PrizmRoot}\{code:GetProjectName}"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\{#PrizmRoot}\{code:GetProjectName}"; ValueType: string; ValueName: "Name"; ValueData: "{code:GetProjectName}"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\{#PrizmRoot}\{code:GetProjectName}"; ValueType: string; ValueName: "Path"; ValueData: "{app}"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\{#PrizmRoot}\{code:GetProjectName}"; ValueType: string; ValueName: "Version"; ValueData: "{#MyAppVersion}"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\{#PrizmRoot}\{code:GetProjectName}"; ValueType: string; ValueName: "Group"; ValueData: "{code:GetGroup}"; Flags: uninsdeletekey


[Code]
var
  NewProductPage: TWizardPage;
  UpdateProductPage: TInputOptionWizardPage;
  UsagePage: TInputOptionWizardPage;
  ProgressPage: TOutputProgressWizardPage;
  UpdateProductPageFilled: Boolean;
  OriginalSelectDirCaption: String;
  OriginalSelectGroupCaption: String;
  InstalledProjects: TArrayOfString;
  InstalledProjectsRead: Boolean;
  NewProductName : TNewEdit;
  NewWorkstationType : TNewCheckListBox;
  TodaysName : String;

function GetToday : String;
begin
  Result := GetDateTimeString ('yyyy/mm/dd hh.nn.ss', '-', #0);
end;

function GetTodaysName (Param: String): String;
begin
  if ('' = TodaysName) then
  begin
    TodaysName := GetToday ();
  end;
  Result := TodaysName;
end;

function GetInstalledProjects(): TArrayOfString;
begin
  if InstalledProjectsRead = False then
  begin
    RegGetSubkeyNames(HKLM, 'SOFTWARE\{#PrizmRoot}', InstalledProjects);
    InstalledProjectsRead := True;
  end;
  Result := InstalledProjects;
end;


function IsProjectNameUnique(ProjectName: String): Boolean;
var
  I : Integer;
  Names : TArrayOfString;
begin
  Result := True;
  Names := GetInstalledProjects()
  for I := 0 to GetArrayLength(Names)-1 do
  begin
    if CompareText(Names[I], ProjectName) = 0 then
    begin
      Result := False
    end
  end;
end;


function GetInstalledProjectProp(Index: Integer; Prop: String): String;
var
  Name : String;
  Path : String;
  Names : TArrayOfString;
begin
  Names := GetInstalledProjects();
  Name := Names[Index];
  if RegQueryStringValue(HKLM, 'SOFTWARE\{#PrizmRoot}' + '\' + Name, Prop, Path) then
    Result := Path
  else 
    Result := ''
end;


function GetInstalledProjectName(Index: Integer): String;
begin
    Result := GetInstalledProjectProp(Index, 'Name');
end;


function GetInstalledProjectPath(Index: Integer): String;
begin
    Result := GetInstalledProjectProp(Index, 'Path');
end;


function GetInstalledProjectVersion(Index: Integer): String;
begin
    Result := GetInstalledProjectProp(Index, 'Version');
end;


function GetInstalledProjectGroup(Index: Integer): String;
begin
  Result := GetInstalledProjectProp(Index, 'Group');
end;


procedure FillUpdateProductPage();
var
  Names: TArrayOfString;
  I : Integer;
begin
  if UpdateProductPageFilled = False then
  begin
    UpdateProductPageFilled := True;
    Names := GetInstalledProjects();
    for I := 0 to GetArrayLength(Names)-1 do
    begin
      UpdateProductPage.Add('' + Names[I] + ' (' + GetInstalledProjectVersion(I) + ')');
    end;
  end;
end;


procedure UpdateProductPage_OnActivate(Sender: TWizardPage);
begin
  FillUpdateProductPage();
end;


function GetUpdateProductName : String;
begin
  Result := GetInstalledProjectName(UpdateProductPage.SelectedValueIndex)
end;


function GetUpdateProductDir : String;
begin
  Result := GetInstalledProjectPath(UpdateProductPage.SelectedValueIndex)
end;

function GetUpdateProductGroup : String;
begin
  Result := GetInstalledProjectGroup(UpdateProductPage.SelectedValueIndex)
end;

function GetUpdateProductVersion : String;
begin
  Result := GetInstalledProjectVersion(UpdateProductPage.SelectedValueIndex)
end;


function IsNewInstall : Boolean;
begin
  Result := UsagePage.SelectedValueIndex = 0;
end;


function IsUpdate : Boolean;
begin
  Result := UsagePage.SelectedValueIndex = 1;
end;


function GetProjectName(Param1: String): String;
begin
  if IsNewInstall then
    Result := NewProductName.Text
  else
    Result := GetUpdateProductName()
end;

function SetUsersLanguage(): String;
begin
if ActiveLanguage='russian' then Result:='ru-Ru' else Result:='en-Us';
end;

function ValidateProjectName(name : String) : Boolean;
var n : Integer;
    b : String;
begin
  Result := True;
  If ((name = 'Tempdb') or(name = 'tempdb') or (name = 'Msdb') or(name = 'msdb') or (name = 'Model') or(name = 'model') or(name = 'Master') or (name = 'master')) then Result := False;      
  for n := 1 to Length(name) do
  begin
    b := Copy(name,n,1);
    If ((n = 1) and ((b >= '0') and (b <= '9')))
    then
      Result := False;
    If not (((b >= 'a') and (b <= 'z')) or ((b >= 'A') and (b <= 'Z')) or ((b >= '0') and (b <= '9')))
    then
      Result := False;
  end;
end;

function GetWorkstationTypeValue : String;
begin
  if NewWorkstationType.Checked[1] = True then
    Result := 'Master'
  else if NewWorkstationType.Checked[2] = True then
    Result := 'Mill'
  else 
    Result := 'Construction';
end;


//-----------------------
// Compare Versions Start
//-----------------------
function GetGroup(Param1: String) : String;
begin
  Result := WizardForm.GroupEdit.Text;
end;

function GetNumber(var temp: String): Integer;
var
  part: String;
  pos1: Integer;
begin
//   Log('temp: ' + temp);
  if Length(temp) = 0 then
  begin
    Result := -1;
    Exit;
  end;
    pos1 := Pos('.', temp);
    if (pos1 = 0) then
    begin
      Result := StrToInt(temp);
      temp := '';
    end
    else
    begin
      part := Copy(temp, 1, pos1 - 1);
      temp := Copy(temp, pos1 + 1, Length(temp));
      Result := StrToInt(part);
    end;
end;
 
function CompareInner(var temp1, temp2: String): Integer;
var
  num1, num2: Integer;
begin
  num1 := GetNumber(temp1);
  num2 := GetNumber(temp2);
  if (num1 = -1) or (num2 = -1) then
  begin
    Result := 0;
    Exit;
  end;
      if (num1 > num2) then
      begin
        Result := 1;
      end
      else if (num1 < num2) then
      begin
        Result := -1;
      end
      else
      begin
        Result := CompareInner(temp1, temp2);
      end;
end;

function CompareVersions(str1: String; str2 :String): Integer;
var
  temp1, temp2: String;
begin
    temp1 := str1;
    temp2 := str2;
    Result := CompareInner(temp1, temp2);
end;

//-----------------------
// Compare Versions End
//-----------------------


procedure InitializeWizard;
var
  StaticText, StaticText1 : TNewStaticText;
  
begin
  { Create the pages }
  OriginalSelectDirCaption := WizardForm.SelectDirBrowseLabel.Caption;
  OriginalSelectGroupCaption := WizardForm.SelectStartMenuFolderBrowseLabel.Caption;
  
  UsagePage := CreateInputOptionPage(wpWelcome,
    CustomMessage('UsagePageCaption'), CustomMessage('UsagePageDescription'),
    CustomMessage('UsagePageSubCaption'),
    True, False);
  UsagePage.Add(CustomMessage('UsagePageInstallOption'));
  UsagePage.Add(CustomMessage('UsagePageUpgradeOption'));
  UsagePage.SelectedValueIndex := 0;

  NewProductPage := CreateCustomPage(UsagePage.ID,
    CustomMessage('NewProductPageCaption'), CustomMessage('NewProductPageDescription'));

  StaticText := TNewStaticText.Create(NewProductPage);
  StaticText.Caption := CustomMessage('NewProductPageSubCaption');
  StaticText.Width := NewProductPage.SurfaceWidth;
  StaticText.AutoSize := True;
  StaticText.WordWrap := True;
  StaticText.Parent := NewProductPage.Surface;

  StaticText1 := TNewStaticText.Create(NewProductPage);
  StaticText1.Top := StaticText.Top + StaticText.Height + ScaleY(8);
  StaticText1.Caption := CustomMessage('NewProductPageProjectName');
  StaticText1.AutoSize := True;
  StaticText1.Parent := NewProductPage.Surface;

  NewProductName := TNewEdit.Create(NewProductPage);
  NewProductName.Top := StaticText1.Top + StaticText1.Height + ScaleY(1);
  NewProductName.Width := NewProductPage.SurfaceWidth;
  NewProductName.Text := '';
  NewProductName.Parent := NewProductPage.Surface;

  NewWorkstationType := TNewCheckListBox.Create(NewProductPage);
  NewWorkstationType.Top := NewProductName.Top + NewProductName.Height + ScaleY(8);
  NewWorkstationType.Width := NewProductPage.SurfaceWidth;
  NewWorkstationType.Height := ScaleY(97);
  NewWorkstationType.BorderStyle := bsNone;
  NewWorkstationType.ParentColor := True;
  NewWorkstationType.MinItemHeight := WizardForm.TasksList.MinItemHeight;
  NewWorkstationType.ShowLines := False;
  NewWorkstationType.WantTabs := True;
  NewWorkstationType.Parent := NewProductPage.Surface;
  NewWorkstationType.AddGroup(CustomMessage('NewProductPageNewWorkstationType'), '', 0, nil);
  NewWorkstationType.AddRadioButton(CustomMessage('NewProductPageNewWorkstationTypeOption1'), '', 0, True, True, nil);
  NewWorkstationType.AddRadioButton(CustomMessage('NewProductPageNewWorkstationTypeOption2'), '', 0, False, True, nil);
  NewWorkstationType.AddRadioButton(CustomMessage('NewProductPageNewWorkstationTypeOption3'), '', 0, False, True, nil);

  UpdateProductPageFilled := False;
  UpdateProductPage := CreateInputOptionPage(UsagePage.ID,
    CustomMessage('UpdateProductPageCaption'), CustomMessage('UpdateProductPageDescription'),
    FmtMessage(CustomMessage('UpdateProductPageSubCaption'), ['{#MyAppVersion}']),
    True, False);
  UpdateProductPage.OnActivate := @UpdateProductPage_OnActivate;

  ProgressPage := CreateOutputProgressPage(CustomMessage('ProgressPageCaption'),
    CustomMessage('ProgressPageDescription'));

end;



function ShouldSkipPage(PageID: Integer): Boolean;
begin
  { Skip pages that shouldn't be shown }
  if (PageID = NewProductPage.ID) and (IsNewInstall = False) then
    Result := True
  else if (PageID = UpdateProductPage.ID) and (IsUpdate = False) then
    Result := True
  else
    Result := False;
end;



function NextButtonClick(CurPageID: Integer): Boolean;
var
  I: Integer;
begin
  GetWorkstationTypeValue();
  { Validate certain pages before allowing the user to proceed }
  if CurPageID = NewProductPage.ID then begin
    if NewProductName.Text = '' then begin
      MsgBox(CustomMessage('SpecifyProjectName'), mbError, MB_OK);
      Result := False;
    end 
    else 
    begin
      if IsProjectNameUnique(NewProductName.Text) = False then
      begin
        MsgBox(CustomMessage('ProjectNameNotUnique'), mbError, MB_OK);
        Result := False;
      end
      else
      begin
        if ValidateProjectName(NewProductName.Text) = False then
        begin
          MsgBox(CustomMessage('ProjectNameValidation'), mbError, MB_OK);
          Result := False;
        end
        else
        begin
          Result := True;
        end
      end;
    end;
  end else if (CurPageID = UsagePage.ID) and (IsUpdate = True) then begin
    ProgressPage.SetText(CustomMessage('ProgressPageSubCaption'), '');
    ProgressPage.SetProgress(0, 0);
    ProgressPage.Show;
    try
      for I := 0 to 10 do begin
        ProgressPage.SetProgress(I, 10);
        Sleep(100);
      end;
    finally
      ProgressPage.Hide;
    end;
    if GetArrayLength(GetInstalledProjects()) > 0 then
      Result := True
    else begin
      MsgBox(CustomMessage('NoInstalledProjects'), mbInformation, MB_OK);
      Result := False;
    end;
  end else if CurPageId = UpdateProductPage.ID then begin
    if UpdateProductPage.SelectedValueIndex = -1 then begin
      MsgBox(CustomMessage('SpecifyExistingProjectName'), mbError, MB_OK);
      Result := False;
    end 
    else
    begin
      if CompareVersions(GetUpdateProductVersion(), '{#MyAppVersion}') >= 0 then
      begin
        if MsgBox(FmtMessage(CustomMessage('ConfirmDowngrade'), [GetUpdateProductVersion(), '{#MyAppVersion}']), mbConfirmation, MB_YESNO) = IDYES then 
        begin
          Result := True;
        end
        else 
        begin
          Result := False;
        end
      end
      else
      begin
        Result := True;
      end
    end
  end else
    Result := True;
end;


procedure CurPageChanged(CurPageID: Integer);
begin
  if CurPageID = wpSelectDir then
    if IsNewInstall then
    begin
      WizardForm.DirEdit.Text := ExpandConstant('{pf}\{#PrizmRoot}\') + GetProjectName('');
      WizardForm.SelectDirBrowseLabel.Caption := OriginalSelectDirCaption;
      WizardForm.DirEdit.Enabled := True;
      WizardForm.DirBrowseButton.Visible := True;
    end
    else
    begin
      WizardForm.DirEdit.Text := GetUpdateProductDir();
      WizardForm.SelectDirBrowseLabel.Caption := '';
      WizardForm.DirEdit.Enabled := False;
      WizardForm.DirBrowseButton.Visible := False;
    end
  else if CurPageID = wpSelectProgramGroup then
    if IsNewInstall then
    begin
      WizardForm.GroupEdit.Text := ExpandConstant('{#PrizmRoot}\') + GetProjectName('');
      WizardForm.SelectStartMenuFolderBrowseLabel.Caption := OriginalSelectGroupCaption;
      WizardForm.GroupEdit.Enabled := True;
      WizardForm.GroupBrowseButton.Visible := True;
      WizardForm.NoIconsCheck.Enabled := True;
    end
    else
    begin
      WizardForm.GroupEdit.Text := GetUpdateProductGroup();
      WizardForm.SelectStartMenuFolderBrowseLabel.Caption := '';
      WizardForm.GroupEdit.Enabled := False;
      WizardForm.GroupBrowseButton.Visible := False;
      WizardForm.NoIconsCheck.Enabled := False;
    end;
end;



function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1.4322'     .NET Framework 1.1
//    'v2.0.50727'    .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key: string;
    install, release, serviceCount: cardinal;
    check45, success: boolean;
var reqNetVer : string;
begin
    // .NET 4.5 installs as update to .NET 4.0 Full
    if version = 'v4.5' then begin
        version := 'v4\Full';
        check45 := true;
    end else
        check45 := false;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + version;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0/4.5 uses value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 uses additional value Release
    if check45 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= 378389);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;


// Check if .NET 4.5 is installed on the target PC
function IsRequiredDotNetDetected(): Boolean;  
begin
    result := IsDotNetDetected('v4.5', 0);
end;


// Check if MS ODBC SQL Driver installed on the target PC
function IsMsOdbcSqlInstalled(): Boolean;
begin
  if RegKeyExists(HKLM, 'SOFTWARE\ODBC\ODBCINST.INI\ODBC Driver 11 for SQL Server') then
  begin
    Result := true;
  end 
  else 
  begin
    Result := false;
  end;
end;


// Check if SQL LocalDB 11 is installed on the target PC
function IsLocalDb11Installed(): Boolean;
begin
  if RegKeyExists(HKLM, 'SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\11.0') then
  begin
    Result := true;
  end 
  else 
  begin
    Result := false;
  end;
end;

procedure UpdateConfig();
var
  XMLDoc, RootNode, Nodes, Node: Variant;
  ConfigFilename, Key: String; 
  i: integer;

begin
  WizardForm.StatusLabel.Caption := CustomMessage('UpdateConfigurationFile');

  ConfigFilename := ExpandConstant('{app}') + '\' + ExpandConstant('{#MyAppExeConfigName}');

  try
      XMLDoc := CreateOleObject('MSXML2.DOMDocument');
  except
    RaiseException('MSXML is required to complete the post-installation process.'#13#13'(Error ''' + GetExceptionMessage + ''' occurred)');
  end;  

  XMLDoc.async := False;
  XMLDoc.resolveExternals := False;
  XMLDoc.load(ConfigFilename);

  if XMLDoc.parseError.errorCode <> 0 then
    RaiseException('Error on line ' + IntToStr(XMLDoc.parseError.line) + ', position ' + IntToStr(XMLDoc.parseError.linepos) + ': ' + XMLDoc.parseError.reason);

  RootNode := XMLDoc.documentElement;
  
  // update connection string
  Nodes := RootNode.selectNodes('//configuration/connectionStrings/add');
    
  for i := 0 to Nodes.length - 1 do
  begin
    Node := Nodes.Item[i];
    if Node.NodeType = 1 then
    begin
      key := Node.getAttribute('name');
      Case key of
        'PrismDatabase' : Node.setAttribute('connectionString', 'Data Source=(LocalDb)\v11.0;Initial Catalog=' + GetProjectName('') + ';Integrated Security=true;AttachDBFileName=' + ExpandConstant('{app}') + '\Data\' + GetProjectName('') + '.mdf');
      end;
    end;
  end;  
  
  //update user settings
  Nodes := RootNode.selectNodes('//configuration/userSettings/Prizm.Main.Properties.Settings/setting');
  
  for i := 0 to Nodes.length - 1 do
  begin
    Node := Nodes.Item[i];
    if Node.NodeType = 1 then 
	begin
		key := Node.getAttribute('name');
		Case key of	  
		'UsersLanguage' : Node.childNodes[0].text := SetUsersLanguage();	   
	    end;
	end;
  end; 
	

  if IsNewInstall then
  begin
    // update project settigns
    Nodes := RootNode.selectNodes('//configuration/appSettings/add');
    
    for i := 0 to Nodes.length - 1 do
    begin
      Node := Nodes.Item[i];
      if Node.NodeType = 1 then
      begin
        key := Node.getAttribute('key');
        Log('key: ' + key);
        Case key of
          'ProjectName' : Node.setAttribute('value', GetProjectName(''));
        end;
        Case key of
          'WorkstationType' : Node.setAttribute('value', GetWorkstationTypeValue());
        end;
      end;
    end;
  end;
  
  XMLDoc.Save(ConfigFilename); 

end;

procedure PrepareDatabase();
var
 ResCode : Integer;
begin
 // run database migrator and check error code
 WizardForm.StatusLabel.Caption := CustomMessage('CreatingPrizmDatabase');
 if Exec(ExpandConstant('{app}\{#MyAppMigratorExeName}'), '1', ExpandConstant('{app}'), SW_HIDE, ewWaitUntilTerminated, ResCode) then
 begin
   // Program Ran successfully ResCode now contains exit code results
   if resCode <> 0 then
   begin
      MsgBox(CustomMessage('ErrorCreateDB'), mbError, MB_OK);
   end;       
 end
 else
 begin
   // Problem running Program
   MsgBox(CustomMessage('ErrorCreateDB'), mbError, MB_OK);
 end;

end;


// -----------------------
// UnInstall Process Start
// -----------------------
function ShowCustomUninstallForm() : Boolean;
var
  Form: TSetupForm;
  StaticText, HeaderStaticText, HeaderStaticText2: TNewStaticText;
  CheckBox: TNewCheckBox;
  OKButton: TNewButton;
  TopPanel, BottomPanel : TPanel;
begin
  Form := CreateCustomForm();
  try
    Form.Caption := SetupMessage(msgUnInstallAppTitle);
    Form.SetBounds(0, 0, UninstallProgressForm.Width, UninstallProgressForm.Height);
    Form.Position := poOwnerFormCenter;

    TopPanel := TPanel.Create(Form);
    TopPanel.Top := ScaleY(0);
    TopPanel.Left := ScaleX(0);
    TopPanel.Width := Form.Width;
    TopPanel.Height := ScaleY(60);
    TopPanel.Color := clWhite;
    TopPanel.ParentBackground := False;
    TopPanel.Parent := Form;

    BottomPanel := TPanel.Create(Form);
    BottomPanel.Top := Form.Height - ScaleY(120);
    BottomPanel.Left := ScaleX(0);
    BottomPanel.Width := Form.Width;
    BottomPanel.Height := ScaleY(50);
    BottomPanel.Parent := Form;

    HeaderStaticText := TNewStaticText.Create(Form);
    HeaderStaticText.Top := ScaleY(12);
    HeaderStaticText.Left := ScaleX(25);
    HeaderStaticText.Caption := SetupMessage(msgUnInstallAppTitle);
    HeaderStaticText.AutoSize := True;
    HeaderStaticText.Parent := TopPanel;
    HeaderStaticText.Font.Style := [fsBold];

    HeaderStaticText2 := TNewStaticText.Create(Form);
    HeaderStaticText2.Top := ScaleY(28);
    HeaderStaticText2.Left := ScaleX(40);
    HeaderStaticText2.Caption := CustomMessage('UnInstallingDBSubCaption');
    HeaderStaticText2.AutoSize := True;
    HeaderStaticText2.Parent := TopPanel;

    StaticText := TNewStaticText.Create(Form);
    StaticText.Top := ScaleY(74);
    StaticText.Left := ScaleX(40);
    StaticText.Caption := CustomMessage('UnInstallingDB');
    StaticText.AutoSize := True;
    StaticText.Parent := Form;
    

    CheckBox := TNewCheckBox.Create(Form);
    CheckBox.Top := ScaleY(100);
    CheckBox.Left := ScaleX(45);
    CheckBox.Width := ScaleX(100);
    CheckBox.Height := ScaleY(17);
    CheckBox.Caption := CustomMessage('UnInstallingDBCheck');
    CheckBox.Checked := False;
    CheckBox.Parent := Form;

    OKButton := TNewButton.Create(Form);
    OKButton.Parent := Form;
    OKButton.Width := ScaleX(75);
    OKButton.Height := ScaleY(23);
    OKButton.Left := Form.ClientWidth - ScaleX(75 + 10);
    OKButton.Top := Form.ClientHeight - ScaleY(23 + 10);
    OKButton.Caption := SetupMessage(msgButtonNext);
    OKButton.ModalResult := mrOk;
    OKButton.Default := True;

    Form.ActiveControl := CheckBox;

    Form.ShowModal();
    Result := CheckBox.Checked
  finally
    Form.Free();
  end;
end;


procedure InitializeUninstallProgressForm;
var
  appDataDir : String;
begin
    appDataDir := ExpandConstant('{app}\Data');
     if DirExists(appDataDir) then
     begin
       if ShowCustomUninstallForm() = True
       then begin
         try
           DelTree(appDataDir, true, true, true);
           DelTree(ExpandConstant('{app}'), true, true, true);
         except
           // do nothing
         end;
       end;
     end;
end;
// ---------------------
// UnInstall Process End
// ---------------------