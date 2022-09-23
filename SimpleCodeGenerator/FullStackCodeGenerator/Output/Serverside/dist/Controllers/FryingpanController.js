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
exports.FryingpanController = void 0;
const StorageProvider_1 = require("./../Services/StorageProvider");
const common_1 = require("@nestjs/common");
const Fryingpan_1 = require("../Models/Fryingpan");
let FryingpanController = class FryingpanController {
    constructor(storageProvider) {
        this.storageProvider = storageProvider;
    }
    create(entity) {
        return this.storageProvider.Create(entity, 'Fryingpan');
    }
    read() {
        return this.storageProvider.Read('Fryingpan');
    }
    update(entity) {
        return this.storageProvider.Update(entity, 'Fryingpan');
    }
    delete(entity) {
        return this.storageProvider.Delete(entity, 'Fryingpan');
    }
};
__decorate([
    (0, common_1.Post)('create'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Fryingpan_1.Fryingpan]),
    __metadata("design:returntype", Fryingpan_1.Fryingpan)
], FryingpanController.prototype, "create", null);
__decorate([
    (0, common_1.Get)('read'),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", []),
    __metadata("design:returntype", Array)
], FryingpanController.prototype, "read", null);
__decorate([
    (0, common_1.Post)('update'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Fryingpan_1.Fryingpan]),
    __metadata("design:returntype", Fryingpan_1.Fryingpan)
], FryingpanController.prototype, "update", null);
__decorate([
    (0, common_1.Post)('delete'),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Fryingpan_1.Fryingpan]),
    __metadata("design:returntype", Fryingpan_1.Fryingpan)
], FryingpanController.prototype, "delete", null);
FryingpanController = __decorate([
    (0, common_1.Controller)('Fryingpan'),
    __metadata("design:paramtypes", [StorageProvider_1.StorageProvider])
], FryingpanController);
exports.FryingpanController = FryingpanController;
//# sourceMappingURL=FryingpanController.js.map