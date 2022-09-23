import { BookController } from './Controllers/BookController';
import { PageController } from './Controllers/PageController';
import { OrderController } from './Controllers/OrderController';
import { Module } from '@nestjs/common';
import { StorageProvider } from './Services/StorageProvider';

@Module({
  imports: [],
  controllers: [
    BookController,
    PageController,
    OrderController,
  ],
  providers: [StorageProvider],
})
export class AppModule {}

