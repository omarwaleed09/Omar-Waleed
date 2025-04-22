document.getElementById("add-book-form").addEventListener("submit", function(event) {
    event.preventDefault();
    const bookName = document.getElementById("book-name").value;
    const author = document.getElementById("author").value;
    const category = document.getElementById("category").value;
    const description = document.getElementById("description").value;
    const books = JSON.parse(localStorage.getItem("books")) || [];
    const newId = books.length > 0 ? books[books.length - 1].id + 1 : 1;
    const newBook = {
        id: newId,
        name: bookName,
        author: author,
        category: category,
        description: description
    };
    books.push(newBook);
    localStorage.setItem("books", JSON.stringify(books));
    window.location.href = "viewbooksadmin.html";
});