import { BookController } from './Controllers/BookController';
import { Module } from '@nestjs/common';
import { StorageProvider } from './Services/StorageProvider';

@Module({
  imports: [],
  controllers: [BookController],
  providers: [StorageProvider],
})
export class AppModule {}

