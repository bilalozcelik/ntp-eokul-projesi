CREATE TABLE `eokul`.`ogrencinot` (
  `ogrenciNotId` INT NOT NULL AUTO_INCREMENT,
  `ogrenciNoFK` INT NOT NULL,
  `dersKoduFK` VARCHAR(4) NOT NULL,
  `yazili1` TINYINT NOT NULL,
  `yazili2` TINYINT NOT NULL,
  `yazili3` TINYINT NOT NULL,
  `uygulama1` TINYINT NOT NULL,
  `uygulama2` TINYINT NOT NULL,
  `sozlu1` TINYINT NOT NULL,
  `sozlu2` TINYINT NOT NULL,
  `ortalama` TINYINT NULL DEFAULT 0,
  PRIMARY KEY (`ogrenciNotId`));