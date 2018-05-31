﻿
CREATE DATABASE AIRLINE
Drop database AIRLINE

use AIRLINE

SET DATEFORMAT DMY

-- BẢNG NGƯỜI DÙNG

CREATE TABLE NGUOIDUNG(
	TENNGUOIDUNG CHAR(20),
	MATKHAU CHAR(20),
	LOAINGUOIDUNG BIT, -- 0: ADMIN -- 1: USER
)

-- BẢNG SÂN BAY

CREATE TABLE SANBAY(
	MASANBAY CHAR(20) PRIMARY KEY,
	TENSANBAY CHAR(20),
	QUOCGIA CHAR(20),

)

-- BẢNG CHUYẾN BAY

CREATE TABLE CHUYENBAY (
	MACHUYENBAY INT PRIMARY KEY,
	GIAVE MONEY,
	SANBAYDI CHAR(20), 
	FOREIGN KEY(SANBAYDI) REFERENCES SANBAY(MASANBAY),
	SANBAYDEN CHAR(20), 
	FOREIGN KEY(SANBAYDEN) REFERENCES SANBAY(MASANBAY),
	NGAY DATE,
	GIO TIME,
	THOIGIANBAY INT, -- ĐƠN VỊ TÍNH LÀ PHÚT
	HANG1 INT, -- SỐ LƯỢNG GHẾ HẠNG 1
	HANG2 INT, -- SO LƯỢNG GHẾ HẠNG 2
	HANG1CONLAI INT, -- CÒN LẠI HẠNG 1
	HANG2CONLAI INT, -- CÒN LẠI HẠNG 2 
	--SANBAYTRUNGGIAN INT,
)

-- SÂN BAY TRUNG GIAN

CREATE TABLE SANBAYTRUNGGIAN(
	MATRUNGGIAN CHAR(20),
	MASANBAY CHAR(20),
	FOREIGN KEY(MASANBAY) REFERENCES SANBAY(MASANBAY),
	MACHUYENBAY INT,
	FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	THOIGIANDUNG INT, -- ĐƠN VỊ TÍNH BẰNG PHÚT
	PRIMARY KEY(MATRUNGGIAN, MASANBAY),
 )


-- BẢNG KHÁCH HÀNG

CREATE TABLE KHACHHANG(
	MAKHACHHANG INT PRIMARY KEY,
	HOTEN CHAR(50),
	GIOITINH BIT,
	CMND CHAR(10),
	SDT CHAR(11),
)

-- BẢNG VÉ

CREATE TABLE VE(
	MACHUYENBAY INT,
	FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	MAKHACHHANG INT,
	FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	HANGVE SMALLINT,
	GIAVE MONEY,
	PRIMARY KEY(MACHUYENBAY, MAKHACHHANG),
)
CREATE TABLE QUYDINH6(
SOLUONGSANBAY INT, 
THOIGIANBAYTOITHIEU INT, -- TINH BANG PHUT
SOSANBAYTRUNGGIANTOIDA INT,
THOOIGIANDUNGTOIDA INT,-- TINH BANG PHUT
THOIGIANDUNGTOITHIEU INT, -- TINH BANG PHUT
SOLUONGVEHANG1 INT,
SOLUONGVEHANG2 INT,
THOIGIANDATVECHAMNHAT INT, --TINH BANG NGAY
THOIGIANHUYDATVE INT, --TINH BANG NGAY
)
SELECT * FROM QUYDINH6
UPDATE DBO.QUYDINH6
SET SOLUONGSANBAY = 15

INSERT INTO QUYDINH6(SOLUONGSANBAY,THOIGIANBAYTOITHIEU,SOSANBAYTRUNGGIANTOIDA,THOOIGIANDUNGTOIDA,THOIGIANDUNGTOITHIEU,
SOLUONGVEHANG1,SOLUONGVEHANG2,THOIGIANDATVECHAMNHAT,THOIGIANHUYDATVE)
VALUES ('10','30','2','20','10','50','50','1','1')

