﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Navbar Drop Dopwn Trigger
$(".dropdown-trigger").dropdown();

// Dark Mode Icon Toggle
$('.dark-toggle').on('click', function () {
	if ($(this).find('i').text() == 'brightness_4') {
		$(this).find('i').text('brightness_high');
	} else {
		$(this).find('i').text('brightness_4');
	}
});

// Dark Mode Function
function DarkMode() {
	var element = document.body;
	element.classList.toggle("dark-mode");
}

// Sidenav functionality
document.addEventListener('DOMContentLoaded', function () {
    const MainSidenav = document.querySelectorAll('.sidenav');
    const ProfileSidenav = document.getElementById('profile-sidenav')

    M.Sidenav.init(MainSidenav);
    M.Sidenav.init(ProfileSidenav, {'edge':'right'});

    const collapsible = document.querySelectorAll('.collapsible');
    M.Collapsible.init(collapsible);

    // Date Picker
    const date = document.querySelectorAll('.datepicker');
    M.Datepicker.init(date, {
        autoClose: true,
        format: 'mmmm dd, yyyy',
        disableWeekends: true
    });
});


//$(document).ready(function () {
//    $('.modal').modal();
//});


document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.modal');
    var instances = M.Modal.init(elems, options);
    instances.open();
});