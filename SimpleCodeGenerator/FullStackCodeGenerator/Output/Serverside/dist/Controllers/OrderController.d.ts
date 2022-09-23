import { StorageProvider } from './../Services/StorageProvider';
import { Order } from 'src/Models/Order';
export declare class OrderController {
    private readonly storageProvider;
    constructor(storageProvider: StorageProvider);
    create(entity: Order): Order;
    read(): Array<Order>;
    update(entity: Order): Order;
    delete(entity: Order): Order;
}
