import { BaseEntity } from 'src/Models/BaseEntity';
export declare class StorageProvider {
    private InMemoryStorage;
    Create<T extends BaseEntity>(model: T, modelName: string): T;
    Read<T extends BaseEntity>(modelName: string): Array<T>;
    Update<T extends BaseEntity>(model: T, modelName: string): T;
    Delete<T extends BaseEntity>(model: T, modelName: string): T;
}
