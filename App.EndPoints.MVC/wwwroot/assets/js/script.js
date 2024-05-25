let menu = document.querySelector("#menu-bar");
let navbar = document.querySelector(".navbar");

window.onscroll = () => {
  menu.classList.remove("fa-times");
  navbar.classList.remove("active");
};

menu.addEventListener("click", () => {
  menu.classList.toggle("fa-times");
  navbar.classList.toggle("active");
});

// DarkBtn
var toggle = true;
function toggleColor() {
  var icon = document.getElementById("darkbtnIcon");
  var body = document.body;
  if (toggle) {
    body.style.backgroundColor = "#fff";
    body.style.color = "#000";
    icon.style.color = "#1b2e97";
    toggle = false;
  } else {
    body.style.backgroundColor = "#1d2733";
    body.style.color = "#fff";
    icon.style.color = "#fcf405";
    toggle = true;
  }
  icon.classList.toggle("fa-moon");
}

//Swiper
var swiper = new Swiper(".mySwiper", {
  slidesPerView: 1,
  spaceBetween: 30,
  loop: true,
  autoplay: {
    delay: 2500,
    disableOnInteraction: false,
  },
  breakpoints: {
    640: {
      slidesPerView: 2,
      spaceBetween: 20,
    },
    768: {
      slidesPerView: 2,
      spaceBetween: 40,
    },
    1024: {
      slidesPerView: 3,
      spaceBetween: 50,
    },
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});
