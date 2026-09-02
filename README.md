# active-directory-ldap-tools

**Source last updated:** 2013-10-22

C# Visual Studio 2012 LDAP helper and ManageUsers WinForms app for Active Directory user lookup. The AD class library talks to System.DirectoryServices and related LDAP APIs; ManageUsers is a small Convert-button host around Helper.GetUser, which is still unfinished. A source comment points at the old ADLinq CodePlex project. This is a historical working copy from Dave Robinson / VaderConsulting, published so the project can be found and understood from GitHub.

**Language:** C#  
**Target:** .NET Framework 4.0 / Visual Studio 2012  
**Output:** Class library (AD) and WinExe (ManageUsers)

## What it is

C# Visual Studio 2012 LDAP helper and ManageUsers WinForms app for Active Directory user lookup. The AD class library talks to System.DirectoryServices and related LDAP APIs; ManageUsers is a small Convert-button host around Helper.GetUser, which is still unfinished. A source comment points at the old ADLinq CodePlex project. This is a historical working copy from Dave Robinson / VaderConsulting, published so the project can be found and understood from GitHub.

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `AD` | C# | `AD/AD.csproj` |
| `ManageUsers` | C# | `ManageUsers/ManageUsers.csproj` |

## How to open

Open `LDAP.sln` in Visual Studio.

## Attribution and provenance

- **Assembly copyright:** Copyright ©  2013
- Source comment in `AD/Helper.cs` references http://adlinq.codeplex.com/
- A hardcoded test password in `ManageUsers/frmMain.cs` was replaced with `REDACTED` before publish.

## License

MIT. See `LICENSE`.
