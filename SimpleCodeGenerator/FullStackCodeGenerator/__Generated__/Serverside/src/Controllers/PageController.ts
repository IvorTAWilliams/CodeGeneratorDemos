import { StorageProvider } from './../Services/StorageProvider';
import { Body, Controller, Get, Post } from '@nestjs/common';
import { Page } from 'src/Models/Page';

@Controller('Page')
export class PageController {
  constructor(private readonly storageProvider: StorageProvider) {}

  @Post('create')
  create(@Body() entity: Page): Page {
    return this.storageProvider.Create(entity, 'Page');
  }

  @Get('read')
  read(): Array<Page> {
    return this.storageProvider.Read('Page');
  }

  @Post('update')
  update(@Body() entity: Page): Page {
    return this.storageProvider.Update(entity, 'Page');
  }

  @Post('delete')
  delete(@Body() entity: Page): Page {
    return this.storageProvider.Delete(entity, 'Page');
  }
}

