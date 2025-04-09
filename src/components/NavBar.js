// src/components/Navbar.js
import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSearch, faShoppingCart } from '@fortawesome/free-solid-svg-icons';

const Navbar = () => {
  const [query, setQuery] = useState('');
  const navigate = useNavigate();

  const handleSearch = (e) => {
    e.preventDefault();
    if (query.trim()) {
      navigate(`/products?search=${encodeURIComponent(query)}`);
    }
  };

  return (
    <nav className="navbar navbar-expand-lg navbar-light shadow-sm">
      <div className="container-fluid">
        {/* Brand/Logo */}
        <Link to="/" className="navbar-brand fw-bold fs-4 px-3">Online Store</Link>

        {/* Toggle Button for Small Screens */}
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>

        {/* Navbar Content */}
        <div className="collapse navbar-collapse" id="navbarNav">
          {/* Centered Search Bar */}
          <form className="d-flex mx-auto my-2 my-lg-0" onSubmit={handleSearch}>
            <input
              type="text"
              className="form-control me-2"
              placeholder="Search by Inspiration..."
              aria-label="Search"
              value={query}
              onChange={(e) => setQuery(e.target.value)}
            />
            <button className="btn btn-outline-light text-dark" type="submit">
              <FontAwesomeIcon icon={faSearch} /> Search
            </button>
          </form>

          {/* Right-Aligned Links */}
          <ul className="navbar-nav ms-auto">
             <li className="nav-item">
              <Link to="/cart" className="nav-link">
                <FontAwesomeIcon icon={faShoppingCart} /> Cart
              </Link>
            </li>
            <li className="nav-item">
              <Link to="/login" className="nav-link">
                Login
              </Link>
            </li>
            <li className="nav-item">
              <Link to="/register" className="nav-link">
                Sign up
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;