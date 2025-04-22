# Online Library Website

## Overview

An interactive online platform that allows users to browse, search, and borrow books.  
The system supports two roles: **Admin** and **User**, each with distinct functionalities.  
Developed as part of a university project to practice web development, backend integration, and database management.

## Features

### Common (Admin & User)

- Sign up with: `username`, `password`, `confirm password`, `email`, `is_admin`  
- Login  
- Responsive navigation bar accessible from all pages  
- Navigation content changes based on user role

---

### Admin Capabilities

- Add new books with:
  - `ID`, `Book Name`, `Author`, `Category`, `Description`
- View all available books
- Edit book details
- Delete books

---

### User Capabilities

- Search for books by `title`, `author`, or `category`
- View available books with their availability status
- View detailed book page
- Borrow available books
- View personal list of borrowed books
- return functionality for borrowed books  

## Backend Development

We are actively working on the backend using **Python** and the **Django** web framework to:

- Implement secure user authentication  
- Manage book data using Django models  
- Handle all logic for borrowing and returning books  
- Integrate search and filtering functions through Django views  
- Serve dynamic content using Django templates

## Technical Highlights

- Role-based access control  
- Dynamic user interface based on session role  
- CRUD operations for books  
- Real-time book availability management  
- Structured and responsive navigation bar  
- Backend under development using Django  

## Future Improvements

- Add book ratings or reviews  
- Include admin dashboard with stats and logs  
- Complete backend API integration

## Contact

For more information or feedback, contact: **omarwaleed094@gmail.com**
