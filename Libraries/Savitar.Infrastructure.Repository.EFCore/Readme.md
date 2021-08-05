## Copy/Paste for DB migrations
add-migration <Migration Name> -verbose
update-database -verbose

ROLL BACK TO SPECIFIC MIGRATION
update-database <migration name> -verbose 

ROLL BACK ALL MIGRATIONS AND START OVER
update-database 0 -verbose
