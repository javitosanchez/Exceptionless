@echo off
robocopy %WEBROOT_PATH%\App_Data\JobRunner JobRunner /MIR /NP /NJH /NJS /NFL /NDL /NC /NS
JobRunner\job.exe /jobtype:"Exceptionless.Core.Jobs.EventPostsJob, Exceptionless.Core" /c