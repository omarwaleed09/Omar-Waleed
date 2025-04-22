function handleLogin(event) {
    event.preventDefault();
    const json = localStorage.getItem('users');
    const users = JSON.parse(json) || [];


    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;

    const userExists = users.find(user => user.username === username && user.password === password);

    if(userExists)
    {

        window.location.href = userExists.role + 'home.html';
    }
    else
    {
        alert("Incorrect username or password. Please Try again")
    }

    const form = document.querySelector('form');
    form.addEventListener('submit', handleLogin);
}
