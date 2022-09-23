"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.StorageProvider = void 0;
const common_1 = require("@nestjs/common");
const uuid_1 = require("uuid");
let StorageProvider = class StorageProvider {
    constructor() {
        this.InMemoryStorage = {};
    }
    Create(model, modelName) {
        var _a;
        model.Id = (_a = model.Id) !== null && _a !== void 0 ? _a : (0, uuid_1.v4)();
        this.InMemoryStorage[modelName] = !this.InMemoryStorage[modelName] ? [model] : [...this.InMemoryStorage[modelName], model];
        return model;
    }
    Read(modelName) {
        return this.InMemoryStorage[modelName];
    }
    Update(model, modelName) {
        const index = this.InMemoryStorage[modelName].findIndex(x => x.Id === model.Id);
        this.InMemoryStorage[modelName][index] = model;
        return model;
    }
    Delete(model, modelName) {
        this.InMemoryStorage[modelName] = this.InMemoryStorage[modelName].filter(x => x.Id !== model.Id);
        return model;
    }
};
StorageProvider = __decorate([
    (0, common_1.Injectable)()
], StorageProvider);
exports.StorageProvider = StorageProvider;
//# sourceMappingURL=StorageProvider.js.map