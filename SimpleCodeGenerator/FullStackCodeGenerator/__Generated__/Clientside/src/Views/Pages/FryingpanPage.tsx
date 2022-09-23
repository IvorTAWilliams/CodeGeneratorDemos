import React, { useState } from 'react'
import { useCreate, useDelete, useRead } from '../../Hooks/CrudHooks'
import { Fryingpan } from '../../Models/Fryingpan'
import FryingpanAttributes from '../Components/FryingpanAttributes'

const FryingpanPage = () => {
  const { data, refetchFn } = useRead('Fryingpan');
  const [model, setModel] = useState<Fryingpan>({});
  const createFn = useCreate('Fryingpan');
  const deleteFn = useDelete('Fryingpan');

  const onCreateModel = () => {
    createFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  const onDeleteModel = (model: Fryingpan) => {
    deleteFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  return (
    <div>
      <div>
        <h2>Create a Fryingpan</h2>
        <FryingpanAttributes model={model} onChange={(updatedModel) => setModel(updatedModel)} />
        <button onClick={onCreateModel}>Create</button>
      </div>
      <div>
        <h2>All Fryingpans</h2>
        {
          data?.map(x =>
            <>
              <FryingpanAttributes key={x.Id} model={x} readonly />
              <button onClick={() => onDeleteModel(x)}>Delete</button>
            </>
          )
        }
      </div>
    </div>
  )
}
export default FryingpanPage


