-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 06, 2025 at 04:15 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `thrive`
--

-- --------------------------------------------------------

--
-- Table structure for table `journal`
--

CREATE TABLE `journal` (
  `entryId` int(11) NOT NULL,
  `UserJournal_Id` int(11) DEFAULT NULL,
  `Cotent` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `moodtracker`
--

CREATE TABLE `moodtracker` (
  `MoodId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `MoodScore` varchar(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `moodtracker`
--

INSERT INTO `moodtracker` (`MoodId`, `UserId`, `MoodScore`, `Date`) VALUES
(7, 0, 'Anxiety', '2024-12-30'),
(8, 0, 'Sadness', '2024-12-30');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserId` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserId`, `UserName`, `Email`, `Password`) VALUES
(4, 'selam', 'selam@gmail.com', '$2a$11$Y1vnZKMuqzOSXEbZxcemzuLEI9xolHoQJVdOu1hzw2SaBHOa.M1I6'),
(6, 'arsemaT', 'arsema@gmail.com', '$2a$11$bujAVcE3uUi/HWYdZx.GXe4ne8zo4z9tvCZiaVHpkCwa9eO/TcC3m'),
(8, 'beshu', 'beshu@gmail.com', '$2a$11$tS.i56pVWfs.mGQ4gVOaZuSUtMEuNODSoUXt76XTyCGS3KGQy/b96');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `journal`
--
ALTER TABLE `journal`
  ADD PRIMARY KEY (`entryId`),
  ADD KEY `journalForeign` (`UserJournal_Id`);

--
-- Indexes for table `moodtracker`
--
ALTER TABLE `moodtracker`
  ADD PRIMARY KEY (`MoodId`),
  ADD KEY `moodtracker_ibfk_1` (`UserId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `journal`
--
ALTER TABLE `journal`
  MODIFY `entryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `moodtracker`
--
ALTER TABLE `moodtracker`
  MODIFY `MoodId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `journal`
--
ALTER TABLE `journal`
  ADD CONSTRAINT `journalForeign` FOREIGN KEY (`UserJournal_Id`) REFERENCES `user` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
