# Checkpoint — Diploma project

For the diploma project we were given a sheet with the themes. 
This is one of them. I began to perform those of them that seemed interesting to me, solely for honing my skills and getting practice.

## The program

The idea is that there is a database with information about employees who have a pass to a certain place. 
This program is an interface to this database and allows you to: 
* enter information about new employees
* remove employees
* perform a search among employees, etc.

## Frameworks used
* [MahApps.Metro](https://github.com/MahApps/MahApps.Metro) — The C# WPF Framework used
* [MySQL.Data](https://dev.mysql.com/downloads/connector/net/6.10.html) — MySQL/NET Connector

## Database

The program comes with a ready database
```
Checkpoint 
```
Encoding
```
SET NAMES utf8 COLLATE utf8_general_ci
```

## Tables
### Employees
Name
```
Employees
```
Attributes
```
ID — INT, PRIMARY_KEY, AUTO_INCREMENT
Full_Name — VARCHAR(128)
Serial_And_Passport_Number — INT
Organization — VARCHAR(128)
Confirmed_By_The_Organization — BOOLEAN, default: 0
````
### Report_IN
Name
```
report_IN
```
Attributes
```
ID — INT
DateTime_IN — DATETIME
Session_ID — INT, PRIMARY_KEY, AUTO_INCREMENT
``` 
### Report_OUT
Name
```
report_OUT
```
Attributes
```
ID — INT
DateTime_OUT - DATETIME
Session_ID — INT, FOREIGN KEY, AUTO_INCREMENT
``` 
## Users
CheckpointWorker
```
GRANT SELECT, INSERT ON checkpoint.report_in TO 'CheckpointWorker'@'%'
GRANT SELECT, INSERT ON checkpoint.report_out TO 'CheckpointWorker'@'%'
GRANT SELECT ON checkpoint.employees TO 'CheckpointWorker'@'%'
```
CheckpointAdmin
```
GRANT ALL ON checkpoint.* TO 'CheckpointAdmin'@'%'
```
