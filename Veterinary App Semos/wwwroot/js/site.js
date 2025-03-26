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
    let textContainer = document.querySelector('.image-text');
    let index = 0;

    const slideData = [
        {
            text: '<h1>Best help for <br><span>your best friends</span></h1>',
            positionClass: 'slide-position1'
        },
        {
            text: '<h1>Caring for <br><span>every pet</span></h1>',
            positionClass: 'slide-position2'
        },
        {
            text: '<h1>Dedicated to the health and<br><span> happiness of your pets.</span></h1>',
            positionClass: 'slide-position3'
        }
    ];

    slides[index].classList.add("active");
    textContainer.innerHTML = slideData[index].text;
    textContainer.classList.add(slideData[index].positionClass, "active");

    setInterval(changeSlide, 3000);

    function changeSlide() {
        slides[index].classList.remove("active");
        textContainer.classList.remove("active");

        index = (index + 1) % slides.length;

        textContainer.innerHTML = slideData[index].text;
        textContainer.classList.remove("slide-position1", "slide-position2", "slide-position3");
        textContainer.classList.add(slideData[index].positionClass);

        requestAnimationFrame(() => {
            slides[index].classList.add("active");
            textContainer.classList.add("active");
        });
    }
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