SELECT * FROM QUYDINH6;
-- QUY ĐỊNH 1: CÓ 10 SÂN BAY, THỜI GIAN BAY TỐI THIỂU LÀ 30 PHÚT, MỖI CHUYẾN BAY CÓ TỐI ĐA 2 SÂN BAY TRUNG GIAN, THỜI GIAN DỪNG TỪ 10 ĐẾN 20 PHÚT

-- CÓ 10 SÂN BAY

CREATE TRIGGER SOLUONGSANBAY ON SANBAY  
	FOR INSERT 
	AS
		BEGIN
			DECLARE @SANBAY INT
			SELECT @SANBAY = COUNT(MASANBAY) FROM SANBAY
			DECLARE @MAXSANBAY INT 
			SELECT @MAXSANBAY = SOLUONGSANBAY FROM QUYDINH6
		    IF (@SANBAY >= @MAXSANBAY)
			BEGIN
				PRINT 'VUOT QUA SO LUONG SAN BAY TOI DA !'
				ROLLBACK TRAN
			END
		END

-- THỜI GIAN BAY TỐI THIỂU LÀ 30 PHÚT

CREATE TRIGGER THOIGIANBAY_MIN ON CHUYENBAY
	FOR INSERT, UPDATE 
	AS
		BEGIN
			DECLARE @THOIGIANBAY INT
			SELECT @THOIGIANBAY = THOIGIANBAY FROM INSERTED
			DECLARE @MINBAYTOITHIEU INT
			SELECT @MINBAYTOITHIEU =THOIGIANBAYTOITHIEU FROM QUYDINH6
			IF (@THOIGIANBAY < @MINBAYTOITHIEU)
				BEGIN
					PRINT 'THOI GIAN BAY TOI THIEU LA .... !'
					ROLLBACK TRAN
				END
		END

-- MỖI CHUYẾN BAY CÓ TỐI ĐA 2 SÂN BAN TRUNG GIAN

CREATE TRIGGER SANBAYTRUNGGIAN_MAX ON SANBAYTRUNGGIAN
	FOR INSERT, UPDATE  
	AS
		BEGIN
			DECLARE @SL INT
			DECLARE @MATRUNGGIAN INT
			SELECT @MATRUNGGIAN = MATRUNGGIAN FROM INSERTED
			SELECT @SL =  COUNT(MASANBAY) FROM SANBAYTRUNGGIAN WHERE MATRUNGGIAN = @MATRUNGGIAN
			IF (@SL >= 2)
				BEGIN
					PRINT 'SO LUONG SAN BAY TRUNG GIAN TOI DA LA 2'
					ROLLBACK TRAN
				END
		END

-- THỜI GIAN DỪNG TỪ 10 ĐẾN 20 PHÚT

CREATE TRIGGER THOIGIANDUNG_DOM ON SANBAYTRUNGGIAN
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @TG INT
			SELECT @TG = THOIGIANDUNG FROM INSERTED
			DECLARE @MINDUNG INT
			SELECT @MINDUNG = THOIGIANDUNGTOITHIEU FROM QUYDINH6
			DECLARE @MAXDUNG INT
			SELECT @MAXDUNG= THOOIGIANDUNGTOIDA FROM QUYDINH6
			IF (@TG <@MINDUNG OR @TG >@MAXDUNG)
			BEGIN
				PRINT 'THOI GIAN DUNG PHAI TU ... !'
				ROLLBACK TRAN
			END 
		END
		
-- QUY ĐỊNH 2: CHỈ BÁN VÉ KHI CÒN CHỖ. CÓ 2 HẠNG VÉ. VÉ HẠNG 1 BẰNG 105% ĐƠN GIÁ, VÉ HẠNG 2 BẰNG ĐƠN GIÁ, MỖI CHUYẾN BAY CÓ 1 GIÁ VÉ RIÊNG.

-- CHỈ BÁN VÉ KHI CÒN CHỖ

