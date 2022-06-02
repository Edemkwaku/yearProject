-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2022 at 11:40 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mdatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `id` int(11) NOT NULL,
  `stuID` varchar(10) NOT NULL,
  `class` varchar(20) NOT NULL,
  `course` varchar(20) NOT NULL,
  `attend` int(11) NOT NULL,
  `attend_date` date NOT NULL,
  `inTime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `outTime` time DEFAULT NULL,
  `remark` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id`, `stuID`, `class`, `course`, `attend`, `attend_date`, `inTime`, `outTime`, `remark`) VALUES
(26, '5675', 'ICT3', 'ICT022', 9, '2022-05-16', '2022-05-16 09:26:47', NULL, NULL),
(27, '5675', 'ICT3', 'CSC', 2, '2022-05-16', '2022-05-16 09:24:13', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `classID` varchar(20) NOT NULL,
  `className` varchar(50) NOT NULL,
  `programme` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`classID`, `className`, `programme`) VALUES
('ICT3', 'HND ICT3', 'ict200');

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `courseID` varchar(20) NOT NULL,
  `courseName` varchar(50) NOT NULL,
  `Duration` int(1) NOT NULL,
  `programme` varchar(50) NOT NULL,
  `lecID` varchar(10) NOT NULL,
  `venue` varchar(50) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`courseID`, `courseName`, `Duration`, `programme`, `lecID`, `venue`, `start_time`, `end_time`) VALUES
('CSC', 'C++ Programming', 3, 'csc100', '345', 'v11', '09:00:00', '11:00:00'),
('ICT022', 'C++', 3, 'ict200', '345', 'v11', '09:00:00', '11:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `deptID` varchar(20) NOT NULL,
  `deptName` varchar(50) NOT NULL,
  `facultyID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`deptID`, `deptName`, `facultyID`) VALUES
('117', 'Eating', '56'),
('119', 'football', '56');

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `facultyID` varchar(20) NOT NULL,
  `facultyName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`facultyID`, `facultyName`) VALUES
('56', 'CASS');

-- --------------------------------------------------------

--
-- Table structure for table `gender`
--

CREATE TABLE `gender` (
  `genderID` int(1) NOT NULL,
  `gender` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `gender`
--

INSERT INTO `gender` (`genderID`, `gender`) VALUES
(1, 'male'),
(2, 'female');

-- --------------------------------------------------------

--
-- Table structure for table `lecturer`
--

CREATE TABLE `lecturer` (
  `lecID` varchar(20) NOT NULL,
  `fullName` varchar(50) NOT NULL,
  `DoB` date DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `gender` int(1) NOT NULL,
  `phone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `lecturer`
--

INSERT INTO `lecturer` (`lecID`, `fullName`, `DoB`, `email`, `gender`, `phone`) VALUES
('345', 'fdfd', '2022-04-12', 'debg', 1, '0223435544'),
('453', 'Edem', '2022-04-06', 'edem@5', 1, '878990076665');

-- --------------------------------------------------------

--
-- Table structure for table `programme`
--

CREATE TABLE `programme` (
  `proID` varchar(20) NOT NULL,
  `proName` varchar(50) NOT NULL,
  `deptID` varchar(20) NOT NULL,
  `courseID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `programme`
--

INSERT INTO `programme` (`proID`, `proName`, `deptID`, `courseID`) VALUES
('csc100', 'CSC', '111', ''),
('ict200', 'ICT', '111', '');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `roleID` int(1) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`roleID`, `role`) VALUES
(1, 'Administrator'),
(2, 'Lecturer'),
(3, 'student');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `stuID` varchar(10) NOT NULL,
  `fName` varchar(50) NOT NULL,
  `lName` varchar(50) NOT NULL,
  `DoB` date NOT NULL,
  `genderID` int(1) NOT NULL,
  `programme` varchar(20) NOT NULL,
  `phone` int(11) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`stuID`, `fName`, `lName`, `DoB`, `genderID`, `programme`, `phone`, `email`) VALUES
