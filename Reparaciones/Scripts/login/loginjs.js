
const btnlogin = $('#btnlogin');
const correo = $('#correo');
const contrasena = $('#contrasena');

let url = 'https://localhost:44303/Home/Login';

btnlogin.click(function () {
    $.ajax({
        datatype: "json",
        type: "POST",
        url: url+'?correo='+correo.val()+'&contrasena='+contrasena.val(),     
        success: function (response) {
            window.location.href = "Home/inicio"
        },
        error: function () {
            
        }
    });
})

//login
