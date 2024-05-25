// ( Show/Hide eye icon )
function eyeIconChange() {
  var passwordField = document.getElementById("password");
  var eyeIcon = document.getElementById("eyeIcon");
  if (passwordField.type === "password") {
    passwordField.type = "text";
  } else {
    passwordField.type = "password";
  }
  eyeIcon.classList.toggle("fa-eye-slash");
}
