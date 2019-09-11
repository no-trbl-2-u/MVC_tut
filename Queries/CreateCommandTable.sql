CREATE TABLE all_commands(
   id serial PRIMARY KEY,
   name VARCHAR (50) UNIQUE NOT NULL,
   command VARCHAR (50) UNIQUE NOT NULL,
   description VARCHAR (355) UNIQUE
);