('5675', 'John', 'Edem', '2022-04-18', 1, 'ict200', 56768978, 'dfgfh'),
('7648487843', 'Sacky', 'John', '1980-10-12', 1, 'csc100', 256344845, 'avo@gmail.com'),
('fg4765754', 'Mama', 'Kojo', '1997-10-15', 2, 'csc100', 540908267, 'edenkwaku85@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `role`) VALUES
('edem', 'edem@kwaku', 1),
('edem1', '11111111', 2),
('edem2', 'edem@kwaku2', 3),
('hakim', '6523ydwe63445', 3),
('kwaku', 'MD5edemkwau@', 1),
('ytrtrtt', 'yyyyyyyyyyyy', 3);

-- --------------------------------------------------------

--
-- Table structure for table `venue`
--

CREATE TABLE `venue` (
  `venueID` varchar(5) NOT NULL,
  `venueName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Dumping data for table `venue`
--

INSERT INTO `venue` (`venueID`, `venueName`) VALUES
('V13', 'V13'),
('67', 'V15'),
('v11', 'V18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `attendance_ibfk_1` (`stuID`),
  ADD KEY `class` (`class`),
  ADD KEY `course` (`course`);

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`classID`),
  ADD UNIQUE KEY `className` (`className`),
  ADD KEY `programme` (`programme`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`courseID`),
  ADD KEY `course_ibfk_1` (`lecID`),
  ADD KEY `course_ibfk_2` (`programme`),
  ADD KEY `venue` (`venue`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`deptID`),
  ADD KEY `department_ibfk_1` (`facultyID`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`facultyID`);

--
-- Indexes for table `gender`
--
ALTER TABLE `gender`
  ADD PRIMARY KEY (`genderID`);

--
-- Indexes for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD PRIMARY KEY (`lecID`),
  ADD UNIQUE KEY `email` (`email`,`phone`),
  ADD KEY `lecturer_ibfk_1` (`gender`);

--
-- Indexes for table `programme`
--
ALTER TABLE `programme`
  ADD PRIMARY KEY (`proID`),
  ADD UNIQUE KEY `proName` (`proName`),
  ADD KEY `programme_ibfk_1` (`deptID`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`roleID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`stuID`),
  ADD UNIQUE KEY `phone` (`phone`,`email`),
  ADD KEY `genderID` (`genderID`),
  ADD KEY `programme` (`programme`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`),
  ADD KEY `users_ibfk_1` (`role`);

--
-- Indexes for table `venue`
--
ALTER TABLE `venue`
  ADD PRIMARY KEY (`venueID`),
  ADD UNIQUE KEY `venueName` (`venueName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`stuID`) REFERENCES `student` (`stuID`) ON DELETE CASCADE,
  ADD CONSTRAINT `class` FOREIGN KEY (`class`) REFERENCES `class` (`classID`) ON DELETE CASCADE,
  ADD CONSTRAINT `course` FOREIGN KEY (`course`) REFERENCES `course` (`courseID`);

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `programme` FOREIGN KEY (`programme`) REFERENCES `programme` (`proID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `course_ibfk_1` FOREIGN KEY (`lecID`) REFERENCES `lecturer` (`lecID`) ON DELETE CASCADE,
  ADD CONSTRAINT `course_ibfk_2` FOREIGN KEY (`programme`) REFERENCES `programme` (`proID`) ON DELETE CASCADE,
  ADD CONSTRAINT `course_ibfk_3` FOREIGN KEY (`venue`) REFERENCES `venue` (`venueID`);

--
-- Constraints for table `department`
--
ALTER TABLE `department`
  ADD CONSTRAINT `department_ibfk_1` FOREIGN KEY (`facultyID`) REFERENCES `faculty` (`facultyID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD CONSTRAINT `lecturer_ibfk_1` FOREIGN KEY (`gender`) REFERENCES `gender` (`genderID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`genderID`) REFERENCES `gender` (`genderID`),
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`programme`) REFERENCES `programme` (`proID`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role`) REFERENCES `role` (`roleID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
