function borrowBook(bookId, bookName, author, category) {
    const rows = document.querySelectorAll("tbody tr");
    const bookRow = rows[bookId - 1];
    const availabilityCell = bookRow.querySelector(".available, .not-available");
    const borrowButton = bookRow.querySelector(".borrow-button");
    if (availabilityCell.classList.contains("available")) {
        availabilityCell.textContent = "Not Available";
        availabilityCell.classList.remove("available");
        availabilityCell.classList.add("not-available");
        borrowButton.disabled = true;
        const borrowedBooks = JSON.parse(localStorage.getItem("borrowedBooks")) || [];
        borrowedBooks.push({ id: bookId, name: bookName, author: author, category: category });
        localStorage.setItem("borrowedBooks", JSON.stringify(borrowedBooks));
        const bookAvailability = JSON.parse(localStorage.getItem("bookAvailability")) || {};
        bookAvailability[bookId] = false; // false means not available
        localStorage.setItem("bookAvailability", JSON.stringify(bookAvailability));
        alert(`Book "${bookName}" has been borrowed.`);
    } else {
        alert("This book is not available for borrowing.");
    }
}
function initializeBookAvailability() {
    const bookAvailability = JSON.parse(localStorage.getItem("bookAvailability")) || {};
    const rows = document.querySelectorAll("tbody tr");
    rows.forEach(row => {
        const bookId = parseInt(row.querySelector("td:first-child").textContent);; 
        const availabilityCell = row.querySelector(".available, .not-available");
        const borrowButton = row.querySelector(".borrow-button");
        if (bookAvailability[bookId] === false) {
            availabilityCell.textContent = "Not Available";
            availabilityCell.classList.remove("available");
            availabilityCell.classList.add("not-available");
            borrowButton.disabled = true;
        }
    });
}
function searchBooks() {
    const searchQuery = document.getElementById("search_query").value.toLowerCase();
    const rows = document.querySelectorAll("tbody tr");
    rows.forEach(row => {
        const bookName = row.querySelector("td:nth-child(2)").textContent.toLowerCase();
        const author = row.querySelector("td:nth-child(3)").textContent.toLowerCase();
        const category = row.querySelector("td:nth-child(4)").textContent.toLowerCase();
        if (bookName.includes(searchQuery) || author.includes(searchQuery) || category.includes(searchQuery)) {
            row.style.display = "";
        } else {
            row.style.display = "none";
        }
    });
}
document.querySelector(".search-form form").addEventListener("submit", function(event) {
    event.preventDefault();
    searchBooks();
});
window.addEventListener('DOMContentLoaded', initializeBookAvailability);
//button return optional
function resetBookAvailability() {
    localStorage.removeItem("borrowedBooks");
    localStorage.removeItem("bookAvailability");
    
    const rows = document.querySelectorAll("tbody tr");
    rows.forEach(row => {
        const availabilityCell = row.querySelector(".not-available, .available");
        const borrowButton = row.querySelector(".borrow-button");
    
        availabilityCell.textContent = "Available";
        availabilityCell.classList.remove("not-available");
        availabilityCell.classList.add("available");
        borrowButton.disabled = false;
    });

    alert("All books are now available.");
}