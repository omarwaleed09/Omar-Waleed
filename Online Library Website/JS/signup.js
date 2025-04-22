function handleSignUp(event) {
    event.preventDefault();
    let pass = document.getElementById("password").value
    let confpass = document.getElementById("confirmpass").value
    
    if (confpass === pass)
    {
        let users = JSON.parse(localStorage.getItem('users')) || [];
        const form = document.querySelector('form');
        const formData = new FormData(form);
        const user = Object.fromEntries(formData);
        users.push(user);
        localStorage.setItem('users',JSON.stringify(users));
        
        window.location.href = 'login.html';
    }
    else
    {
        alert("Error: Password and Confirm Password don't match")
    }
}
const form = document.querySelector('form');
form.addEventListener('submit',handleSignUp);
