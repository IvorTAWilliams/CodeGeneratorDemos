import { StorageProvider } from './../Services/StorageProvider';
import { Page } from 'src/Models/Page';
export declare class PageController {
    private readonly storageProvider;
    constructor(storageProvider: StorageProvider);
    create(entity: Page): Page;
    read(): Array<Page>;
    update(entity: Page): Page;
    delete(entity: Page): Page;
}
