$(document).ready(function () { 
    var x = 0;
    var s = "";

    console.log("Welcome to Becky Shopping");

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying item");
    });

    var productinfo = $(".product-props li");
    productinfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });


    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    })


});