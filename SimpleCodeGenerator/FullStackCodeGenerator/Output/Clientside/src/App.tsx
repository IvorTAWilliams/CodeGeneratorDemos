import React from 'react';
import styled from 'styled-components'
import {
  BrowserRouter as Router,
  Route,
  Link,
  Routes
} from "react-router-dom";
import BookPage from './Views/Pages/BookPage';
import PagePage from './Views/Pages/PagePage';
import OrderPage from './Views/Pages/OrderPage';

const AppWrapper = styled.div`
font-family: sans-serif;
.nav {
  background: black;
  display: flex;
  padding: 1rem;
  a {
    color: white;
    margin: 0 2rem;
  }
}
.body {
  padding: 3rem;
}
.attributes {
  display: flex;
  flex-direction: column;
  width: 20rem;
  .attribute {
    display: flex;
    flex-direction: column;
    margin-bottom: 0.2rem;
  }
}
button {
  background: black;
  color: white;
}
input {
  height: 1.5rem;
}
`

function App() {
  return (
    <AppWrapper>
      <Router>
        <div className='nav'>
          <Link to="Book">Book</Link>
          <Link to="Page">Page</Link>
          <Link to="Order">Order</Link>
        </div>
        <div className='body'>
          <Routes>
            <Route path="/Book" element={<BookPage />} />
            <Route path="/Page" element={<PagePage />} />
            <Route path="/Order" element={<OrderPage />} />
          </Routes>
        </div>
      </Router>
    </AppWrapper>
  );
}

export default App;

