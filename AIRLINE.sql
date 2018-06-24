﻿
CREATE DATABASE AIRLINE

use AIRLINE

SET DATEFORMAT DMY

-- BẢNG NGƯỜI DÙNG

CREATE TABLE NGUOIDUNG(
	MANGUOIDUNG CHAR(10) PRIMARY KEY,
	TENNGUOIDUNG CHAR(20),
	MATKHAU CHAR(20),
	LOAINGUOIDUNG BIT, -- 0: ADMIN -- 1: USER
	HOTEN CHAR(50)
)

-- BẢNG SÂN BAY

CREATE TABLE SANBAY(
	MASANBAY CHAR(10) PRIMARY KEY,
	TENSANBAY NVARCHAR(30),
	TINH NVARCHAR(30),
	QUOCGIA NVARCHAR(30),
)

-- BẢNG CHUYẾN BAY

CREATE TABLE CHUYENBAY (
	MACHUYENBAY CHAR(10) PRIMARY KEY,
	GIAVEHANG1 MONEY,
	GIAVEHANG2 MONEY,
	SANBAYDI CHAR(10), 
	FOREIGN KEY(SANBAYDI) REFERENCES SANBAY(MASANBAY),
	SANBAYDEN CHAR(10), 
	FOREIGN KEY(SANBAYDEN) REFERENCES SANBAY(MASANBAY),
	NGAY DATE,
	GIO TIME,
	THOIGIANBAY INT, -- ĐƠN VỊ TÍNH LÀ PHÚT
	HANG1 INT, -- SỐ LƯỢNG GHẾ HẠNG 1
	HANG2 INT, -- SO LƯỢNG GHẾ HẠNG 2
	HANG1CONLAI INT, -- CÒN LẠI HẠNG 1
	HANG2CONLAI INT, -- CÒN LẠI HẠNG 2
)

-- SÂN BAY TRUNG GIAN

CREATE TABLE SANBAYTRUNGGIAN (
	MASANBAY CHAR(10),
	FOREIGN KEY(MASANBAY) REFERENCES SANBAY(MASANBAY),
	MACHUYENBAY CHAR(10),
	FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	THOIGIANDUNG INT, -- ĐƠN VỊ TÍNH BẰNG PHÚT
	PRIMARY KEY(MACHUYENBAY, MASANBAY),
)

-- BẢNG KHÁCH HÀNG

CREATE TABLE KHACHHANG(
	MAKHACHHANG CHAR(10) PRIMARY KEY,
	HOTEN NVARCHAR(30),
	GIOITINH BIT,
	SDT CHAR(11),
	DIACHI NVARCHAR(30),
	CMND CHAR(10),
	EMAIL CHAR(30)
)

-- BẢNG VÉ

CREATE TABLE VE(
	MAVE CHAR(10) PRIMARY KEY,
	MACHUYENBAY CHAR(10),
	FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	MAKHACHHANG CHAR(10),
	FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	HANGVE SMALLINT,
	GIAVE MONEY
)

-- BẢNG DOANH THU

CREATE TABLE DOANHTHU(
	THANG SMALLINT,
	NAM SMALLINT,
	DOANHTHU MONEY,
)

-- TRIGGER THÁNG NĂM DOANH THU

CREATE TRIGGER THANGNAM ON DOANHTHU
	FOR INSERT,UPDATE
	AS
		BEGIN
			DECLARE @THANG SMALLINT;
			DECLARE @NAM SMALLINT;
			SELECT @THANG = THANG FROM INSERTED
			SELECT @NAM = NAM FROM INSERTED
			IF (@THANG >12 OR @THANG < 1 OR @NAM <2015)
				BEGIN
					PRINT 'THANG NAM KHONG HOP LE !'
					ROLLBACK TRAN
				END
		END

-- THAM SỐ CÁC QUY ĐỊNH

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

--SELECT * FROM QUYDINH6

INSERT INTO QUYDINH6(SOLUONGSANBAY,THOIGIANBAYTOITHIEU,SOSANBAYTRUNGGIANTOIDA,THOOIGIANDUNGTOIDA,THOIGIANDUNGTOITHIEU,
SOLUONGVEHANG1,SOLUONGVEHANG2,THOIGIANDATVECHAMNHAT,THOIGIANHUYDATVE)
VALUES ('10','30','2','20','10','50','50','1','1')



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
			DECLARE @SL SMALLINT
			DECLARE @MACHUYENBAY CHAR(10)
			DECLARE @MAX INT
			SELECT @MAX = SOSANBAYTRUNGGIANTOIDA FROM QUYDINH6
			SELECT @MACHUYENBAY = MACHUYENBAY FROM INSERTED
			SELECT @SL =  COUNT(MASANBAY) FROM SANBAYTRUNGGIAN WHERE MACHUYENBAY = @MACHUYENBAY
			IF (@SL = @MAX)
				BEGIN
					PRINT 'SO LUONG SAN BAY TRUNG GIAN TOI DA LA ' + @MAX
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
			DECLARE @MACHUYENBAY CHAR(10)
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

CREATE TRIGGER GIAVE ON CHUYENBAY
	FOR INSERT, UPDATE
	AS
		BEGIN					
			DECLARE @GIAVEHANG1 MONEY
			DECLARE @GIAVEHANG2 MONEY
			

			SELECT @GIAVEHANG1 = GIAVEHANG1 FROM INSERTED
			SELECT @GIAVEHANG2 = GIAVEHANG2 FROM INSERTED
			IF (@GIAVEHANG1 != @GIAVEHANG2*1.05)
				BEGIN
					PRINT 'GIA VE HANG 1 PHAI BANG 105% GIA VE HANG 2'
					ROLLBACK TRAN
				END
		END
 
-- QUY ĐỊNH 3: KHÔNG ĐƯỢC ĐẶT VÉ TRONG NGÀY KHỞI HÀNH

CREATE TRIGGER HANCHOTDATVE ON VE
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @NGAYKHOIHANH DATE
			DECLARE @MACHUYENBAY CHAR(10)
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


           