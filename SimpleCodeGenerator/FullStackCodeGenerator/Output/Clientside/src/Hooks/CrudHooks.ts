import { BaseEntity } from "../Models/BaseEntity";
import axios from 'axios';
import { useEffect, useState } from "react";

const baseUrl = 'http://localhost:8080';

export function useCreate<T extends BaseEntity>(modelName: string) {
  return (model: T) => axios.post<T>(`${baseUrl}/${modelName}/create`, model)
    .then(resposnse => resposnse.data)
}

export function useRead<T extends BaseEntity>(modelName: string) {
  const [data, setData] = useState<Array<T>>([])
  useEffect(() => {
    refetchFn()
  })
  const refetchFn = () => {
    axios.get<Array<T>>(`${baseUrl}/${modelName}/read`)
      .then(resposnse => {setData(!resposnse.data ? [] : resposnse.data)})
  }
  return {data, refetchFn}
}

export function useUpdate<T extends BaseEntity>(modelName: string) {
  return (model: T) => axios.post<T>(`${baseUrl}/${modelName}/update`, model)
    .then(resposnse => resposnse.data)
}

export function useDelete<T extends BaseEntity>(modelName: string) {
  return (model: T) => axios.post<T>(`${baseUrl}/${modelName}/delete`, model)
    .then(resposnse => resposnse.data)
}

