-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2019 at 08:31 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `criminall`
--

-- --------------------------------------------------------

--
-- Table structure for table `basic`
--

CREATE TABLE `basic` (
  `Keynum` int(11) DEFAULT NULL,
  `Name` text,
  `Address` text,
  `Status` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `basic`
--

INSERT INTO `basic` (`Keynum`, `Name`, `Address`, `Status`) VALUES
(1, 'Kenneth', 'H. Alarcon st. Antipolo City', 'Not'),
(2, 'Kenneth', 'Antipolo, Rizal', 'Not'),
(3, 'Kimmy', 'Mendoza Farm', 'Not'),
(4, 'Kimmy', 'Pag-ibig', 'Archived');

-- --------------------------------------------------------

--
-- Table structure for table `cases`
--

CREATE TABLE `cases` (
  `Keynum` int(11) DEFAULT NULL,
  `Name` text NOT NULL,
  `Casess` text,
  `Date` text,
  `Details` text NOT NULL,
  `Status` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cases`
--

INSERT INTO `cases` (`Keynum`, `Name`, `Casess`, `Date`, `Details`, `Status`) VALUES
(1, 'Kenneth', 'Robbery', '12/12/19', 'Nagnakaw ng Leche Plan', 'Not'),
(1, 'Kenneth', 'Killer', '12/11/19', 'Naistress sa Mobile Legends kaya ayun', 'Not'),
(2, 'Kenneth', 'Homicide', '11/12/19', 'Ayun nawalan ng pag-asa', 'Not'),
(3, 'Kimmy', 'Robbery', '12/12/19', 'Nangati ang kamay kung kayat nagnakaw ng laruan', 'Not'),
(3, 'Kimmy', 'Killer', '12/12/19', 'Dahil sa Lego nakapatay ng tao', 'Not');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Username` text,
  `Password` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Username`, `Password`) VALUES
('Me', 'Me');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
