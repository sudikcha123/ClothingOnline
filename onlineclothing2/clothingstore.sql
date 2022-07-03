-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2022 at 07:14 AM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `clothingstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `addproduct`
--

CREATE TABLE `addproduct` (
  `id` int(11) NOT NULL,
  `name` longtext DEFAULT NULL,
  `category` longtext DEFAULT NULL,
  `status` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL,
  `size` longtext DEFAULT NULL,
  `oprice` int(50) NOT NULL,
  `price` int(11) NOT NULL,
  `stock` int(11) NOT NULL,
  `imgpath` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `addproduct`
--

INSERT INTO `addproduct` (`id`, `name`, `category`, `status`, `Description`, `size`, `oprice`, `price`, `stock`, `imgpath`) VALUES
(8, 'kurta', 'Westernwear', 'Available', 'ywvduhdoeskf[sofhisgduasgd', 'xx', 500, 200, 5, '/images/productimage/c55e39d1-9f17-4744-bcae-b67a05cdddf2_kurtha6.jpg'),
(9, 'kurthi', 'Ethnicswear', 'Available', 'abwudbofjpgojesoifbawivdiwaud', 'Medium', 1000, 900, 5, '/images/productimage/44396403-29ed-4498-a66e-c20c940fab93_kurtha11.jpg'),
(10, 'black top', 'Tops & pants', 'Available', 'ashdbskfnlkjdsbjbu', 'xx', 1200, 1100, 2, '/images/productimage/99056221-25db-440c-ba4a-c2f7aea342da_tops3.jpg'),
(11, 'night dress', 'Nightsuits', 'Available', 'asvdsehoiforejrfidfhukdsfguds', 'l', 700, 655, 4, '/images/productimage/7078f508-228f-421f-9f96-69456c01611e_nightdress6.jpg'),
(12, 'skirt', 'Westernwear', 'Available', 'we have black skirt in our store.At its simplest, a skirt can be a draped garment made out of a single piece of fabric (such as pareos). However, most skirts are fitted to the body at the waist or hips and fuller below, with the fullness introduced by means of darts, gores, pleats, or panels. Modern skirts are usually made of light to mid-weight fabrics, such as denim, jersey, worsted, or poplin. Skirts of thin or clingy fabrics are often worn with slips to make the material of the skirt drape better and for modesty.', 'Medium', 1500, 1499, 10, '/images/productimage/d9bf1115-ce4e-4d83-9f89-5d33deb01108_skirt5.jpg'),
(13, 'Onepiece', 'Westernwear', 'Available', 'gjkads', 'xx', 3000, 2800, 5, '/images/productimage/eeb4eae8-8923-44ce-90e4-1a6f566607e7_greypice1.jpg'),
(14, 'Onepiecelong', 'Westernwear', 'Available', 'gjkaleuieal', 'xx', 3000, 2800, 4, '/images/productimage/61233693-1af9-4801-8413-9cf4ba06c865_piece19.jpg'),
(15, 'Onepiece', 'Westernwear', 'Available', 'gjakeujalkjd', 'xx', 4000, 3500, 5, '/images/productimage/e30182f5-1b06-41ed-9296-176e9738cc6f_piece1.jpg'),
(16, 'Onepieceflower', 'Westernwear', 'Available', 'hakljhfkljdklf', 'xx', 3500, 2800, 5, '/images/productimage/a043238e-cef8-4e18-967e-7bfe792b9b3b_piece5.jpg'),
(17, 'Onepieceblack', 'Westernwear', 'Available', 'bsfnlskjd', 'xx', 1500, 1000, 3, '/images/productimage/500fbb8e-548c-42a3-a11d-d541d1c35e2d_piece27.jpg'),
(18, 'sari', 'Ethnicswear', 'Available', 'ajklf lksdfn ', 'xx', 4444, 4000, 5, '/images/productimage/0a3caa25-c12d-451b-a416-46f18236828c_saree12.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `adminlogin`
--

CREATE TABLE `adminlogin` (
  `email` varchar(150) NOT NULL,
  `Password` longtext NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `adminlogin`
--

INSERT INTO `adminlogin` (`email`, `Password`, `role`) VALUES
('binodh@gmail.com', 'binodh123', '');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `id` int(11) NOT NULL,
  `price` int(100) NOT NULL,
  `Username` varchar(150) NOT NULL,
  `quantity` int(150) NOT NULL,
  `productid` int(12) NOT NULL,
  `name` varchar(100) NOT NULL,
  `category` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`id`, `price`, `Username`, `quantity`, `productid`, `name`, `category`) VALUES
(2, 0, 'kurtha', 0, 8, '', ''),
(6, 500, 'test', 1, 8, 'kurta', 'Westernwear'),
(7, 500, 'binita@gmail.com', 2, 8, 'kurta', 'Westernwear'),
(8, 500, 'binita@gmail.com', 5, 8, 'kurta', 'Westernwear'),
(9, 1500, 'binita@gmail.com', 4, 12, 'skirt', 'Westernwear'),
(10, 700, 'binita@gmail.com', 1, 11, 'night dress', 'Nightsuits'),
(11, 1500, 'binita@gmail.com', 2, 17, 'Onepieceblack', 'Westernwear'),
(12, 500, 'binita@gmail.com', 2, 8, 'kurta', 'Westernwear'),
(13, 1500, 'binita@gmail.com', 5, 12, 'skirt', 'Westernwear'),
(14, 3500, 'binita@gmail.com', 2, 16, 'Onepieceflower', 'Westernwear'),
(15, 1500, 'binita@gmail.com', 2, 12, 'skirt', 'Westernwear'),
(16, 4000, 'binita@gmail.com', 1, 15, 'Onepiece', 'Westernwear'),
(17, 3000, 'binita@gmail.com', 2, 14, 'Onepiecelong', 'Westernwear'),
(18, 1500, 'binita@gmail.com', 5, 12, 'skirt', 'Westernwear'),
(19, 1500, 'binita@gmail.com', 2, 12, 'skirt', 'Westernwear'),
(20, 1500, 'binita@gmail.com', 2, 12, 'skirt', 'Westernwear'),
(21, 1500, 'binita@gmail.com', 2, 12, 'skirt', 'Westernwear'),
(22, 500, 'binita@gmail.com', 2, 8, 'kurta', 'Westernwear'),
(23, 1500, 'binita@gmail.com', 2, 12, 'skirt', 'Westernwear'),
(24, 500, 'binita@gmail.com', 3, 8, 'kurta', 'Westernwear'),
(25, 500, 'me@gmail.com', 1, 8, 'kurta', 'Westernwear'),
(26, 4000, 'me@gmail.com', 2, 15, 'Onepiece', 'Westernwear'),
(27, 500, 'me@gmail.com', 4, 8, 'kurta', 'Westernwear'),
(28, 1000, 'me@gmail.com', 3, 9, 'kurthi', 'Ethnicswear');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `cid` int(11) NOT NULL,
  `cname` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`cid`, `cname`) VALUES
(3, 'Westernwear'),
(6, 'Ethnicswear'),
(7, 'Tops & pants'),
(8, 'Nightsuits');

-- --------------------------------------------------------

--
-- Table structure for table `checkout`
--

CREATE TABLE `checkout` (
  `id` int(10) NOT NULL,
  `fullname` varchar(150) NOT NULL,
  `delivery` varchar(150) NOT NULL,
  `phone` int(150) NOT NULL,
  `name` varchar(100) NOT NULL,
  `category` varchar(150) NOT NULL,
  `quantity` int(100) NOT NULL,
  `price` int(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `image`
--

CREATE TABLE `image` (
  `Id` int(50) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `loginuser`
--

CREATE TABLE `loginuser` (
  `Id` int(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `role` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `loginuser`
--

INSERT INTO `loginuser` (`Id`, `Email`, `Password`, `role`) VALUES
(2, 'sudhikchashrestha100@gmail.com', '1234567', 'user'),
(3, 'hehehhe@dgzd.com', '1234567', 'user'),
(4, 'binita@gmail.com', 'binita', 'user'),
(5, 'sudhikcha@gmail.com', 'sudi123', 'admin'),
(6, 'me@gmail.com', 'meme', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `userregistration`
--

CREATE TABLE `userregistration` (
  `id` int(20) NOT NULL,
  `username` varchar(100) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password` varchar(200) NOT NULL,
  `phone` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userregistration`
--

INSERT INTO `userregistration` (`id`, `username`, `email`, `password`, `phone`) VALUES
(1, 'sudhikchashrestha100@gmail.com', 'ramguy007@gmail.com', '1234asdfg', '9824994878'),
(2, 'sudhikchashrestha100@gmail.com', 'binod@921gmail.com', 'sasmung555', '9824994878'),
(3, 'skadja', 'lkasdnl', 'aspdjsap', '9824994878'),
(4, 'binodkhatri', 'ramguy007@gmail.com', 'sasmung555', '9824994878'),
(5, 'sudhikchashrestha100@gmail.com', 'sudhikchashrestha100@gmail.com', 'sudik', '9804998037'),
(6, 'subarna shrestha', 'Subarnashrestha12@gmail.com', 'subarna123', '984567889'),
(7, 'root', 'sudhikchashrestha100@gmail.com', '1234567', '9804998037'),
(8, 'astina', 'hehehhe@dgzd.com', '1234567', '+9779806062943'),
(9, 'binita', 'binita@gmail.com', 'binita', '980000'),
(10, 'me', 'me@gmail.com', 'meme', '9804998037');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addproduct`
--
ALTER TABLE `addproduct`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `adminlogin`
--
ALTER TABLE `adminlogin`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pfkey` (`productid`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`cid`);

--
-- Indexes for table `checkout`
--
ALTER TABLE `checkout`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `image`
--
ALTER TABLE `image`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `loginuser`
--
ALTER TABLE `loginuser`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `userregistration`
--
ALTER TABLE `userregistration`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addproduct`
--
ALTER TABLE `addproduct`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `cid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `checkout`
--
ALTER TABLE `checkout`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `image`
--
ALTER TABLE `image`
  MODIFY `Id` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `loginuser`
--
ALTER TABLE `loginuser`
  MODIFY `Id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `userregistration`
--
ALTER TABLE `userregistration`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `pfkey` FOREIGN KEY (`productid`) REFERENCES `addproduct` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
