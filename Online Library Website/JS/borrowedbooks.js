const borrowedBooks = JSON.parse(localStorage.getItem("borrowedBooks")) || [];
const bookList = document.getElementById("borrowed-books");
const unborrowSelect = document.getElementById("unborrow-select");
const unborrowButton = document.getElementById("unborrow-button");

function renderBooks() {
    bookList.innerHTML = "";
    unborrowSelect.innerHTML = "";

    borrowedBooks.forEach((book, index) => {
        const bookItem = document.createElement("div");
        bookItem.className = "book-card";
        bookItem.innerHTML = `
            <img src="images/img${book.id}.jpg" alt="Book Cover">
            <div class="book-name">${book.name}</div>
            <div class="book-author">by ${book.author}</div>
        `;
        bookList.appendChild(bookItem);

        const option = document.createElement("option");
        option.value = index;
        option.textContent = book.name;
        unborrowSelect.appendChild(option);
    });
}


unborrowButton.addEventListener("click", () => {
    const selectedIndex = unborrowSelect.value;
    if (selectedIndex !== "") {
        const selectedBook = borrowedBooks[selectedIndex];

        
        resetSpecificBookAvailability(selectedBook.id);

        
        borrowedBooks.splice(selectedIndex, 1);
        localStorage.setItem("borrowedBooks", JSON.stringify(borrowedBooks));
        renderBooks();
    }
});


function resetSpecificBookAvailability(bookId) {
    let borrowedBooks = JSON.parse(localStorage.getItem("borrowedBooks")) || [];
    let bookAvailability = JSON.parse(localStorage.getItem("bookAvailability")) || {};

    
    const bookToReset = borrowedBooks.find(book => book.id === bookId);

    if (bookToReset) {
        
        bookAvailability[bookId] = true;

        
        localStorage.setItem("borrowedBooks", JSON.stringify(borrowedBooks));
        localStorage.setItem("bookAvailability", JSON.stringify(bookAvailability));

        
        const rows = document.querySelectorAll("tbody tr");
        const bookRow = rows[bookId - 1];
        if (bookRow) {
            const availabilityCell = bookRow.querySelector(".available, .not-available");
            const borrowButton = bookRow.querySelector(".borrow-button");

            availabilityCell.textContent = "Available";
            availabilityCell.classList.remove("not-available");
            availabilityCell.classList.add("available");
            borrowButton.disabled = false;
        }

        alert(`Book "${bookToReset.name}" has been returned and is now available.`);
    } else {
        alert("The specified book was not found.");
    }
}

renderBooks();
