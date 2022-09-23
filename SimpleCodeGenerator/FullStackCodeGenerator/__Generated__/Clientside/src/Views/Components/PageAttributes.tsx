import React from 'react'
import { Page } from '../../Models/Page';

interface PageAttributesProps {
  model: Page;
  readonly?: boolean;
  onChange?: (model: Page) => void;
}

const PageAttributes = (props: PageAttributesProps) => (
  <div className='attributes'>
    <div className='attribute'>
      <span>BookId</span>
      <input
        disabled={props.readonly}
        value={props.model.BookId}
        onChange={x => props.onChange ? props.onChange({ ...props.model, BookId: x.target.value }) : null} />
    </div>
    <div className='attribute'>
      <span>Contents</span>
      <input
        disabled={props.readonly}
        value={props.model.Contents}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Contents: x.target.value }) : null} />
    </div>
    <div className='attribute'>
      <span>PageNumber</span>
      <input
        disabled={props.readonly}
        value={props.model.PageNumber}
        onChange={x => props.onChange ? props.onChange({ ...props.model, PageNumber: x.target.value }) : null} />
    </div>
  </div>
)
export default PageAttributes

