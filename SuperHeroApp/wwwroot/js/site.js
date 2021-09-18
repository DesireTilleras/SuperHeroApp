// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var select = document.getElementById('SuperHeroName');
console.log(select);
select.addEventListener('change', function () {
    let value = select.options[select.selectedIndex].value;
    let herosss = document.getElementsByClassName("heros");
    for (var i = 0; i < herosss.length; i++) {
        herosss[i].style.display = 'none';
    };
    let heros = document.getElementById(value)
    heros.style.display ="block"

});

