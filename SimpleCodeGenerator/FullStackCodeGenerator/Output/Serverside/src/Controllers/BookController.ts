import { StorageProvider } from './../Services/StorageProvider';
import { Body, Controller, Get, Post } from '@nestjs/common';
import { Book } from 'src/Models/Book';

@Controller('Book')
export class BookController {
  constructor(private readonly storageProvider: StorageProvider) {}

  @Post('create')
  create(@Body() entity: Book): Book {
    return this.storageProvider.Create(entity, 'Book');
  }

  @Get('read')
  read(): Array<Book> {
    return this.storageProvider.Read('Book');
  }

  @Post('update')
  update(@Body() entity: Book): Book {
    return this.storageProvider.Update(entity, 'Book');
  }

  @Post('delete')
  delete(@Body() entity: Book): Book {
    return this.storageProvider.Delete(entity, 'Book');
  }
}

