CREATE TABLE Student
(
  Name VARCHAR(50) NOT NULL,
  PhoneNumber VARCHAR(11),
  Email VARCHAR(50),
  Student_id INT identity(1,1) NOT NULL,
  Age VARCHAR(10) NOT NULL,
  PRIMARY KEY (Student_id)
);


CREATE TABLE loan
(
  due_date NOT NULL DATE,
  date_borrowed DATE NOT NULL,
  date_returned DAte NULL,
  ISBN INT,
  Student_id INT,
  status VARCHAR(50) NOT NULL,
  PRIMARY KEY (Student_id, ISBN),
  FOREIGN KEY (Student_id) REFERENCES Student(Student_id),
  FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);

CREATE TABLE Admins
(
  Admin_id INT identity(1,1) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Phone_number INT NOT NULL,
  PRIMARY KEY (Admin_id)
);
CREATE TABLE book_publisher
(
  location VARCHAR(50) NOT NULL,
  publisher_name VARCHAR(50) NOT NULL,
  publisher_id identity(1,1) INT NOT NULL,
  PRIMARY KEY (publisher_id)
);

CREATE TABLE Books
(
  book_category VARCHAR(50) NOT NULL,
  publisher_id int,
  author VARCHAR(50) NOT NULL,
  publication_year Date ,
  title VARCHAR(100) NOT NULL,
  ISBN INT NOT NULL,
  Admin_id int ,
  PRIMARY KEY (ISBN),
  FOREIGN KEY (publisher_id) REFERENCES book_publisher(publisher_id),
  FOREIGN KEY(Admin_id) REFERENCES Admins(Admin_id)
);

CREATE TABLE Copied_books
(
  condition VARCHAR(50) NOT NULL,
  availability VARCHAR(50) NOT NULL,
  ISBN INT NOT NULL,
  FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);



CREATE TABLE review
(
  title VARCHAR(200) NOT NULL,
  book_rating INT NOT NULL,
  ISBN INT NOT NULL,
  Student_id INT NOT NULL,
  PRIMARY KEY (Student_id, ISBN),
  FOREIGN KEY (Student_id) REFERENCES Student(Student_id),
  FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);

CREATE TABLE Login
(
  Password VARCHAR(50) NOT NULL,
  Username VARCHAR(50) NOT NULL,
  Student_id INT NULL,
  Admin_id INT NULL,
  PRIMARY KEY (Username),
  FOREIGN KEY (Student_id) REFERENCES Student(Student_id),
  FOREIGN KEY (Admin_id) REFERENCES Admins(Admin_id)
);
