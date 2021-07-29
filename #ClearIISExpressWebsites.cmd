cd "C:\Program Files (x86)\IIS Express\"
appcmd.exe list site /xml | appcmd delete site /in
pause