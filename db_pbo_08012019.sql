/*
SQLyog Enterprise v12.5.1 (64 bit)
MySQL - 10.4.8-MariaDB : Database - db_pbo_08012019
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_pbo_08012019` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_pbo_08012019`;

/*Table structure for table `admin` */

DROP TABLE IF EXISTS `admin`;

CREATE TABLE `admin` (
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `lvl` int(1) NOT NULL,
  `status` int(1) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `admin` */

insert  into `admin`(`username`,`password`,`lvl`,`status`) values 
('admin','123',1,1);

/*Table structure for table `gaji` */

DROP TABLE IF EXISTS `gaji`;

CREATE TABLE `gaji` (
  `id_gaji` int(11) NOT NULL AUTO_INCREMENT,
  `id_karyawan` int(11) NOT NULL,
  `gajiKotor` int(16) NOT NULL,
  `jml_lembur` int(16) NOT NULL,
  `pajak` int(16) NOT NULL,
  `jml_tunjangan` int(16) NOT NULL,
  `gajiBersih` int(16) NOT NULL,
  `bulan` varchar(2) NOT NULL,
  `tahun` varchar(4) NOT NULL,
  `stsgaji` int(1) NOT NULL,
  PRIMARY KEY (`id_gaji`),
  KEY `id_karyawan` (`id_karyawan`),
  CONSTRAINT `gaji_ibfk_1` FOREIGN KEY (`id_karyawan`) REFERENCES `karyawan` (`id_karyawan`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

/*Data for the table `gaji` */

insert  into `gaji`(`id_gaji`,`id_karyawan`,`gajiKotor`,`jml_lembur`,`pajak`,`jml_tunjangan`,`gajiBersih`,`bulan`,`tahun`,`stsgaji`) values 
(1,2,7000,5,1050,3500,14450,'12','2019',1),
(2,4,7000,5,700,0,11300,'1','2020',1),
(3,5,7000,0,700,0,6300,'1','2020',1),
(4,6,0,0,0,0,0,'1','2020',1),
(5,7,6000,0,600,0,5400,'1','2020',1),
(6,8,9000,5,900,3000,10600,'1','2020',1),
(7,9,2000,4,200,0,2200,'1','2020',1),
(10,4,43400,5,4340,1400,44060,'1','2019',0),
(11,11,3700,7,370,1700,3330,'1','2020',1),
(12,12,9000,2,900,3000,9100,'1','2020',1),
(13,11,3300,3,330,1300,2970,'2','2020',1);

/*Table structure for table `jabatan` */

DROP TABLE IF EXISTS `jabatan`;

CREATE TABLE `jabatan` (
  `id_jabatan` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jabatan` varchar(20) NOT NULL,
  `jml_gaji_pokok` int(16) NOT NULL,
  `upah_lembur` int(16) NOT NULL,
  `stsjbtn` int(1) NOT NULL,
  PRIMARY KEY (`id_jabatan`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `jabatan` */

insert  into `jabatan`(`id_jabatan`,`nama_jabatan`,`jml_gaji_pokok`,`upah_lembur`,`stsjbtn`) values 
(1,'Direktur',7000,1000,1),
(2,'Manajer',6000,500,1),
(3,'Staff',2000,100,1),
(4,'CEOO',2000000,500006,0);

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `id_karyawan` int(11) NOT NULL AUTO_INCREMENT,
  `id_jabatan` int(11) NOT NULL,
  `nama_karyawan` varchar(50) NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` int(13) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal_lahir` varchar(8) NOT NULL,
  `jenis_kelamin` varchar(1) NOT NULL,
  `status` varchar(1) NOT NULL,
  `jml_anak` int(2) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `lvl` int(1) DEFAULT NULL,
  `sts` int(1) DEFAULT NULL,
  PRIMARY KEY (`id_karyawan`),
  KEY `id_jabatan` (`id_jabatan`),
  CONSTRAINT `karyawan_ibfk_1` FOREIGN KEY (`id_jabatan`) REFERENCES `jabatan` (`id_jabatan`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Data for the table `karyawan` */

insert  into `karyawan`(`id_karyawan`,`id_jabatan`,`nama_karyawan`,`alamat`,`no_hp`,`tempat_lahir`,`tanggal_lahir`,`jenis_kelamin`,`status`,`jml_anak`,`username`,`password`,`lvl`,`sts`) values 
(2,1,'Orang','Jauhhh',876543,'Mars','18012019','L','M',3,'orang','123',3,1),
(4,1,'QQQQ','asdads',123123,'asdeeee','09122020','L','N',0,'qwe','qew',3,1),
(5,1,'','',0,'','09012020','L','N',0,'','',3,0),
(6,1,'','',0,'','09012020','L','N',0,'','',3,0),
(7,2,'asdasd','',0,'','09012020','L','N',0,'','',3,0),
(8,2,'Mr. GG','sadasdasd',213123123,'Jauhhh','13012020','L','M',3,'gg','123',3,1),
(9,3,'Mr. Hanzz','asdasd',12321312,'Jauhh Sekakli','13012020','L','N',0,'hanz','123',3,0),
(10,2,'ASD','asdasda',123123,'DSA','13012020','L','M',5,'jjj','jjj',3,0),
(11,3,'SAYA','JAUHH SANGATT',3333,'JAUHHH','13012020','L','M',5,'saya','123',3,1),
(12,2,'sayalagi','ssss',222,'sss','07012020','P','N',7,'sayalagi','123',3,1),
(13,1,'apa','asdasdasd',213123,'sss','14012020','L','N',0,'ggg','123',3,1),
(14,1,'WWW','asdasdasdasd',123123123,'aaa','17012020','L','N',0,'www','123',3,1),
(15,1,'wwwQS','WWWq',121212,'wwwQ','17012020','L','N',0,'wwwQ','123',3,1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
