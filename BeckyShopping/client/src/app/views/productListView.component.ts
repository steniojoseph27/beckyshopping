import { Component } from "@angular/core";

@Component({
    selector: "product-list",
    templateUrl: "productListView.component.html"
})
export default class ProductListView {
    public products = [{
        title: "Long sleeve women t-shirt",
        price: "29.99"
    }, {
        title: "Summer women dress",
        price: "39.50"
    }];
}