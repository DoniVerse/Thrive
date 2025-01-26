-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2025 at 09:32 PM
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
-- Table structure for table `excerise`
--

CREATE TABLE `excerise` (
  `ExceriseId` int(100) NOT NULL,
  `Link` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `excerise`
--

INSERT INTO `excerise` (`ExceriseId`, `Link`) VALUES
(1, 'C:\\xampp\\htdocs\\Thrive\\exercise\\tai chi.mp4'),
(2, 'C:\\xampp\\htdocs\\Thrive\\exercise\\yoga.mp4'),
(3, 'C:\\xampp\\htdocs\\Thrive\\exercise\\pilates.mp4'),
(4, 'C:\\Users\\Afomi\\Downloads\\meditation.mp4'),
(5, 'C:\\xampp\\htdocs\\Thrive\\exercise\\breathing.mp4');

-- --------------------------------------------------------

--
-- Table structure for table `journal`
--

CREATE TABLE `journal` (
  `entryId` int(11) NOT NULL,
  `UserJournal_Id` int(11) DEFAULT NULL,
  `Cotent` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `journal`
--

INSERT INTO `journal` (`entryId`, `UserJournal_Id`, `Cotent`) VALUES
(22, 13, NULL),
(27, 13, 'sd'),
(28, 13, 'helll'),
(29, 13, 'dfdfhggjhjk');

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
(9, 0, 'Disgusted', '2025-01-15'),
(11, 13, 'Sadness', '2025-01-15'),
(12, 13, 'Anxiety', '2025-01-15'),
(13, 13, 'Sadness', '2025-01-15'),
(14, 13, 'Anxiety', '2025-01-16'),
(15, 13, 'Fear', '2025-01-23');

-- --------------------------------------------------------

--
-- Table structure for table `sound`
--

CREATE TABLE `sound` (
  `SoundId` int(255) NOT NULL,
  `SoundFile` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sound`
--

INSERT INTO `sound` (`SoundId`, `SoundFile`) VALUES
(1, 'C:\\xampp\\htdocs\\Thrive\\Soundtracks\\rainfall.mp3'),
(2, 'C:\\xampp\\htdocs\\Thrive\\Soundtracks\\nature.mp3'),
(3, 'C:\\xampp\\htdocs\\Thrive\\Soundtracks\\white.mp3'),
(4, 'C:\\xampp\\htdocs\\Thrive\\Soundtracks\\NF.mp3'),
(5, 'C:\\xampp\\htdocs\\Thrive\\Soundtracks\\cozy.mp3');

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
(6, 'arsemaT', 'arsema@gmail.com', '$2a$11$bujAVcE3uUi/HWYdZx.GXe4ne8zo4z9tvCZiaVHpkCwa9eO/TcC3m'),
(11, 'beshu', 'beshu@gmail.com', '$2a$11$0ngBm6jqSRThI0O1QoF9Qui46m05bQYuaRLc3FsowofTxrf7msdNO'),
(12, 'hi', 'hi@gmail.com', '$2a$11$OPoz3A7mWS3lno02FZ8Fw.U0zgzf6oXAEtMmQ1BDLZi4y9u863yhK'),
(13, 'bello', 'bello@gmail.com', '$2a$11$fD26S4zPjTXbGxkKpVBo4e.wnoldqzIYgxEIAsUyxPiLLU7m3zz4i');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `excerise`
--
ALTER TABLE `excerise`
  ADD PRIMARY KEY (`ExceriseId`);

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
-- Indexes for table `sound`
--
ALTER TABLE `sound`
  ADD PRIMARY KEY (`SoundId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `excerise`
--
ALTER TABLE `excerise`
  MODIFY `ExceriseId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `journal`
--
ALTER TABLE `journal`
  MODIFY `entryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `moodtracker`
--
ALTER TABLE `moodtracker`
  MODIFY `MoodId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `sound`
--
ALTER TABLE `sound`
  MODIFY `SoundId` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

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
