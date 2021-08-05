add-migration <Migration Name> -ProjectName 'Savitar.Infrastructure.Repository.EFCore' -StartupProjectName 'Savitar.Server' -verbose
update-database -ProjectName 'Savitar.Infrastructure.Repository.EFCore' -StartupProjectName 'Savitar.Server' -verbose

ROLL BACK TO SPECIFIC MIGRATION
update-database -ProjectName 'Savitar.Infrastructure.Repository.EFCore' -StartupProjectName 'Savitar.Server' -verbose -TargetMigration:<Migration to roll back to>

ROLL BACK ALL MIGRATIONS AND START OVER
update-database -ProjectName 'Savitar.Infrastructure.Repository.EFCore' -StartupProjectName 'Savitar.Server' -verbose -TargetMigration:0
