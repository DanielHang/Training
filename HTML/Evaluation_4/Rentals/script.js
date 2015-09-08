// JavaScript source code
$(document).ready(function(){

	imgGrowing = false; // Image is busy Growing flag
	imgShrinking = false; // Image is busy Shrinking flag

	// Grow images
	$('.item-image').mouseover(function () {  //Mouseo has entered the regular image
		console.log("###  mouseOVER  ###");
		if (!imgGrowing) { //If image is not currently growning DO:
			imgGrowing = true; //Set CURRENTLY growing flag
			var $this = $(this);
			var $itemImageGrow = $("#item-image-grow");
			$itemImageGrow.animate().stop(); //Stop currently running image animations
			$itemImageGrow.hide(); //Hide currently running grown images
			var originalHeight = $this.height(); //Get original Image height
			var originalWidth = $this.width(); //Get original Image width
			var pos = $this.offset(); // returns an object with the attribute top and left		
			var imgTop = pos.top - (originalHeight * 0.05); // top offset position by 5%
			var imgLeft = pos.left - (originalWidth * 0.05); // left offset position by 5%*/
			var imgWidth = originalWidth * 1.1; // 10% increase in height
			var imgHeight = originalHeight * 1.1; // 10% increase in width
			var imgSrc = $this.attr("src"); // Get image url
			//Set positioning values for new image
			$itemImageGrow.attr("src", imgSrc);
			$itemImageGrow.css("width", originalWidth);
			$itemImageGrow.css("height", originalHeight);
			$itemImageGrow.css(pos);
			$itemImageGrow.show();
			$itemImageGrow.animate({ left: imgLeft, top: imgTop, width: imgWidth, height: imgHeight }, 500);
			$itemImageGrow.promise().done(function () {
				imgGrowing = false;
			});
		}
		else {
			console.log("***ALREADY GROWNING***");
		}
		console.log("GROW   : imgGrowing: " + imgGrowing + ", imgShrinking: " + imgShrinking);
	});

	// close streched image
	$('#item-image-grow').mouseout(function () {  //mouse has exited streched image
		console.log("###  mouseOUT  R###");
		if (imgGrowing) //If image is still growing DO:
		{
			$(this).hide(); //Hide currently running grown images
			$(this).animate().stop(); //Stop currently running image animations
			imgShrinking = false; //Remove Image shrinking flag
			console.log("***  CURRENTLY GROWNING - FAST SHRINK ***");
		}
		else if (imgShrinking) {
			console.log("***  ALREADY SHRINKING - FAST SHRINK ***");
			$(this).hide(); //Hide currently running grown images
			$(this).animate().stop(); //Stop currently running image animations
			imgShrinking = false; //Remove Image shrinking flag
		}
		else if (!imgShrinking) {
			imgShrinking = true; //Set Image shrinking flag
			var $this = $(this);
			var pos = $this.offset(); // returns an object with the attribute top and left		
			var imgWidth = $this.width() / 1.1; // 10% decrease in height
			var imgHeight = $this.height() / 1.1; // 10% decrease in width
			var imgTop = pos.top + (imgHeight * 0.05); // top offset position by 5%
			var imgLeft = pos.left + (imgWidth * 0.05); // left offset position by 5%
			$this.animate({ left: imgLeft, top: imgTop, width: imgWidth, height: imgHeight }, 500);
			$this.promise().done(function () {
				$this.hide(); //Hide currently running grown images
				imgShrinking = false; //Remove Image shrinking flag
			});
		}
		console.log("SHRINK : imgGrowing: " + imgGrowing + ", imgShrinking: " + imgShrinking);
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
		$("#moreinfo-container").hide();
		$('#moreinfo-container').empty();
		$("#background-moreinfo").hide();
		$('#background-moreinfo').empty();
	}
	
	// Taken more Info add
	$('#Taken-info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo-container').css({ 'top': e.pageY+50 });
		var dvd_info = getDVDs("Taken");
		$("#background-moreinfo").show();
		$("#moreinfo-container").fadeIn("slow");
		$("#moreinfo-container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// Terminator more Info add
	$('#Terminator-info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo-container').css({ 'top': e.pageY + 50 });
		var dvd_info = getDVDs("Terminator");
		$("#background-moreinfo").show();
		$("#moreinfo-container").fadeIn("slow");
		$("#moreinfo-container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// DieHard more Info add
	$('#DieHard-info').click(function () {
		var e = e || window.event;
		clearMoreInfo();
		$('#moreinfo-container').css({ 'top': e.pageY + 50 });
		var dvd_info = getDVDs("Die Hard"); 
		$("#background-moreinfo").show();
		$("#moreinfo-container").fadeIn("slow");
		$("#moreinfo-container").append("Director: " + dvd_info["0"].Director);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Stars: " + dvd_info["0"].Stars);
		$("#moreinfo-container").append("<Br/>");
		$("#moreinfo-container").append("Age Restriction: " + dvd_info["0"].AgeRestriction);
	});

	// More Info remove
	$('#background-moreinfo').click(function () {
		clearMoreInfo();
	});
});