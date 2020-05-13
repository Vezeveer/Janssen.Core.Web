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