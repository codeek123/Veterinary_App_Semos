// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
    let cards = document.querySelectorAll(".service-card");
    cards.forEach(card => {
        card.addEventListener("mouseenter", () => {
            card.classList.add("shadow-lg");
        });
        card.addEventListener("mouseleave", () => {
            card.classList.remove("shadow-lg");
        });
    });
});


document.addEventListener("DOMContentLoaded", function () {
    let slides = document.querySelectorAll('.slide');
    let index = 0;

    function changeSlide() {
        slides.forEach((slide, i) => {
            slide.classList.remove("active");
        });

        slides[index].classList.add("active");
        index = (index + 1) % slides.length; 
    }

    setInterval(changeSlide, 3000); 
});

document.addEventListener("DOMContentLoaded", function () {
    let currentIndex = 0;
    const slides = document.querySelectorAll(".feedback-slide");

    function showSlide(index) {
        slides.forEach((slide, i) => {
            slide.classList.remove("active");
            if (i === index) {
                slide.classList.add("active");
            }
        });
    }

    function nextSlide() {
        currentIndex = (currentIndex + 1) % slides.length;
        showSlide(currentIndex);
    }

    function prevSlide() {
        currentIndex = (currentIndex - 1 + slides.length) % slides.length;
        showSlide(currentIndex);
    }

    document.querySelector(".prev-btn").addEventListener("click", prevSlide);
    document.querySelector(".next-btn").addEventListener("click", nextSlide);

    showSlide(currentIndex); 
});
