const books = [
    { id: 1, name: "How to Win Friends and Influence People", author: "Dale Carnegie", image: "images/img1.jpg" },
    { id: 2, name: "The Psychology of Money", author: "Morgan Housel", image: "images/img2.jpg" },
    { id: 3, name: "The Power Of Now", author: "Eckhart Tolle", image: "images/img3.jpg" },
    { id: 4, name: "Coraline", author: "Neil Gaiman", image: "images/img4.jpg" },
    { id: 5, name: "Harry Potter", author: "J.K. Rowling", image: "images/img5.jpg" },
    { id: 6, name: "Diary of a Wimpy Kid 'The Getaway'", author: "Jeff Kinney", image: "images/img6.jpg" },
    { id: 7, name: "Crime and Punishment", author: "Fyodor Dostoevsky", image: "images/img7.jpg" },
    { id: 8, name: "Dune", author: "Frank Herbert", image: "images/img8.jpg" },
    { id: 9, name: "Good Girl's Guide to Murder", author: "Holly Jackson", image: "images/img9.jpg" },
    { id: 10, name: "Sherlock Holmes", author: "Arthur Conan Doyle", image: "images/img10.jpg" },
    { id: 11, name: "The Great Gatsby", author: "F. Scott Fitzgerald", image: "images/img11.jpg" },
    { id: 12, name: "Project Hail Mary", author: "Andy Weir", image: "images/img12.jpg" },
    { id: 13, name: "Harrow the Ninth", author: "Tamsyn Muir", image: "images/img13.jpg" },
    { id: 14, name: "Dead Silence", author: "S.A. Barnes", image: "images/img14.jpg" }
];

document.addEventListener('DOMContentLoaded', function() {
    const bookCards = document.querySelectorAll('.book-card');

    bookCards.forEach((card, index) => {
        card.addEventListener('click', function() {
            const bookId = index + 1;
            window.location.href = `bookdetails_admin.html?id=${bookId}`;
        });

        card.style.cursor = 'pointer';
    });
});