const menu = document.getElementById('menu');

menu.onclick = function myFunction() {

    const x = document.getElementById("myTopnav");

    if (x.className === "topnav"){
        x.className += " responsive";
    }
    else{
        x.className = "topnav";
    }
}

const form = document.querySelector('.form');

const email = document.getElementById('email');
const emailError = document.getElementById('emailError');
const name = document.getElementById('name');
const nameError = document.getElementById('nameError');
const text = document.getElementById('comment');
const textError = document.getElementById('textError');

function showError(){
    if (email.validity.valueMissing){
        emailError.textContent = 'Поле с Email адресом не может быть пустым.';
    }
    else if (email.validity.typeMismatch){
        emailError.textContent = 'Неверный формат Email адреса.';
    }
    else if (email.validity.tooShort){
        emailError.textContent = `Email адрес должен состоять как минимум из ${ email.minLength } символов.`;
    }

    if (name.validity.valueMissing){
        nameError.textContent = 'Поле с именем не может быть пустым.';
    }
    else if (name.validity.tooShort){
        nameError.textContent = `Имя должно состоять как минимум из ${ name.minLength } символов.`;
    }

    if (text.validity.valueMissing){
        textError.textContent = 'Поле с сообщением не может быть пустым.';
    }
    else if (text.validity.tooShort){
        textError.textContent = `Сообщение должно состоять как минимум из ${ text.minLength } символов.`
    }
}

email.addEventListener('input', function (event){
    if (email.validity.valid){
        emailError.textContent = '';
    }
    else{
        showError();
    }
});

name.addEventListener('input', function (event){
    if (name.validity.valid){
        nameError.textContent = '';
    }
    else{
        showError();
    }
});

text.addEventListener('input', function (event){
    if (text.validity.valid){
        textError.textContent = '';
    }
    else{
        showError();
    }
})

form.addEventListener('submit', function (event){
    if (!email.validity.valid && !name.validity.valid && !text.validity.valid) {
        showError();
        event.preventDefault();
    }
});
