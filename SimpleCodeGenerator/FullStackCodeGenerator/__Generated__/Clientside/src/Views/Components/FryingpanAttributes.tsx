import React from 'react'
import { Fryingpan } from '../../Models/Fryingpan';

interface FryingpanAttributesProps {
  model: Fryingpan;
  readonly?: boolean;
  onChange?: (model: Fryingpan) => void;
}

const FryingpanAttributes = (props: FryingpanAttributesProps) => (
  <div className='attributes'>
    <div className='attribute'>
      <span>Title</span>
      <input
        disabled={props.readonly}
        value={props.model.Title}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Title: x.target.value }) : null} />
    </div>
    <div className='attribute'>
      <span>Eggman</span>
      <input
        disabled={props.readonly}
        value={props.model.Eggman}
        onChange={x => props.onChange ? props.onChange({ ...props.model, Eggman: x.target.value }) : null} />
    </div>
  </div>
)
export default FryingpanAttributes

