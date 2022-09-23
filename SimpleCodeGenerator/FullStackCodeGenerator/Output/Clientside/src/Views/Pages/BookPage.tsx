import React, { useState } from 'react'
import { useCreate, useDelete, useRead } from '../../Hooks/CrudHooks'
import { Book } from '../../Models/Book'
import BookAttributes from '../Components/BookAttributes'

const BookPage = () => {
  const { data, refetchFn } = useRead('Book');
  const [model, setModel] = useState<Book>({});
  const createFn = useCreate('Book');
  const deleteFn = useDelete('Book');

  const onCreateModel = () => {
    createFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  const onDeleteModel = (model: Book) => {
    deleteFn(model)
      .then(() => {
        setModel({});
        refetchFn();
      });
  }

  return (
    <div>
      <div>
        <h2>Create a Book</h2>
        <BookAttributes model={model} onChange={(updatedModel) => setModel(updatedModel)} />
        <button onClick={onCreateModel}>Create</button>
      </div>
      <div>
        <h2>All Books</h2>
        {
          data?.map(x =>
            <>
              <BookAttributes key={x.Id} model={x} readonly />
              <button onClick={() => onDeleteModel(x)}>Delete</button>
            </>
          )
        }
      </div>
    </div>
  )
}
export default BookPage


