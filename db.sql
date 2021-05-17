create database Wash;
go
use Wash;

create table Professions (
id int Identity(1,1) primary key,
[name] varchar(30)
)

insert into Professions values('Мойщик'), ('Старший мойщик')

create table Employers(
id int Identity(1,1) primary key,
profession_id int references Professions(id),
[surname] varchar(30),
telephone varchar(12),
employer_number bigint
)

create table Clients (
id int Identity(1,1) primary key,
[login] varchar(30)
)

create table [Services] (
id int Identity(1,1) primary key,
[name] varchar(100),
price decimal(7,2)
)

create table Scores (
id int Identity(1,1) primary key,
[value] int
)

insert into Scores values(1),(2),(3),(4),(5),(6),(7),(8),(9),(10)

create table Reviews (
id int Identity(1,1) primary key,
score_id int references Scores(id),
client_id int references Clients(id),
employe_id int references Employers(id),
[text] varchar(300)
)

