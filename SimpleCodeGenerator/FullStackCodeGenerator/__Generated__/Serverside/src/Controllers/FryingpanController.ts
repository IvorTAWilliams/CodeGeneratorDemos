import { StorageProvider } from './../Services/StorageProvider';
import { Body, Controller, Get, Post } from '@nestjs/common';
import { Fryingpan } from 'src/Models/Fryingpan';

@Controller('Fryingpan')
export class FryingpanController {
  constructor(private readonly storageProvider: StorageProvider) {}

  @Post('create')
  create(@Body() entity: Fryingpan): Fryingpan {
    return this.storageProvider.Create(entity, 'Fryingpan');
  }

  @Get('read')
  read(): Array<Fryingpan> {
    return this.storageProvider.Read('Fryingpan');
  }

  @Post('update')
  update(@Body() entity: Fryingpan): Fryingpan {
    return this.storageProvider.Update(entity, 'Fryingpan');
  }

  @Post('delete')
  delete(@Body() entity: Fryingpan): Fryingpan {
    return this.storageProvider.Delete(entity, 'Fryingpan');
  }
}

