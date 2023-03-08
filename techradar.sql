-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 08. Mrz 2023 um 17:19
-- Server-Version: 10.4.17-MariaDB
-- PHP-Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `techradar`
--
CREATE DATABASE IF NOT EXISTS `techradar` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `techradar`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `categories`
--

CREATE TABLE `categories` (
  `categoryId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `categories`
--

INSERT INTO `categories` (`categoryId`, `name`, `description`) VALUES
(1, 'Techniques', ''),
(2, 'Platforms', ''),
(3, 'Tools', ''),
(4, 'Languages & Frameworks', '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `rings`
--

CREATE TABLE `rings` (
  `ringId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `rings`
--

INSERT INTO `rings` (`ringId`, `name`, `description`) VALUES
(1, 'Assess', ''),
(2, 'Trial', ''),
(3, 'Adopt', ''),
(4, 'Hold', '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `technologies`
--

CREATE TABLE `technologies` (
  `technologyId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `explanation` text DEFAULT NULL,
  `categoryId` int(11) NOT NULL,
  `ringId` int(11) DEFAULT NULL,
  `isPublished` tinyint(1) NOT NULL DEFAULT 0,
  `createDate` datetime DEFAULT NULL,
  `lastEditDate` datetime DEFAULT NULL,
  `publicationDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `technologies`
--

INSERT INTO `technologies` (`technologyId`, `name`, `description`, `explanation`, `categoryId`, `ringId`, `isPublished`, `createDate`, `lastEditDate`, `publicationDate`) VALUES
(1, 'Angular', 'A JavaScript Framework', 'A JavaScript Framework', 4, 4, 1, '2023-03-05 16:11:36', '2023-03-05 16:11:36', '2023-03-05 16:11:36'),
(2, 'Vue.js 3', 'Vue (pronounced /vjuː/, like view) is a JavaScript framework for building user interfaces.', 'Vue.js is an open-source model–view–viewmodel front end JavaScript framework for building user interfaces and single-page applications. It was created by Evan You, and is maintained by him and the rest of the active core team members.', 4, 3, 1, '2023-03-05 16:11:52', '2023-03-05 16:11:52', '2023-03-05 16:11:52'),
(3, 'Design tokens', 'Design tokens store values such as colors in variables', 'When faced with the challenge of using a design system consistently across many form factors and platforms, the team at Salesforce came up with the concept of design tokens. The tokens store values, such as colors and fonts, in one central place. This makes it possible to separate options from decisions, and it significantly improves collaboration between teams. Design tokens are not new, but with the introduction of tools like Tailwind CSS and Style Dictionary, we see design tokens being used more often.', 1, 2, 0, '2023-03-05 16:11:08', '2023-03-05 16:11:08', '2023-03-05 16:11:08'),
(5, 'Apache Superset', 'Apache Superset is a business intelligence tool to visualize data', 'Apache Superset is a great business intelligence (BI) tool for data exploration and visualization to work with large data lake and data warehouse setups. It supports several data sources — including AWS Redshift, BigQuery, Azure MS SQL, Snowflake and ClickHouse. Moreover, you don\'t have to be a data engineer to use it; it\'s meant to benefit all engineers exploring data in their everyday work. For demanding use cases, we found it easy to scale Superset by deploying it in a Kubernetes cluster. Since we last talked about it in the Radar, Superset has graduated as an Apache product, and we\'ve seen great success in several projects.', 3, 2, 1, '2023-03-05 16:12:03', '2023-03-05 16:12:03', '2023-03-05 16:12:03'),
(6, 'Delta Lake', 'Delta Lake is an open-source storage layer, implemented by Databricks, that attempts to bring ACID transactions to big data processing.', 'Delta Lake is an open-source storage layer, implemented by Databricks, that attempts to bring ACID transactions to big data processing. In our Databricks-enabled data lake or data mesh projects, our teams prefer using Delta Lake storage over the direct use of file storage types such as AWS S3 or ADLS.', 2, 3, 1, '2023-03-05 16:14:23', '2023-03-05 16:14:23', '2023-03-05 16:14:23'),
(7, 'TinyML', 'TinyML is a technique to create small ML models that can run on a moblie device', 'We continue to be excited by the TinyML technique and the ability to create machine learning (ML) models designed to run on low-powered and mobile devices. Until recently, executing an ML model was seen as computationally expensive and, in some cases, required special-purpose hardware. While creating the models still broadly sits within this classification, they can now be created in a way that allows them to be run on small, low-cost and low-power consumption devices. If you\'ve been considering using ML but thought it unrealistic because of compute or network constraints, then this technique is worth assessing.', 1, 1, 1, '2023-03-08 17:12:53', '2023-03-08 17:12:53', '2023-03-08 17:12:53'),
(8, 'CUPID', 'CUPID is a set of ideas to write better code', 'How do you approach writing good code? How do you judge if you\'ve written good code? As software developers, we\'re always looking for catchy rules, principles and patterns that we can use to share a language and values with each other when it comes to writing simple, easy-to-change code.\n\nDaniel Terhorst-North has recently made a new attempt at creating such a checklist for good code. He argues that instead of sticking to a set of rules like SOLID, using a set of properties to aim for is more generally applicable. He came up with what he calls the CUPID properties to describe what we should strive for to achieve \"joyful\" code: Code should be composable, follow the Unix philosophy and be predictable, idiomatic and domain based.', 1, 1, 1, '2023-03-08 17:15:32', '2023-03-08 17:15:32', '2023-03-08 17:15:32'),
(9, 'Dragonfly', 'Dragonfly is a in-memory database', 'Dragonfly is a new in-memory data store with compatible Redis and Memcached APIs. It leverages the new Linux-specific io_uring API for I/O and implements novel algorithms and data structures on top of a multithreaded, shared-nothing architecture. Because of these clever choices in implementation, Dragonfly achieves impressive results in performance. Although Redis continues to be our default choice for in-memory data store solutions, we do think Dragonfly is an interesting choice to assess.', 2, 1, 1, '2023-03-08 17:16:52', '2023-03-08 17:16:52', '2023-03-08 17:16:52');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`categoryId`);

--
-- Indizes für die Tabelle `rings`
--
ALTER TABLE `rings`
  ADD PRIMARY KEY (`ringId`);

--
-- Indizes für die Tabelle `technologies`
--
ALTER TABLE `technologies`
  ADD PRIMARY KEY (`technologyId`),
  ADD KEY `categoryId` (`categoryId`),
  ADD KEY `ringId` (`ringId`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `categories`
--
ALTER TABLE `categories`
  MODIFY `categoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `rings`
--
ALTER TABLE `rings`
  MODIFY `ringId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `technologies`
--
ALTER TABLE `technologies`
  MODIFY `technologyId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `technologies`
--
ALTER TABLE `technologies`
  ADD CONSTRAINT `fk_categoryId` FOREIGN KEY (`categoryId`) REFERENCES `categories` (`categoryId`),
  ADD CONSTRAINT `fk_ringId` FOREIGN KEY (`ringId`) REFERENCES `rings` (`ringId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

GRANT SELECT, INSERT, UPDATE, DELETE ON `techradar`.* TO `techradar`@`%` IDENTIFIED BY PASSWORD '*E521A0D719A56BEBD9B69AC5A290F9D0086E003E';