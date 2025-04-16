// src/App.jshttp://localhost:3000/
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/NavBar'; // Import the Navbar component
import Home from './Pages/Home'; // Import the Home page
import Login from './Pages/Login';
import Register from './Pages/Register';

function App() {
  return (
    <Router>
      {/* Include the Navbar at the top of the app */}
      <Navbar />

      {/* Define routes for each page */}
      <Routes>
        {/* Route for the Home page */}
        <Route path="/" element={<Home />} />
        <Route path="/Login" element={<Login />} />
        <Route path="/Register" element={<Register />} />
      </Routes>
    </Router>
  );
}

export default App;