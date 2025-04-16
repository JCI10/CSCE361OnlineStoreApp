import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import { FaUser } from "react-icons/fa";

const Login = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    // Add your authentication logic here
    console.log('Login submitted:', { email, password });
    // Redirect after login
    navigate('/');
  };

  return (
    <div className="login-container">
      <div className="login-form">
        <h2>Login to Your Account</h2>
        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Email</label>
            
            <input
              type="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
            />
            <FaUser />
          </div>
          <div className="form-group">
            <label>Password</label>
            <input
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>
          <button type="submit" className="login-button">Login</button>
        </form>
        <div className="register-prompt">
          Don't have an account? <Link to="/register">Register here</Link>
        </div>
      </div>
    </div>
  );
};

export default Login;