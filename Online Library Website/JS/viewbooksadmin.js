
        let books = JSON.parse(localStorage.getItem("books")) || [
            {
                id: 1,
                name: "How to Win Friends and Influence People",
                author: "Dale Carnegie",
                category: "Self-Help",
                description: "A guide to improving social skills and building relationships."
            },
            {
                id: 2,
                name: "The Psychology of Money",
                author: "Morgan Housel",
                category: "Finance",
                description: "Explores how people think about money and make financial decisions."
            },
            {
                id: 3,
                name: "Coraline",
                author: "Neil Gaiman",
                category: "Fantasy",
                description: "A dark fantasy novella about a girl who discovers a parallel world."
            },
            {
                id: 4,
                name: "Harry Potter",
                author: "J.K. Rowling",
                category: "Fantasy",
                description: "A series about a young wizard and his adventures at Hogwarts."
            },
            {
                id: 5,
                name: "Diary of a Wimpy Kid",
                author: "Jeff Kinney",
                category: "Children's Fiction",
                description: "A humorous story about the struggles of middle school life."
            },
            {
                id: 6,
                name: "Crime and Punishment",
                author: "Fyodor Dostoevsky",
                category: "Classic",
                description: "A psychological novel about guilt and redemption."
            },
            {
                id: 7,
                name: "Dune",
                author: "Frank Herbert",
                category: "Science Fiction",
                description: "An epic science fiction novel set in a distant future."
            },
            {
                id: 8,
                name: "Good Girl's Guide to Murder",
                author: "Holly Jackson",
                category: "Mystery",
                description: "A thrilling mystery about a girl investigating a murder."
            },
            {
                id: 9,
                name: "Sherlock Holmes",
                author: "Arthur Conan Doyle",
                category: "Mystery",
                description: "A collection of detective stories featuring the brilliant Sherlock Holmes."
            },
            {
                id: 10,
                name: "The Great Gatsby",
                author: "F. Scott Fitzgerald",
                category: "Classic",
                description: "A tale of decadence and idealism in the Jazz Age."
            }
        ];


        if (!localStorage.getItem("books")) {
            localStorage.setItem("books", JSON.stringify(books));
        }

        function renderBooks() {
            const tbody = document.getElementById("book-table-body");
            tbody.innerHTML = ""; 

            books.forEach(book => {
                const row = document.createElement("tr");
                row.innerHTML = `
                    <td>${book.id}</td>
                    <td>${book.name}</td>
                    <td>${book.author}</td>
                    <td>${book.category}</td>
                    <td>${book.description}</td>
                    <td class="action-buttons">
                        <button onclick="editBook(${book.id})">Edit</button>
                        <button onclick="deleteBook(${book.id})">Delete</button>
                    </td>
                `;
                tbody.appendChild(row);
            });
        }

        function editBook(bookId) {
            const book = books.find(b => b.id === bookId);
            if (!book) return;

            const newName = prompt("Enter new book name:", book.name);
            const newAuthor = prompt("Enter new author:", book.author);
            const newCategory = prompt("Enter new category:", book.category);
            const newDescription = prompt("Enter new description:", book.description);

            if (newName && newAuthor && newCategory && newDescription) {
                book.name = newName;
                book.author = newAuthor;
                book.category = newCategory;
                book.description = newDescription;

                
                localStorage.setItem("books", JSON.stringify(books));
                renderBooks(); 
            }
        }

        function deleteBook(bookId) {
            if (confirm("Are you sure you want to delete this book?")) {
                books = books.filter(b => b.id !== bookId);

                
                localStorage.setItem("books", JSON.stringify(books));
                renderBooks();
            }
        }


        renderBooks();
