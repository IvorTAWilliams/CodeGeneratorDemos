import React from 'react'
import { Book } from '../../Models/Book';

interface BookAttributesProps {
  model: Book;
  readonly?: boolean;
  onChange?: (model: Book) => void;
}

const BookAttributes = (props: BookAttributesProps) => (
  <div className='attributes'>
    <div className='attribute'>
      <span>Title</span>
      <input
        disabled={props.readonly}
        value={props.model.Title}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Title: x.target.value }) : null} />
    </div>
    <div className='attribute'>
      <span>Description</span>
      <input
        disabled={props.readonly}
        value={props.model.Description}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Description: x.target.value }) : null} />
    </div>
  </div>
)
export default BookAttributes

