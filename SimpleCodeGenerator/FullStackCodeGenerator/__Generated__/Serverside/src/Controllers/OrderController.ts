import { StorageProvider } from './../Services/StorageProvider';
import { Body, Controller, Get, Post } from '@nestjs/common';
import { Order } from 'src/Models/Order';

@Controller('Order')
export class OrderController {
  constructor(private readonly storageProvider: StorageProvider) {}

  @Post('create')
  create(@Body() entity: Order): Order {
    return this.storageProvider.Create(entity, 'Order');
  }

  @Get('read')
  read(): Array<Order> {
    return this.storageProvider.Read('Order');
  }

  @Post('update')
  update(@Body() entity: Order): Order {
    return this.storageProvider.Update(entity, 'Order');
  }

  @Post('delete')
  delete(@Body() entity: Order): Order {
    return this.storageProvider.Delete(entity, 'Order');
  }
}