CREATE TRIGGER BANVE ON VE
	FOR INSERT , UPDATE 
	AS
		BEGIN
			DECLARE @MACHUYENBAY INT
			DECLARE @HANG1CONLAI INT
			DECLARE @HANG2CONLAI INT
			DECLARE @HANGVE SMALLINT
			SELECT @HANGVE =  HANGVE FROM INSERTED
			IF (@HANGVE = 1)
				BEGIN
					SELECT @HANG1CONLAI = HANG1CONLAI FROM CHUYENBAY WHERE MACHUYENBAY = @MACHUYENBAY	
					IF (@HANG1CONLAI = 0) 
						BEGIN
							PRINT 'HET VE HANG 1'
							ROLLBACK TRAN
						END
					ELSE 
						BEGIN
							UPDATE CHUYENBAY
							SET HANG1CONLAI = HANG1CONLAI - 1
						END
				END
			ELSE
			IF (@HANGVE = 2)
				BEGIN
					SELECT @HANG2CONLAI = HANG2CONLAI FROM CHUYENBAY WHERE MACHUYENBAY = @MACHUYENBAY

					IF (@HANG2CONLAI = 0) 
						BEGIN
							PRINT 'HET VE HANG 2'
							ROLLBACK TRAN
						END
					ELSE 
						BEGIN
							UPDATE CHUYENBAY
							SET HANG2CONLAI = HANG2CONLAI - 1
						END
				END
		END

-- VÉ HẠNG 1 BẰNG 105% ĐON GIÁ, HẠNG 2 BẰNG ĐƠN GIÁ

CREATE TRIGGER GIAVE  ON VE
	FOR INSERT, UPDATE
	AS
		BEGIN
			
			DECLARE @HANGVE SMALLINT
			DECLARE @MACHUYENBAY INT
			DECLARE @GIAGOC MONEY

			SELECT @HANGVE = HANGVE FROM INSERTED
			SELECT @MACHUYENBAY = MACHUYENBAY FROM INSERTED
			SELECT @GIAGOC = GIAVE FROM CHUYENBAY WHERE MACHUYENBAY = @MACHUYENBAY
			
			IF (@HANGVE = 1)
				BEGIN
					UPDATE VE
					SET GIAVE = @GIAGOC *1.05
				END
			ELSE
				BEGIN
					UPDATE VE
					SET GIAVE = @GIAGOC
				END	

		END
 
-- QUY ĐỊNH 3: KHÔNG ĐƯỢC ĐẶT VÉ TRONG NGÀY KHỞI HÀNH

CREATE TRIGGER HANCHOTDATVE ON VE
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @NGAYKHOIHANH DATE
			DECLARE @MACHUYENBAY INT
			DECLARE @NGAYDATVE DATE
			DECLARE @TEMP INT


			SELECT @MACHUYENBAY = MACHUYENBAY FROM INSERTED
			SELECT @NGAYKHOIHANH = NGAY FROM CHUYENBAY WHERE MACHUYENBAY = @MACHUYENBAY
			SELECT @NGAYDATVE = CURRENT_TIMESTAMP
			SELECT @TEMP = DATEDIFF(DAY,@NGAYDATVE,@NGAYKHOIHANH)
			DECLARE @THOIGIANDATVECHAMNHAT INT;
			SELECT @THOIGIANDATVECHAMNHAT= THOIGIANDATVECHAMNHAT FROM QUYDINH6

			IF (@TEMP < @THOIGIANDATVECHAMNHAT)
				BEGIN
					PRINT 'DA HET HAN DAT VE !'
					ROLLBACK TRAN
				END
		END


--TEST 
insert into SANBAY values ('HCM','HoChiMinh','VIETNAM')
insert into SANBAY values ('HN','HaNoi','VIETNAM')
insert into SANBAY values ('DN','DaNang','VIETNAM')
SELECT * FROM SANBAY


insert into CHUYENBAY values('1001','1500','HCM','HN','21/05/2018','10:00','90','15','15','15','15')
insert into CHUYENBAY values('1002','2000','HCM','HN','21/05/2018','11:30','90','15','15','15','15')
insert into CHUYENBAY values('1003','2500','HCM','HN','21/05/2018','12:00','90','15','15','15','15')
insert into CHUYENBAY values('1004','3000','HCM','DN','21/05/2018','12:30','90','15','15','15','15')
insert into CHUYENBAY values('1005','3500','HCM','DN','21/05/2018','13:00','90','15','15','15','15')
insert into CHUYENBAY values('1006','4000','HCM','DN','21/05/2018','13:30','90','15','15','15','15')

SELECT * FROM CHUYENBAY


           