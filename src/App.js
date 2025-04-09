// src/App.js
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/NavBar'; // Import the Navbar component
import Home from './Pages/Home'; // Import the Home page

function App() {
  return (
    <Router>
      {/* Include the Navbar at the top of the app */}
      <Navbar />

      {/* Define routes for each page */}
      <Routes>
        {/* Route for the Home page */}
        <Route path="/" element={<Home />} />
      </Routes>
    </Router>
  );
}

export default App;