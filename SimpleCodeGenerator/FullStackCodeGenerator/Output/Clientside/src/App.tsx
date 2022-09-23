import React from 'react';
import styled from 'styled-components'
import {
  BrowserRouter as Router,
  Route,
  Link,
  Routes
} from "react-router-dom";
import BookPage from './Views/Pages/BookPage';
import FryingpanPage from './Views/Pages/FryingpanPage';

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
`

function App() {
  return (
    <AppWrapper>
      <Router>
        <div className='nav'>
          <Link to="Book">Book</Link>
          <Link to="Fryingpan">Fryingpan</Link>
        </div>
        <div className='body'>
          <Routes>
            <Route path="/Book" element={<BookPage />} />
            <Route path="/Fryingpan" element={<FryingpanPage />} />
          </Routes>
        </div>
      </Router>
    </AppWrapper>
  );
}

export default App;

