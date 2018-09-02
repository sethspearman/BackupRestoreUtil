# BackupRestoreUtil
This is a winforms utility that can run on a thumb drive (as long as the target PC has .NET installed) and that can be used to backup a SQL Database to the thumb drive.

It can also be used to brute-force restore a database to the system.  As such it must be used with extreme caution.

### USAGE  
Compile the solution using Visual Studio.

The resulting BackupRestoreUtil.exe can be copied to a thumb drive and run from the thumb drive.

Before it will work, though, the **BackupRestoreUtil.exe.config** must be updated with the appSettings keys needed for it to work.  

As an alternative, you can update the code and compile a version of the app for each of your targets, especially the password.  This is really the preferred way of doing it as that will prevent important info from being stored in clear text.  And, of course, will mean you can use the app without the config value being present.

Hopefully, runtime usage is pretty obvious when you run the app.  Let me know if not.

Backups are stored in the appSettings config value that you setup (or hard-coded) and must be created in advance.  If you don't give a name to your backup it will create a datetimestamp name.

Restore lists all of the backups in the dropdown and lists the most recent first.  
**(This will brute-force replace the database.  YOU'VE BEEN WARNED.)**
