// JavaScript source code
$(document).ready(function(){
	$('.category_container').mouseover(function () {
		$(this).css("background-color", "#d3d3d3");
		$(this).css("color", "#ffffff");
	});

	$('.category_container').mouseout(function () {
		$(this).css("background-color", "#ffffff");
		$(this).css("color", "#505050");
	});

	$('#catergory_action').click(function () {
		window.location = 'action.html';
	});

	$('#catergory_animation').click(function () {
		window.location = 'animation.html';
	});

	$('#catergory_comedy').click(function () {
		window.location = 'comedy.html';
	});

	$('#catergory_thriller').click(function () {
		window.location = 'thriller.html';
	});

	$('#catergory_drama').click(function () {
		window.location = 'drama.html';
	});

	$('#catergory_horror').click(function () {
		window.location = 'horror.html';
	});
});