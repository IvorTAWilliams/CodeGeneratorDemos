"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.AppModule = void 0;
const BookController_1 = require("./Controllers/BookController");
const PageController_1 = require("./Controllers/PageController");
const OrderController_1 = require("./Controllers/OrderController");
const common_1 = require("@nestjs/common");
const StorageProvider_1 = require("./Services/StorageProvider");
let AppModule = class AppModule {
};
AppModule = __decorate([
    (0, common_1.Module)({
        imports: [],
        controllers: [
            BookController_1.BookController,
            PageController_1.PageController,
            OrderController_1.OrderController,
        ],
        providers: [StorageProvider_1.StorageProvider],
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map