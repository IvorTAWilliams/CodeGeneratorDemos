import React, { useState } from 'react'
import { useCreate, useDelete, useRead } from '../../Hooks/CrudHooks'
import { Page } from '../../Models/Page'
import PageAttributes from '../Components/PageAttributes'

const PagePage = () => {
  const { data, refetchFn } = useRead('Page');
  const [model, setModel] = useState<Page>({});
  const createFn = useCreate('Page');
  const deleteFn = useDelete('Page');

  const onCreateModel = () => {
    createFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  const onDeleteModel = (model: Page) => {
    deleteFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  return (
    <div>
      <div>
        <h2>Create a Page</h2>
        <PageAttributes model={model} onChange={(updatedModel) => setModel(updatedModel)} />
        <button onClick={onCreateModel}>Create</button>
      </div>
      <div>
        <h2>All Pages</h2>
        {
          data?.map(x =>
            <>
              <PageAttributes key={x.Id} model={x} readonly />
              <button onClick={() => onDeleteModel(x)}>Delete</button>
            </>
          )
        }
      </div>
    </div>
  )
}
export default PagePage


