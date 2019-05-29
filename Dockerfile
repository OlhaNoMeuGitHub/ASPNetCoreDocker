FROM mysql
EXPOSE 3306
COPY DBBackup/backup.sql /docker-entrypoint-initdb.d/backup.sql
