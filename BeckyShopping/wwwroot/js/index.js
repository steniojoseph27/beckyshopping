var x = 0;
var s = "";

console.log("Welcome to Becky Shopping");

var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    console.log("Buying item");
});

var productinfo = document.getElementsByClassName("product-props");
var listItems = productInfo.item[0].children;