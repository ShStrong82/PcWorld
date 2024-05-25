// ( Show/Hide eye icon in password input)
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

// (Show/Hide eye icon in confirmPord input)
function eyeIconChange1() {
  var confirmPasswordField = document.getElementById("confirmPassword");
  var eyeIcon = document.getElementById("confirmPasseyeIcon");
  if (confirmPasswordField.type === "password") {
    confirmPasswordField.type = "text";
  } else {
    confirmPasswordField.type = "password";
  }
  eyeIcon.classList.toggle("fa-eye-slash");
}
