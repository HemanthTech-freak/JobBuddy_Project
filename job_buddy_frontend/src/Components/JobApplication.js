import React, { useEffect, useState, useContext } from "react";
import apiService from "../utils/apiService";
import { toast } from "react-toastify";
import "../assets/css/job_search_page.css";
import { useLocation } from "react-router-dom";
import AuthContext from "../context/AuthContext";

const JobApplication = () => {
  const location = useLocation();
  const { jobId } = location.state || {};
  const { user } = useContext(AuthContext); 
  const userID = user?.userID;

  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    dob: "",
    phone: "",
    linkedin: "",
    resume: null,
    coverLetter: "",
  });
  const [jobTitle, setJobTitle] = useState("");
  const [loading, setLoading] = useState(false);
  const [errors, setErrors] = useState({});
  const [hasApplied, setHasApplied] = useState(false);

  useEffect(() => {
    // check user and role are valid 
    const role = localStorage.getItem("role");
    if (role !== "Job Seeker") {
      toast.error("Employers cannot apply for jobs.");
      return;
    }

    if (!userID || !jobId) {
      toast.error("Missing job or user information.");
      return;
    }

    // Fetch job details to get job title
    const fetchJobDetails = async () => {
      try {
        const response = await apiService.get(`/api/JobListing/${jobId}`);
        setJobTitle(response.data.data.jobTitle);
      } catch (error) {
        toast.error("Failed to fetch job details.");
      }
    };

    // Fetch user profile data from API to prefill form
    const fetchUserProfile = async () => {
      try {
        const response = await apiService.get(`/api/UserProfile/${userID}`);
        const profile = response.data.data;
        const [firstName, lastName] = profile.fullName.split(" ", 2);
        setFormData((prev) => ({
          ...prev,
          firstName: firstName || "",
          lastName: lastName || "",
          email: profile.email,
          dob: profile.dateOfBirth.split("T")[0],
          phone: profile.phoneNumber,
          linkedin: profile.linkedInUrl,
        }));
      } catch (error) {
        toast.error("Failed to fetch user profile details.");
      }
    };

    fetchUserProfile();
    fetchJobDetails();
  }, [userID, jobId]);

  const handleChange = (e) => {
    const { name, value, files } = e.target;
    setFormData({
      ...formData,
      [name]: files ? files[0] : value,
    });
  };

  const validateForm = () => {
    const newErrors = {};
    if (!formData.resume) newErrors.resume = "Resume is required.";
    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    if (!validateForm()) return;

    setLoading(true);

    try {
      // Check if a resume with the same title already exists for the user
      const existingResumesResponse = await apiService.get(`/api/resume/${userID}`);
      if (existingResumesResponse.data.success && existingResumesResponse.data.data) {
        const existingResumes = existingResumesResponse.data.data;
        const existingResume = existingResumes.find(
          (resume) => resume.title === jobTitle
        );

        if (existingResume) {
          // Resume with the same title exists, use existing resume ID for application
          const applicationData = {
            jobId: jobId,
            userId: userID,
            firstName: formData.firstName,
            lastName: formData.lastName,
            email: formData.email,
            dob: formData.dob,
            phone: formData.phone,
            linkedin: formData.linkedin,
            resumeId: existingResume.resumeID,
            coverLetter: formData.coverLetter,
          };

          await apiService.post("/api/applications", applicationData);
          toast.success("Application submitted successfully!");
          setHasApplied(true);
          setLoading(false);
          return;
        }
      }

      // Upload the resume
      const resumeData = new FormData();
      resumeData.append("resumeFile", formData.resume);
      resumeData.append("title", jobTitle);
      resumeData.append("userID", userID);

      const resumeResponse = await apiService.post("/api/resume/upload", resumeData);
      const resumeId = resumeResponse.data.data.resumeID; 

      const applicationData = {
        jobId: jobId,
        userId: userID,
        firstName: formData.firstName,
        lastName: formData.lastName,
        email: formData.email,
        dob: formData.dob,
        phone: formData.phone,
        linkedin: formData.linkedin,
        resumeId: resumeId,
        coverLetter: formData.coverLetter,
      };

      await apiService.post("/api/applications", applicationData);
      toast.success("Application submitted successfully!");
      setHasApplied(true);
    } catch (error) {
      if (error.response && error.response.data && error.response.data.errors) {
        const apiErrors = error.response.data.errors;
        if (apiErrors.Linkedin) {
          toast.error("LinkedIn URL must be valid.");
        }
        if (apiErrors.ResumeID) {
          toast.error("Resume ID must be a positive number.");
        }
      } else {
        toast.error("Failed to submit application.");
      }
    } finally {
      setLoading(false);
    }
  };

  return (
    <form onSubmit={handleSubmit} className="job-application-form">
      <div className="form-group text-field-container">
        <label htmlFor="firstName" className="text-field-label">First Name</label>
        <input type="text" name="firstName" value={formData.firstName} onChange={handleChange} className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="lastName" className="text-field-label">Last Name</label>
        <input type="text" name="lastName" value={formData.lastName} onChange={handleChange} className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="email" className="text-field-label">Email</label>
        <input type="email" name="email" value={formData.email} readOnly className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="dob" className="text-field-label">Date of Birth</label>
        <input type="date" name="dob" value={formData.dob} readOnly className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="phone" className="text-field-label">Phone</label>
        <input type="text" name="phone" value={formData.phone} onChange={handleChange} className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="linkedin" className="text-field-label">LinkedIn Address (Optional)</label>
        <input type="text" name="linkedin" value={formData.linkedin} onChange={handleChange} className="text-field-input" />
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="resume" className="text-field-label">Upload Resume</label>
        <input type="file" name="resume" onChange={handleChange} className="text-field-input" />
        {errors.resume && <span className="error-text">{errors.resume}</span>}
      </div>
      <div className="form-group text-field-container">
        <label htmlFor="coverLetter" className="text-field-label">Cover Letter (Optional)</label>
        <textarea name="coverLetter" value={formData.coverLetter} onChange={handleChange} className="text-field-input" />
      </div>
      <button type="submit" className="btn-submit full-width" disabled={loading || hasApplied}>
        {loading ? "Submitting..." : hasApplied ? "Already Applied" : "Submit Application"}
      </button>
    </form>
  );
};

export default JobApplication;
