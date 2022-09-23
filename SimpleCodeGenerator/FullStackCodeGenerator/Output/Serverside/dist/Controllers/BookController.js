"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BookController = void 0;
const StorageProvider_1 = require("./../Services/StorageProvider");
const common_1 = require("@nestjs/common");
const Book_1 = require("../Models/Book");
let BookController = class BookController {
    constructor(storageProvider) {
        this.storageProvider = storageProvider;
    }
    create(entity) {
        return this.storageProvider.Create(entity, 'Book');
    }
    read() {
        return this.storageProvider.Read('Book');
    }
    update(entity) {
        return this.storageProvider.Update(entity, 'Book');
    }
    delete(entity) {
        return this.storageProvider.Delete(entity, 'Book');
    }
};
__decorate([
    (0, common_1.Post)('create'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Book_1.Book]),
    __metadata("design:returntype", Book_1.Book)
], BookController.prototype, "create", null);
__decorate([
    (0, common_1.Get)('read'),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", []),
    __metadata("design:returntype", Array)
], BookController.prototype, "read", null);
__decorate([
    (0, common_1.Post)('update'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Book_1.Book]),
    __metadata("design:returntype", Book_1.Book)
], BookController.prototype, "update", null);
__decorate([
    (0, common_1.Post)('delete'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Book_1.Book]),
    __metadata("design:returntype", Book_1.Book)
], BookController.prototype, "delete", null);
BookController = __decorate([
    (0, common_1.Controller)('Book'),
    __metadata("design:paramtypes", [StorageProvider_1.StorageProvider])
], BookController);
exports.BookController = BookController;
//# sourceMappingURL=BookController.js.map