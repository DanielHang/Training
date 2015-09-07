// JavaScript source code
$(document).ready(function(){
	// Main menu Buttons color change
	$('.category_container').mouseover(function () {
		$(this).css("background-color", "#d3d3d3");
		$(this).css("color", "#ffffff");
	});

	$('.category_container').mouseout(function () {
		$(this).css("background-color", "#ffffff");
		$(this).css("color", "#505050");
	});


	// Link Click to URLs
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



	// Grow images
	$('#item_image_grow').is(':hidden') &&	$('.item_image').mouseover(function () {
		var pos = $(this).position(); // returns an object with the attribute top and left
		var html_width = $(document).width();
		if (html_width > 1200) { //take max body size into consideration
			pos.left = pos.left - ((html_width - 1200)/ 2);
		}
		
		var img_height = 317; // 10% increase in height
		var img_width = 214; // 10% increase in width
		pos.top = pos.top - (img_height * 0.05); // top offset position by 5%
		pos.left = pos.left - (img_width * 0.05); // left offset position by 5%
		img_height = img_height * 1.1; // 10% increase in height
		img_width = img_width * 1.1; // 10% increase in width
		var img_src = $(this).attr("src"); // Get image url
		
		//Set positioning values for new image
		$("#item_image_grow").attr("src", img_src);
		$("#item_image_grow").css("top", pos.top);
		$("#item_image_grow").css("left", pos.left);
		$("#item_image_grow").css("height", img_height);
		$("#item_image_grow").css("width", img_width);
		$("#item_image_grow").show();
	});


	// close streched image
	$('#item_image_grow').mouseout(function () {
		$("#item_image_grow").hide();
	});
	


	//Test JSON file read
	var JSON;

	$.getJSON('moreinfo.json', function (response) {JSON = response;})
	.error(function () { alert("error"); });

	// Get more info
	function getDVDs(dvd_title) {
		var rentals = _.select(JSON, function (dvd) { return dvd.Title == dvd_title; });
		return rentals;
	}

	// Clear more info box
	function clearMoreInfo() {
		$("#moreinfo_container").hide();
		$('#moreinfo_container').empty();
		$("#background_moreinfo").hide();
		$('#background_moreinfo').empty();
	}
	
	// Taken more Info add
	$('#Taken_info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo_container').css({ 'top': e.pageY+50 });
		var dvd_info = getDVDs("Taken");
		$("#background_moreinfo").show();
		$("#moreinfo_container").fadeIn("slow");
		$("#moreinfo_container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// Terminator more Info add
	$('#Terminator_info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo_container').css({ 'top': e.pageY + 50 });
		var dvd_info = getDVDs("Terminator");
		$("#background_moreinfo").show();
		$("#moreinfo_container").fadeIn("slow");
		$("#moreinfo_container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// DieHard more Info add
	$('#Die_Hard_info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo_container').css({ 'top': e.pageY + 50 });
		var dvd_info = getDVDs("Die Hard"); 
		$("#background_moreinfo").show();
		$("#moreinfo_container").fadeIn("slow");
		$("#moreinfo_container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo_container").append("<Br/>");
		$("#moreinfo_container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// More Info remove
	$('#background_moreinfo').click(function () {
		clearMoreInfo();
	});
});