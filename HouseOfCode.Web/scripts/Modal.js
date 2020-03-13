$(document).ready(function () {

    $("#myModal").on("shown.bs.modal", function () {
        $("#email").trigger("focus");
    });

    $("#myModal").on("hidden.bs.modal", function (e) {
        $("#forgotPasswordModalHeader").hide();
        $("#forgotPasswordModal").hide();
        $("#signUpModalHeader").hide();
        $("#signUpModal").hide();
        $("#signInModalHeader").show();
        $("#signInModal").show();
    });

    $("#btnForgotPassword").click(function () {
        $("#signInModalHeader").hide();
        $("#signInModal").hide();
        $("#signUpModalHeader").hide();
        $("#signUpModal").hide();
        $("#forgotPasswordModalHeader").show();
        $("#forgotPasswordModal").show();
    });

    $("#btnSignUp").click(function () {
        $("#signInModalHeader").hide();
        $("#signInModal").hide();
        $("#forgotPasswordModalHeader").hide();
        $("#forgotPasswordModal").hide();
        $("#signUpModalHeader").show();
        $("#signUpModal").show();
    });
});

