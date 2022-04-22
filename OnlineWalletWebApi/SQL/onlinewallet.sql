-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Ápr 22. 08:17
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `onlinewallet`
--
CREATE DATABASE IF NOT EXISTS `onlinewallet` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `onlinewallet`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `bankkartya`
--

DROP TABLE IF EXISTS `bankkartya`;
CREATE TABLE IF NOT EXISTS `bankkartya` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `cardNumber` varchar(255) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `date` varchar(255) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `securityCode` varchar(255) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `firstName` varchar(255) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `lastName` varchar(255) COLLATE utf8mb4_hungarian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `bankkartya`
--

INSERT INTO `bankkartya` (`ID`, `cardNumber`, `date`, `securityCode`, `firstName`, `lastName`) VALUES
(1, '', '2025', '654', 'Tamás', 'Aradi'),
(2, '', '2024', '774', 'Máté', 'Tóth');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalo`
--

DROP TABLE IF EXISTS `felhasznalo`;
CREATE TABLE IF NOT EXISTS `felhasznalo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `email` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `username` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalo`
--

INSERT INTO `felhasznalo` (`ID`, `fullname`, `email`, `username`, `password`) VALUES
(1, 'Aradi Tamás', 'sz0aratam@vasvari.org', 'sz0aratam', 'jelszo'),
(2, 'Toth Máté Pál', 'sz0totmat@vasvari.org', 'sz0totmat', 'ezajelszo');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `igazolvany`
--

DROP TABLE IF EXISTS `igazolvany`;
CREATE TABLE IF NOT EXISTS `igazolvany` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `documentId` varchar(255) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `year` varchar(255) NOT NULL,
  `month` varchar(255) NOT NULL,
  `day` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
