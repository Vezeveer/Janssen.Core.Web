// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggleRequirements() {
    var x = document.getElementById("requirements");

    //FOR Toggling visibility
    //if (x.style.display === "block") {
    //    x.style.display = "none";
    //} else {
    //    x.style.display = "block";
    //    x.scrollIntoView({ behavior: 'smooth' });
    //}

    x.style.display = "block";
    x.scrollIntoView({ behavior: 'smooth' });

}

function disableScrolling() {
    var x = window.scrollX;
    var y = window.scrollY;
    window.onscroll = function () { window.scrollTo(x, y); };
}

function enableScrolling() {
    window.onscroll = function () { };
}

disableScrolling();

// Image switch logic
let tick = 0;
switchImages();
window.setInterval(function () {
    switchImages();

}, 15000);

function switchImages() {
    setTimeout(function () { $("#gym-pic2").fadeIn(); }, 5000);
    setTimeout(function () { $("#gym-pic2").fadeOut() }, 10000);
    setTimeout(function () { $("#gym-pic3").fadeIn() }, 10000);
    setTimeout(function () { $("#gym-pic3").fadeOut() }, 15000);
}
