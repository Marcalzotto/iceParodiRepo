$(document).ready(function () {
    $("#btn_enviar").click(function (event) {

        event.preventDefault();
        var user;
        var password;

        user = $("#user_name").val();
        password = $("#pass_user").val();

        alert("El usuario es: " + user + "el password es: " + password);
    });
});