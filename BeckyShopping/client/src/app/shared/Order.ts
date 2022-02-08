export class OrderItem {
    id: number = 0;
    quantity: number = 0;
    unitPrice: number = 0;
    productId: number = 0;
    productCategory: string = "";
    productSize: string = "";
    productName: string = "";
    productImageId: string = "";
    supplierId: string = "";
}

export class Order {
    orderId: number | undefined;
    orderDate: Date = new Date();
    orderNumber: string | undefined;
    items: OrderItem[] = [];

    get subtotal(): number {
        const result = this.items.reduce(
            (total, val) => {
                return total + (val.unitPrice * val.quantity);
        }, 0);

        return result;
    }
}
