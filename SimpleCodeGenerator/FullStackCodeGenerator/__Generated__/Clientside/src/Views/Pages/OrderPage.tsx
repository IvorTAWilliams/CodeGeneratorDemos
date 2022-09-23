import React, { useState } from 'react'
import { useCreate, useDelete, useRead } from '../../Hooks/CrudHooks'
import { Order } from '../../Models/Order'
import OrderAttributes from '../Components/OrderAttributes'

const OrderPage = () => {
  const { data, refetchFn } = useRead('Order');
  const [model, setModel] = useState<Order>({});
  const createFn = useCreate('Order');
  const deleteFn = useDelete('Order');

  const onCreateModel = () => {
    createFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  const onDeleteModel = (model: Order) => {
    deleteFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  return (
    <div>
      <div>
        <h2>Create a Order</h2>
        <OrderAttributes model={model} onChange={(updatedModel) => setModel(updatedModel)} />
        <button onClick={onCreateModel}>Create</button>
      </div>
      <div>
        <h2>All Orders</h2>
        {
          data?.map(x =>
            <>
              <OrderAttributes key={x.Id} model={x} readonly />
              <button onClick={() => onDeleteModel(x)}>Delete</button>
            </>
          )
        }
      </div>
    </div>
  )
}
export default OrderPage


