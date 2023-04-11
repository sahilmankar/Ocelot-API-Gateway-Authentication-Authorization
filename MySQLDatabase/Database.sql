DROP DATABASE If EXISTS transflower;
CREATE DATABASE  transflower;
USE  transflower;
CREATE TABLE Departments(id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
                         name VARCHAR(25),     
                         location VARCHAR(25));
INSERT INTO Departments(name,location) VALUES('IT','Pune'); 
INSERT INTO Departments(name,location) VALUES ('Marketing','Nashik');
INSERT INTO Departments(name,location) VALUES ('Training','Mumbai');
INSERT INTO Departments(name,location) VALUES ('PMO','Mumbai');

CREATE TABLE users( user_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                    email VARCHAR(25) UNIQUE NOT NULL,
                    password VARCHAR(15) NOT NULL);
CREATE TABLE roles(role_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                     role varchar(50));
CREATE TABLE user_roles(user_id INT NOT NULL,
                        CONSTRAINT  fk_user_id FOREIGN KEY(user_id) REFERENCES users(user_id) ON UPDATE CASCADE ON DELETE CASCADE ,
                        role_id INT NOT NULL,
                        CONSTRAINT fk_role_id FOREIGN KEY(role_id) REFERENCES roles(role_id) ON UPDATE CASCADE ON DELETE CASCADE);


INSERT INTO users(email,password) VALUES ('admin123@gmail.com','admin123');
INSERT INTO users(email,password) VALUES ('user123@gmail.com','user123');
INSERT INTO roles(role) VALUES('Admin');
INSERT INTO roles(role) VALUES('User');
INSERT INTO user_roles(user_id,role_id) VALUES(1,1);
INSERT INTO user_roles(user_id,role_id) VALUES(2,2);



