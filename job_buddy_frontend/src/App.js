import "./App.css";
import Navbar from "./Components/Navbar";
import Footer from "./Components/Footer";
import "../src/style.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Home from "./Components/Home";
import Login from "./Components/Login";
import Signup from "./Components/Signup";
import Contact from "./Components/Contact";
import About from "./Components/About";
import Job_Search_Page from "./Components/Job_Search_Page";
import PostJob from "./Components/PostJob";
import Profile from "./Components/Profile";

function App() {
  return (
    <>
      <Router>
        <Navbar />

        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/login" element={<Login />} />
          <Route path="/sign-up" element={<Signup />} />
          <Route path="/Job" element={<Job_Search_Page />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/post" element={<PostJob />} />
          <Route path="/profile" element={<Profile />} />
        </Routes>
        <Footer />
      </Router>
    </>
  );
}

export default App;
