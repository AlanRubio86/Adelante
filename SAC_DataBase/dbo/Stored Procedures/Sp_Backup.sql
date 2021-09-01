CREATE  proc Sp_Backup
@archivo varchar(200)
as
BACKUP DATABASE sensalaserdb TO DISK = @archivo
WITH FORMAT, INIT, STATS = 10