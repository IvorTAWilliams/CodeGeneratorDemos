import { StorageProvider } from './../Services/StorageProvider';
import { Fryingpan } from 'src/Models/Fryingpan';
export declare class FryingpanController {
    private readonly storageProvider;
    constructor(storageProvider: StorageProvider);
    create(entity: Fryingpan): Fryingpan;
    read(): Array<Fryingpan>;
    update(entity: Fryingpan): Fryingpan;
    delete(entity: Fryingpan): Fryingpan;
}
