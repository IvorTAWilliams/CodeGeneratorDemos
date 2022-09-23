import React from 'react'
import { Order } from '../../Models/Order';

interface OrderAttributesProps {
  model: Order;
  readonly?: boolean;
  onChange?: (model: Order) => void;
}

const OrderAttributes = (props: OrderAttributesProps) => (
  <div className='attributes'>
    <div className='attribute'>
      <span>BookId</span>
      <input
        disabled={props.readonly}
        value={props.model.BookId}
        onChange={x => props.onChange ? props.onChange({ ...props.model, BookId: x.target.value }) : null} />
    </div>
    <div className='attribute'>
      <span>Quantity</span>
      <input
        disabled={props.readonly}
        value={props.model.Quantity}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Quantity: x.target.value }) : null} />
    </div>
  </div>
)
export default OrderAttributes

