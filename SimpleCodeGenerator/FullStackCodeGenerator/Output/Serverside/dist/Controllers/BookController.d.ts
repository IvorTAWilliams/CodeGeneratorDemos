import { StorageProvider } from './../Services/StorageProvider';
import { Book } from 'src/Models/Book';
export declare class BookController {
    private readonly storageProvider;
    constructor(storageProvider: StorageProvider);
    create(entity: Book): Book;
    read(): Array<Book>;
    update(entity: Book): Book;
    delete(entity: Book): Book;
}
