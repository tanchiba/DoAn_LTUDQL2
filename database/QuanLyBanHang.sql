USE MASTER
GO
-----------------------------
IF DB_ID('QuanLyBanHang') IS NOT NULL
	DROP DATABASE QuanLyBanHang
GO
CREATE DATABASE QuanLyBanHang 
GO
use QuanLyBanHang
GO

------------------------------
--
-- Table SYS_GROUP
--

CREATE TABLE SYS_GROUP(
	Group_ID varchar(20) NOT NULL,
	GroupName nvarchar(100) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
	CONSTRAINT PK_SYS_GROUP PRIMARY KEY (Group_ID)
)

--
-- Nhap lieu SYS_GROUP
--

INSERT INTO SYS_GROUP (Group_ID, GroupName, Description, Active) VALUES 
(N'admin', N'Quản Trị Hệ Thống', NULL, 1),
(N'user', N'Quản Trị Mua bán hàng ', NULL, 1);

-- -------------------------------------------------------------------
--
-- Table SYS_LOG
--

CREATE TABLE SYS_LOG(
	Log_ID int NOT NULL,
	IP varchar(20) NULL,
	User_ID int NULL,
	Created datetime NULL,
	Module nvarchar(255) NULL,
	Action_Name nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
	CONSTRAINT PK_SYS_LOG PRIMARY KEY (Log_ID)
)

--
-- Nhap lieu SYS_LOG
--

INSERT INTO SYS_LOG(Log_ID, IP, User_ID, Created, Module, Action_Name, Description, Active) VALUES
(1, 'E6420-PC', 1, '2017-5-21 00:00:00', N'Quản trị hệ thống', N'Xem', NULL, 1),
(2, 'E6420-PC', 1, '2017-2-2 00:00:00', N'Quản trị hệ thống', N'Đăng nhập', NULL, 1),
(3, 'E6420-PC', 1, '2017-5-23 00:00:00', N'Quản trị hệ thống', N'Xem', NULL, 1)

-- -------------------------------------------------------------------
--
-- Table SYS_USER
--

CREATE TABLE SYS_USER(
	User_ID int NOT NULL,
	UserName nvarchar(50) NOT NULL,
	Password varchar(50) NULL,
	FullName nvarchar(50) NULL,
	Group_ID varchar(20) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_SYS_USER PRIMARY KEY (User_ID)
)

--
-- Nhap lieu SYS_USER
--

INSERT INTO SYS_USER (User_ID, UserName, Password,FullName, Group_ID, Description, Active) VALUES 
(1, N'CongToan', N'toan123456', N'Trần Công Toản', N'admin', NULL, 1),
(2, N'HoangTu', N'tu123456', N'Trần Hoàng Tú', N'user', NULL, 1),
(3, N'AnVu', N'anvu123',N'Vũ Thiện Ân', N'admin', NULL, 1),
(4, N'LocHuynh', N'loc123@', N'Huỳnh Tấn Lộc', N'user', NULL, 1),
(5, N'Chi', N'hachi123', N'Hà Thị Mỹ Chi', N'user', NULL, 1);

-- ------------------------------------------------------------------------------
--
-- Table SYS_OBJECT
--

CREATE TABLE SYS_OBJECT(
	Object_ID int NOT NULL,
	ObjectName nvarchar(50) NULL,
	Description nvarchar(255) NULL,
	Parent_ID int NULL,
	Active bit NULL,
 CONSTRAINT PK_SYS_OBJECT PRIMARY KEY (Object_ID)
)

--
-- Nhap lieu SYS_OBJECT
--

INSERT INTO SYS_OBJECT (Object_ID, ObjectName, Description, Parent_ID, Active) VALUES 
(1, N'Hệ Thống', NULL, NULL, 1),
(2, N'Danh Mục', NULL, NULL, 1),
(3, N'Chức Năng', NULL, NULL, 1),
(4, N'Hệ Thống', NULL, 1, 1),
(5, N'Bảo Mật', NULL, 1, 1),
(6, N'Dữ Liệu', NULL, 1, 1),
(7, N'Đối Tác', NULL, 2, 1),
(8, N'Kho Hàng', NULL, 2, 1),
(9, N'Bộ Phận', NULL, 2, 1),
(10, N'Bán Hàng', NULL, 3, 1),
(11, N'Công Nợ', NULL, 3, 1),
(12, N'Kho Hàng', NULL, 3, 1),
(13, N'Tiện Ích', NULL, 3, 1),
(14, N'Hóa Đơn', NULL, 3, 1),
(15, N'Báo Cáo', NULL, 3, 1),
(16, N'Công Cụ', NULL, 3, 1),
(17, N'Đơn Vị', NULL, 4, 1),
(18, N'Quản Lý Phân Quyền', NULL, 5, 1),
(19, N'Đổi Mật Khẩu', NULL, 5, 1),
(20, N'Nhật Ký Hệ Thống', NULL, 5, 1),
(21, N'Sao Lưu', NULL, 6, 1),
(22, N'Phục Hồi', NULL, 6, 1),
(23, N'Sửa Chữa', NULL, 6, 1),
(24, N'Kết Chuyển', NULL, 6, 1),
(25, N'Khu Vực', NULL, 7, 1),
(26, N'Khách Hàng', NULL, 7, 1),
(27, N'Nhà Phân Phối', NULL, 7, 1),
(28, N'Kho', NULL, 8, 1),
(29, N'Đơn Vị', NULL, 8, 1),
(30, N'Nhóm Hàng', NULL, 8, 1),
(31, N'Hàng Hóa', NULL, 8, 1),
(32, N'In Mã Vạch', NULL, 8, 1),
(33, N'Tỷ Giá', NULL, 8, 1),
(34, N'Quy Đổi Đơn Vị', NULL, 8, 1),
(35, N'Bộ Phận', NULL, 9, 1),
(36, N'Nhân Viên', NULL, 9, 1),
(37, N'Mua Hàng', NULL, 10, 1),
(38, N'Bán Hàng', NULL, 10, 1),
(39, N'Xuất Trả Hàng', NULL, 10, 1),
(40, N'Nhập Trả Hàng', NULL, 10, 1),
(41, N'Thu Tiền', NULL, 11, 1),
(42, N'Trả Tiền', NULL, 11, 1),
(43, N'Nhập Kho', NULL, 12, 1),
(44, N'Xuất Kho', NULL, 12, 1),
(45, N'Tồn Kho', NULL, 12, 1),
(46, N'Đóng Gói', NULL, 13, 1),
(47, N'Kiểm Kê', NULL, 13, 1),
(48, N'Chuyển Kho', NULL, 13, 1),
(49, N'Tổng Hợp Tồn Kho', NULL, 13, 1),
(50, N'Hóa Đơn', NULL, 14, 1),
(51, N'Quản Lý Chứng Từ', NULL, 14, 1),
(52, N'Báo Cáo Kho', NULL, 15, 1), 
(53, N'Doanh Thu Bán Hàng', NULL, 15, 1),
(54, N'Hạn Sử Dụng', NULL, 15, 1),
(55, N'Đặt Hàng', NULL, 16, 1),
(56, N'Nhập số dư ban đầu', NULL, 16, 1),
(57, N'Lịch Sử Hàng Hóa', NULL, 16, 1),
(58, N'Quản Lý Người Dùng', NULL, 18, 1),
(59, N'Vai Trò và Quyền Hạn', NULL, 18, 1)


-- -----------------------------------------------------------------------
--
-- Table SYS_RULE
--

CREATE TABLE SYS_RULE(
	Rule_ID varchar(20) NOT NULL,
	RuleName nvarchar(100) NULL,
	Descrition nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_SYS_RULE PRIMARY KEY (Rule_ID)
)

--
-- Nhap lieu SYS_RULE
--

INSERT INTO SYS_RULE (Rule_ID, RuleName, Descrition, Active) VALUES
(N'RL00001', N'Thêm', NULL, 1),
(N'RL00002', N'Sửa', NULL, 1),
(N'RL00003', N'Xóa', NULL, 1),
(N'RL00004', N'In', NULL, 1),
(N'RL00005', N'Nhập Khẩu', NULL, 1),
(N'RL00006', N'Xuất Xuất', NULL, 1),
(N'RL00007', N'Tất Cả', NULL, 1),
(N'RL00008', N'Gửi', NULL, 1),
(N'RL00009', N'Báo cáo', NULL, 1),
(N'RL00010', N'Xem', NULL, 1),
(N'RL00011', N'Tìm kiếm', NULL, 1);



-- ------------------------------------------------------------------------------
--
-- Table SYS_USE_RULE
--

CREATE TABLE SYS_USER_RULE(
	Group_ID varchar(20) NOT NULL,
	Object_ID int NOT NULL,
	Rule_ID varchar(20) NOT NULL,
	AllowAdd bit NULL,
	AllowDelete bit NULL,
	AllowEdit bit NULL,
	AllowAccess bit NULL,
	AllowPrint bit NULL,
	AllowExport bit NULL,
	AllowImport bit NULL,
	Active bit NULL,
 CONSTRAINT PK_SYS_USER_RULE PRIMARY KEY (Group_ID, Object_ID)
)


--
-- Nhap lieu SYS_USER_RULE
--

INSERT INTO SYS_USER_RULE (Group_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active) VALUES 
(N'admin', 1, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 2, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 3, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 4, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 5, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 6, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 7, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 8, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 9, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 10, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 11, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 12, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 13, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 14, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 15, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 16, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 17, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 18, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 19, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 20, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 21, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 22, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 23, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 24, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 25, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 26, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 27, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 28, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 29, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 30, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 31, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 32, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 33, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 34, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 35, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 36, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 37, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 38, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 39, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 40, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 41, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 42, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 43, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 44, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 45, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 46, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 47, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 48, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 49, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 50, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 51, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 52, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 53, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 54, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 55, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 56, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 57, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 58, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1),
(N'admin', 59, N'RL000010', 1, 1, 1, 1, 1, 1, 1, 1);



-- ---------------------------------------------------------------------------------
--
-- Table CURRENCY
--

CREATE TABLE CURRENCY(
	Currency_ID varchar(3) NOT NULL,
	CurrencyName nvarchar(50) NULL,
	Exchange money NULL,
	Active bit NULL,
 CONSTRAINT PK_CURRENCY PRIMARY KEY (Currency_ID)
)


--
-- Nhap lieu CURRENCY
--
INSERT INTO CURRENCY (Currency_ID, CurrencyName, Exchange, Active) VALUES 
(N'CNY', N'Nhân dân tệ', 100.0000, 1),
(N'EUR', N'Euro', 18000.0000, 1),
(N'KRW', N'Won Hàn Quốc', 17000.0000, 1),
(N'USA', N'Đô la Mỹ', 22000.0000, 1),
(N'VND', N'Việt Nam Đồng', 1.0000, 1),
(N'RMB', N'Nhân dân tệ', 15000, 1),
(N'JPY', N'Đồng Yên Nhật', 22000, 1);

-- ------------------------------------------------------------------
--
-- Table CUSTOMER_TYPE
--

CREATE TABLE CUSTOMER_TYPE(
	Customer_Type_ID varchar(20) NOT NULL,
	Customer_Type_Name nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_CUSTOMER_TYPE PRIMARY KEY (Customer_Type_ID)
)

--
-- Nhap lieu CUSTOMER_TYPE
--

INSERT INTO CUSTOMER_TYPE (Customer_Type_ID, Customer_Type_Name, Description, Active) VALUES 
(N'KHHM', N'Khách hàng hỏi mua', NULL, 1),
(N'KHTN', N'Khách hàng tiềm năng', NULL, 1),
(N'KHTX', N'Khách hàng thường xuyên', NULL, 1),
(N'KHVL', N'Khách hàng vãng lai', NULL, 1);

-- -------------------------------------------------------------------------
--
-- Table CUSTOMER_GROUP
--

CREATE TABLE CUSTOMER_GROUP(
	Customer_Group_ID varchar(20) NOT NULL,
	Customer_Group_Name nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_CUSTOMER_GROUP PRIMARY KEY (Customer_Group_ID) 
)

--
-- Nhap lieu CUSTOMER_GROUP
--

INSERT INTO CUSTOMER_GROUP (Customer_Group_ID, Customer_Group_Name, Description, Active) VALUES 
(N'KV00001', N'Miền Nam', N'', 1),
(N'KV00002', N'Miền Bắc', N'', 1),
(N'KV00003', N'Miền Trung', N'', 1);

-- ------------------------------------------------------------------
--
-- Table CUSTOMER
--

CREATE TABLE CUSTOMER(
	Customer_ID varchar(20) NOT NULL,
	CustomerName nvarchar(255) NULL,
	Customer_Type_ID varchar(20) NULL,
	Customer_Group_ID varchar(20) NULL,
	CustomerAddress nvarchar(255) NULL,
	Tel varchar(20) NULL,
	Email varchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_CUSTOMER PRIMARY KEY (Customer_ID) 
)

--
-- Nhap lieu CUSTOMER
--

INSERT INTO CUSTOMER (Customer_ID, CustomerName, Customer_Type_ID, Customer_Group_ID, CustomerAddress, Tel, Email, Active) VALUES 
(N'KH00001', N'Công ty Quang Phúc', N'KHHM', N'KV00001', N'Số 39 Ngõ 176,Phố Lê Trọng Tấn,Thanh Xuân, HN', N'0904544396', N'namvu@namtien.vn', 1),
(N'KH00002', N'Anh Thông', N'KHTN', N'KV00002', N'379 Đỗ Xuân Hợp, P. Phước Long B, Q.9 , HCM', N'0903820117', N'dangkhoa@yahoo.com', 1),
(N'KH00003', N'Anh Vũ KH', N'KHTX', N'KV00003', N'35 Nguyễn Huệ, Q1, HCM', N'0903708178', N'tuyetco@hanmail.net', 1),
(N'KH00004', N'Anh Kiên', N'KHVL', N'KV00001', N'số 30 đường số 5, P.11,   quận 6, HCM', N'0913157340', N'thangle@lsi.com.vn', 1),
(N'KH00005', N'Anh Khoa KH lẻ', N'KHTX', N'KV00003', N'Daklak', N'0987270862', N'dangkhoa@yahoo.com', 1),
(N'KH00006', N'Anh Tri - cty Hoàng Nguyên', N'KHTN', N'KV00001', N'Tòa nhà Hoàng Anh Gia Lai', N'0909728681', N'tri.le@hagl.com.vn', 1),
(N'KH00007', N'Anh Tuấn - cty TNHH MTV Kamera', N'KHTX', N'KV00002', N'A24 đường số 46, P5, Q4, HCM', N'0918646849', N'chan.pham@digitalking.com.vn', 1),
(N'KH00008', N'Trung Kiên - cty Thiên Nhiên Xanh', N'KHTX', N'KV00002', N'36/15 Trần Hưng Đạo, Q5, HCM', N'0903737790', N'thiennhienxanhcopany@gmail.com', 1),
(N'KH00009', N'Chị NeVa - KH lẻ', N'KHVL', N'KV00003', N'Tân Phong , Quận 7', N'01234528785', N'nevadang@yahoo.com', 1),
(N'KH00010', N'Anh Hiệp -Công ty F5', N'KHHM', N'KV00001', N'Số 4 Ngách 554/1 Trường Chinh, Đống Đa, Hà Nộ', N'0914048944', N'f5_kd08hn@yahoo.com', 1);

-- ---------------------------------------------------------------------------
--
-- Table DEPARTMENT
--

CREATE TABLE DEPARTMENT(
	Department_ID varchar(20) NOT NULL,
	DepartmentName nvarchar(255) NOT NULL,
	Description nvarchar(255) NULL,
	Active bit NOT NULL,
 CONSTRAINT PK_DEPARTMENT PRIMARY KEY (Department_ID)
)

--
-- Nhap lieu DEPARMENT
--

INSERT INTO DEPARTMENT (Department_ID, DepartmentName, Description, Active) VALUES 
(N'GD', N'Giám Đốc', NULL, 1),
(N'KD', N'Phòng Kinh Doanh', NULL, 1),
(N'KT', N'Phòng Kế Toán', NULL, 1),
(N'KTH', N'Phòng Kỹ Thuật', NULL, 1),
(N'NS', N'Phòng Nhân Sự', NULL, 1);


-- ----------------------------------------------------------------------------
--
-- Table EMPLOYEE
--

CREATE TABLE EMPLOYEE(
	Employee_ID varchar(20) NOT NULL,
	EmployeeName nvarchar(255) NULL,
	EmployeeAddress nvarchar(255) NULL,
	Tel varchar(20) NULL,
	Email varchar(20) NULL,
	Birthday datetime NULL,
	Position nvarchar(255) NULL,
	Department_ID varchar(20) NULL,
	Manager_ID varchar(20) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_Employee PRIMARY KEY (Employee_ID) 
)

--
-- Nhap lieu EMPLOYEE
--

INSERT INTO EMPLOYEE (Employee_ID, EmployeeName, EmployeeAddress, Tel, Email, Birthday, Position, Department_ID, Manager_ID, Description, Active) VALUES 
(N'NV000001', N'Nguyễn Thị Minh  Huệ', N'561 cmt8', N'0946 980 408', N'minhhue@gmail.com', CAST(0x000089F900000000 AS DateTime), N'Nhân Viên', N'NS', N'NV000002', NULL, 1),
(N'NV000002', N'Phan Quang Thông', N'23 3/2', N'093478283', N'quangthong@gmail.com', CAST(0x000089F900000000 AS DateTime), N'Giám Đốc', N'GD', NULL, NULL, 1),
(N'NV000003', N'Nguyễn Hoàng Dũng', N'lầu 5 bitexco', N'0946 980 408', N'hoangdung@gmail.com', CAST(0x000089F900000000 AS DateTime), N'Kỹ Thuật Viên', N'KTH', N'NV000002', NULL, 1),
(N'NV000004', N'Vũ Anh Tuấn', N'231 nguyễn đình chiểu', N'0923423878', N'anhtuan@gmail.com', CAST(0x000089F900000000 AS DateTime), N'Kế Toán Viên', N'KT', N'NV000002', NULL, 1),
(N'NV000005', N'Huỳnh Thị Ngọc Lãnh', N'232 Điện Biên Phủ', N'0923432764', N'ngoclanh@gmail.com', CAST(0x000089F900000000 AS DateTime), N'Kiểm Dịch Viên', N'KD', N'NV000002', NULL, 1);

-- -------------------------------------------------------------------
--
-- Table PRODUCT
--

CREATE TABLE PRODUCT(
	Product_ID varchar(20) NOT NULL,
	ProductName nvarchar(255) NULL,
	Product_Type_ID varchar(20) NULL,
	Product_Group_ID varchar(20) NULL,
	Prorvider_ID varchar(20) NULL,
	Unit varchar(20) NULL,
	Org_Price money NULL,
	Sale_Price money NULL,
	Retail_Price money NULL,
	Quantity int NULL,
	MinStock int NULL,
	MaxStock int NULL,
	Photo image NULL,
	Currency_ID varchar(3) NULL,
	User_ID int NULL,
	Stock_ID varchar(20) NULL,
	Active bit NULL,
 CONSTRAINT PK_PRODUCT PRIMARY KEY (Product_ID)
)

--
-- Nhap lieu PRODUCT
--

INSERT INTO PRODUCT (Product_ID, ProductName, Product_Type_ID, Product_Group_ID, Prorvider_ID, Unit, Org_Price, Sale_Price, Retail_Price, Quantity, MinStock, MaxStock, Photo, Currency_ID, User_ID, Stock_ID, Active) VALUES 
(N'SMP00001', N'SamSung Galaxy S8', 0, N'SMP', N'NCC00002', N'DV00001', 1000.0000, 500.0000, 1200.0000,3, 0, 0, NULL, N'VND', 1, NULL, 1),
(N'SMP00002', N'OPPO FS1', 0, N'SMP', N'NCC00002', N'DV00001', 800.0000, 400.0000, 1000.0000,2, 0, 0, NULL, N'VND', 1, NULL, 1),
(N'LAP00001', N'Dell', 0, N'LAP', N'NCC00003', N'DV00001', 10000.0000, 8000.0000, 12000.0000, 2, 0, 0, NULL, N'VND', 1, NULL, 1),
(N'BOOK001', N'Harry Potter',0, N'BOOK', N'NCC00001', N'DV00003', 9000.0000, 7000.0000, 11000.0000, 2, 0, 0, NULL, N'VND', 2, NULL, 1),
(N'BOOK002', N'Cô gái đến từ hôm qua',0, N'BOOK', N'NCC00001', N'DV00003', 20000.0000, 18000.0000, 22000.0000,1, 0, 0, NULL, N'VND', 2, NULL, 1),
(N'QA00001', N'Áo Thun CASATA', 0, N'QA', N'NCC00005', N'DV00010', 120000.0000, 110000.0000, 130000.0000, 2,0, 0, NULL, N'VND', 1, NULL, 1),
(N'MILK001', N'Sữa Thanh trùng có đường VinaMilk',0, N'MILK', N'NCC00001', N'DV00005', 80000.0000, 70000.0000, 90000.0000, 1, 0, 0, NULL, N'VND', 1, NULL, 1),
(N'MILK002', N'Sữa chua có đường THTrue Milk', 0, N'MILK', N'NCC00002', N'DV00005', 40000.0000, 35000.0000, 35000.0000, 1, 0, 0, NULL, N'VND', 2, NULL, 1),
(N'SMP00003', N'SamSung Galaxy Note 7', 0, N'SMP', N'NCC00002', N'DV00001', 200000.0000, 190000.0000, 210000.0000, 2, 0, 0, NULL, N'VND', 3, NULL, 1),
(N'SMP00004', N'Iphone 7 Plus', 0, N'SMP', N'NCC00002', N'DV00001', 35000.0000, 30000.0000, 40000.0000, 3, 0, 0, NULL, N'VND', 3, NULL, 1);


-- -------------------------------------------------------------------
--
-- Table PRODUCT_GROUP
--

CREATE TABLE PRODUCT_GROUP(
	Product_Group_ID varchar(20) NOT NULL,
	Product_Group_Name nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_PRODUCT_GROUP PRIMARY KEY (Product_Group_ID) 
)

--
-- Nhap lieu PRODUCT_GROUP
--

INSERT PRODUCT_GROUP (Product_Group_ID, Product_Group_Name, Description, Active) VALUES 
(N'SMP', N'SmartPhone', NULL, 1),
(N'LAP', N'Laptop', NULL, 1),
(N'BOOK', N'Sách', NULL, 1),
(N'QA', N'Quần áo', NULL, 1),
(N'MILK', N'Sữa', NULL, 1);


-- --------------------------------------------------------------------
--
-- Table PROVIDER
--

CREATE TABLE PROVIDER(
	Provider_ID varchar(20) NOT NULL,
	ProviderName nvarchar(255) NULL,
	Customer_Group_ID varchar(20) NOT NULL,
	ProviderAddress nvarchar(255) NULL,
	Tel varchar(20) NULL,
	Email varchar(20) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
 CONSTRAINT PK_PROVIDER PRIMARY KEY (Provider_ID)
)

--
-- Nhap lieu PROVIDER
--

INSERT INTO PROVIDER (Provider_ID, ProviderName, Customer_Group_ID, ProviderAddress, Tel, Email, Description, Active) VALUES 
(N'NCC00001', N'Công Ty Công Tín', N'KV00001', N'27/3 Kinh Dương Vương, P12, Q6, TPHCM', N'0822300043', NULL, NULL, 1),
(N'NCC00002', N'Công ty CP Thế Giới Di Động', N'KV00001', NULL, NULL, NULL, NULL, 1),
(N'NCC00003', N'Linh kiện vi tính Tân Phát', N'KV00002', NULL, NULL, NULL, NULL, 1),
(N'NCC00004', N'Công ty TNHH TM Phát triển Kỹ Thuật', N'KV00003', N'168B Nguyễn Cư Trinh, P. Nguyễn Cư Trinh, Q.1, TP.HCM', NULL, NULL, NULL, 1),
(N'NCC00005', N'Công ty Kim Đạt', N'KV00003', NULL, NULL, NULL, NULL, 1);

-- -------------------------------------------------------------------
--
-- Table UNIT
--

CREATE TABLE UNIT(
	Unit_ID varchar(20)NOT NULL,
	UnitName nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
	CONSTRAINT pk_UNIT PRIMARY KEY (Unit_ID)
)

-- 
-- Nhap lieu UNIT
--

INSERT INTO UNIT(Unit_ID, UnitName, Description, Active) VALUES
('DV00001', N'Chiếc', NULL, 1),
('DV00002', N'Cái', NULL, 1),
('DV00003', N'Quyển', NULL, 1),
('DV00004', N'Cuộn', NULL, 1),
('DV00005', N'Thùng', NULL, 1),
('DV00006', N'Hộp', NULL, 1),
('DV00007', N'Xấp', NULL, 1),
('DV00008', N'Lít', NULL, 1),
('DV00009', N'Gói', NULL, 1),
('DV00010', N'Bộ', NULL, 1);

-- -------------------------------------------------------------------
--
-- Table STOCK
--

CREATE TABLE STOCK(
	Stock_ID varchar(20) NOT NULL,
	StockName nvarchar(255) NULL,
	StockAddress nvarchar(255) NULL,
	Email nvarchar(50) NULL,
	Tel nvarchar(50) NULL,
	Description nvarchar(255) NULL, 
	Active bit NULL,
	CONSTRAINT pk_STOCK PRIMARY KEY (Stock_ID)
)

--
-- Nhap lieu STOCK
--

INSERT INTO STOCK(Stock_ID, StockName, StockAddress, Email, Tel, Description, Active) VALUES
(N'K00001', N'Kho công ty', N'112/36 Quang Trung, Q.Gò Vấp', N'123@gmail.com', N'0897645362', NULL, 1 ),
(N'K00002', N'Kho 3 quận 7', N'325 Nguyễn Văn Linh, Q.7', N'nvlinh@gmail.com', N'089745632', NULL, 1),
(N'K00003', N'Kho 2 CMT8', N'212 Cách Mạng Tháng 8', N'cmt8@gmail.com', N'089325673', NULL, 1);

-- -------------------------------------------------------------------
--
-- Table SYS_COMPANY
--

CREATE TABLE SYS_COMPANY(
	Company_ID int NOT NULL,
	CompanyName nvarchar(255) NULL,
	CompanyAddress nvarchar(255) NULL,
	Tel varchar(50) NULL,
	Fax varchar(50) NULL,
	Website varchar(50) NULL,
	Email varchar(50) NULL,
	Photo image NULL,
	CONSTRAINT pk_SYS_COMPANY PRIMARY KEY (Company_ID)
)

-- 
-- Nhap lieu SYS_COMPANY
--

INSERT INTO SYS_COMPANY(Company_ID, CompanyName, CompanyAddress, Tel, Fax, Website, Email, Photo) VALUES
(1, N'Công ty TNHH Thực phẩm Việt Nam', N'208 Điện Biên Phủ', '084938762', '084953442', 'vinafood.vn.com', 'vinafood@vinafood.vn', NULL);

-- -------------------------------------------------------------------
--
-- Table MESSAGE
--

CREATE TABLE MESSAGE(
	Message_ID varchar(20) NOT NULL,
	Caption nvarchar(255) NULL,
	Description nvarchar(255) NULL,
	Active bit NULL,
	CONSTRAINT pk_MESSAGE PRIMARY KEY (Message_ID)
)

--
-- Nhap lieu MESSAGE
--

INSERT INTO MESSAGE(Message_ID, Caption, Description, Active) VALUES
(N'meDelete', N'Bạn có muốn xóa không?', NULL, NULL),
(N'meEmpty', N'Ô này không được rỗng', NULL, NULL),
(N'meDuplicate', N'Mã này đã tồn tại', NULL, NULL),
(N'meStockInward', N'Vui lòng chọn kho!', NULL, NULL),
(N'meProvider', N'Vui lòng chọn nhà phân phối', NULL, NULL),
(N'meProduct', N'Phiếu này rỗng, không thể lưu!', NULL, NULL),
(N'meCustomerOutward', N'Vui lòng chọn khách hàng', NULL, NULL),
(N'meEmployee', N'Vui lòng chọn người thực hiện', NULL, NULL),
(N'mBuilOver', N'Số lượng hàng trong kho không đủ!', NULL, NULL);

-- -------------------------------------------------------------------
--
-- Table CASH_METHOD
--

CREATE TABLE CASH_METHOD (
	ID varchar(20) NOT NULL,
	Name nvarchar(255)NULL,
	Active bit NULL,
	CONSTRAINT pk_CASH_METHOD PRIMARY KEY (ID)
)

--
-- Nhap lieu CASH_METHOD
--

INSERT INTO CASH_METHOD (ID, Name, Active) VALUES
(N'TM', N'Tiền mặt', 1),
(N'CK', N'Chuyển khoản', 1);

-- ------------------------------------------------------------

-- 
-- Table CASH_TERM
--

CREATE TABLE CASH_TERM(
	ID varchar(20) NOT NULL,
	Name nvarchar(255) NULL,
	Active bit NULL,
	CONSTRAINT pk_CASH_TERM PRIMARY KEY (ID)
)

--
-- Nhap lieu CASH_TERM
--

INSERT INTO CASH_TERM(ID, Name, Active) VALUES
(N'CN', N'Công nợ', 1),
(N'TTN', N'Thanh toán ngay', 1);

-- -------------------------------------------------------------

--
-- Table INVENTORY_ACTION
-- 

CREATE TABLE INVENTORY_ACTION(
	Action_ID int NOT NULL,
	ActionName nvarchar(255) NULL,
	CONSTRAINT pk_INVENTORY_ACTION PRIMARY KEY (Action_ID)
)

--
-- Nhap lieu INVENTORY_ACTION
--

INSERT INTO INVENTORY_ACTION(Action_ID, ActionName) VALUES
(1, N'Đầu kỳ'),
(2, N'Nhập kho'),
(3, N'Xuất kho'),
(4, N'Xuất lắp'),
(5, N'Nhập lắp'),
(6, N'Kiểm kê'),
(7, N'Xuất chuyển'),
(8, N'Nhập chuyển'),
(9, N'Xuất lắp ráp'),
(10,N'Nhập lắp ráp');

-- ----------------------------------------------------------------

--
-- Table REPORT
--

CREATE TABLE REPORT(
	Report_ID varchar(20) NOT NULL,
	ReportName nvarchar(255) NULL,
	Title nvarchar(255) NULL,
	Parent_ID varchar(20) NULL,
	Active bit NULL,
	CONSTRAINT pk_REPORT PRIMARY KEY (Report_ID)
)

--
-- Nhap lieu REPORT
--

--INSERT INTO REPORT(Parent_ID, ReportName, Title, Parent_ID, Active) VALUES
--(N'RP00000', N'Báo cáo tồn kho', N'BÁO CÁO TỒN KHO',NULL, 1),
--(N'RP00001', N'Thẻ kho', N'THẺ KHO',  N'RP00000', 1),
--(N'RP00002', N'Sổ chi tiết vật tư', N'SỔ CHI TIẾT VẬT TƯ', N'RP00000', 1),
--(N'RP00003', N'Tổng số lượng xuất nhập tồn', N'TỔNG HỢP SỐ LƯỢNG XUẤT NHẬP TỒN', N'RP00000', 1),
--(N'RP00004', N'Tổng hợp xuất nhập tồn', N'TỔNG HỢP XUẤT NHẬP TỒN', N'RP00000', 1),
--(N'RP00005', N'Tồn kho', N'TỒN KHO', N'RP00000', 1),
--(N'RP00006', N'Chi tiết tồn kho', N'CHI TIẾT TỒN KHO', N'RP00000', 1),
--(N'RP00007', N'Tồn kho theo hạn sử dụng', N'TỒN KHO THEO HẠN SỬ DỤNG', N'RP00000',1),
--(N'RP00008', N'Tồn kho vượt hạn', N'TỒN KHO VƯỢT HẠN',N'RP00000',1),
--(N'RP00009', N'Tồn kho vượt định mức', N'TỒN KHO VƯỢT ĐỊNH MỨC', N'RP00000', 1),
--(N'RP000010', N'Thẻ kho DN', N'THẺ KHO', N'RP00000', 1),
--(N'RP000011', N'Tồn kho dưới định mức', N'TỒN KHO DƯỚI ĐỊNH MỨC', N'RP00000', 1),
--(N'RP000012', N'Tổng hợp xuất nhập tồn (Đơn giản)', N'TỔNG HỢP XUẤT NHẬP TỒN (ĐƠN GIẢN)', N'RP00000', 1),
--(N'RP000013', N'Tổng hợp nhập luân chuyển', N'TỔNG HỢP NHẬP LUÂN CHUYỂN',N'RP00000', 1),
--(N'RP000014', N'Tổng hợp xuất luân chuyển', N'TỔNG HỢP XUẤT LUÂN CHUYỂN', N'RP00000', 1),
--(N'RP000015', N'Bảng kê chi tiết nhập kho', N'BẢNG KÊ CHI TIẾT NHẬP KHO', N'RP00000', 1),
--(N'RP000016', N'Bảng kê chi tiết xuất kho', N'BẢNG KÊ CHIT TIẾT XUẤT KHO', N'RP00000', 1),
--(N'RP000017', N'Bảng kê chi tiết chuyển kho', N'BẢNG KÊ CHI TIẾT CHUYỂN KHO', N'RP00000', 1),
--(N'RP000018', N'Bảng kê chi tiết kiểm kê', N'BẢNG KÊ CHI TIẾT KIỀM KÊ', N'RP00000', 1),
--(N'RP000019', N'Báo cáo Doanh Thu Theo Ngày', N'BẢNG KÊ DOANH THU THEO NGÀY', N'RP00000', 1);



/****** Object:  ForeignKey [FK_SYS_USER_RULE_SYS_GROUP]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[SYS_USER_RULE]  WITH CHECK ADD  CONSTRAINT [FK_SYS_USER_RULE_SYS_GROUP] FOREIGN KEY([Group_ID])
REFERENCES [dbo].[SYS_GROUP] ([Group_ID])
GO
ALTER TABLE [dbo].[SYS_USER_RULE] CHECK CONSTRAINT [FK_SYS_USER_RULE_SYS_GROUP]
GO
/****** Object:  ForeignKey [FK_SYS_USER_RULE_SYS_OBJECT]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[SYS_USER_RULE]  WITH CHECK ADD  CONSTRAINT [FK_SYS_USER_RULE_SYS_OBJECT] FOREIGN KEY([Object_ID])
REFERENCES [dbo].[SYS_OBJECT] ([Object_ID])
GO
ALTER TABLE [dbo].[SYS_USER_RULE] CHECK CONSTRAINT [FK_SYS_USER_RULE_SYS_OBJECT]
GO
/****** Object:  ForeignKey [FK_SYS_USER_SYS_GROUP]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[SYS_USER]  WITH CHECK ADD  CONSTRAINT [FK_SYS_USER_SYS_GROUP] FOREIGN KEY([Group_ID])
REFERENCES [dbo].[SYS_GROUP] ([Group_ID])
GO
ALTER TABLE [dbo].[SYS_USER] CHECK CONSTRAINT [FK_SYS_USER_SYS_GROUP]
GO
/****** Object:  ForeignKey [FK_PROVIDER_CUSTOMER_GROUP]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PROVIDER]  WITH CHECK ADD  CONSTRAINT [FK_PROVIDER_CUSTOMER_GROUP] FOREIGN KEY([Customer_Group_ID])
REFERENCES [dbo].[CUSTOMER_GROUP] ([Customer_Group_ID])
GO
ALTER TABLE [dbo].[PROVIDER] CHECK CONSTRAINT [FK_PROVIDER_CUSTOMER_GROUP]
GO
/****** Object:  ForeignKey [FK_CUSTOMER_CUSTOMER_GROUP]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[CUSTOMER]  WITH CHECK ADD  CONSTRAINT [FK_CUSTOMER_CUSTOMER_GROUP] FOREIGN KEY([Customer_Group_ID])
REFERENCES [dbo].[CUSTOMER_GROUP] ([Customer_Group_ID])
GO
ALTER TABLE [dbo].[CUSTOMER] CHECK CONSTRAINT [FK_CUSTOMER_CUSTOMER_GROUP]
GO
/****** Object:  ForeignKey [FK_CUSTOMER_CUSTOMER_TYPE]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[CUSTOMER]  WITH CHECK ADD  CONSTRAINT [FK_CUSTOMER_CUSTOMER_TYPE] FOREIGN KEY([Customer_Type_ID])
REFERENCES [dbo].[CUSTOMER_TYPE] ([Customer_Type_ID])
GO
ALTER TABLE [dbo].[CUSTOMER] CHECK CONSTRAINT [FK_CUSTOMER_CUSTOMER_TYPE]
GO
/****** Object:  ForeignKey [FK_EMPLOYEE_DEPARTMENT]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_DEPARTMENT] FOREIGN KEY([Department_ID])
REFERENCES [dbo].[DEPARTMENT] ([Department_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [FK_EMPLOYEE_DEPARTMENT]
GO
/****** Object:  ForeignKey [FK_EMPLOYEE_EMPLOYEE]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_EMPLOYEE] FOREIGN KEY([Manager_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [FK_EMPLOYEE_EMPLOYEE]
GO
/****** Object:  ForeignKey [FK_PRODUCT_CURRENCY]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_CURRENCY] FOREIGN KEY([Currency_ID])
REFERENCES [dbo].[CURRENCY] ([Currency_ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_CURRENCY]
GO
/****** Object:  ForeignKey [FK_PRODUCT_PRODUCT_GROUP]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_PRODUCT_GROUP] FOREIGN KEY([Product_Group_ID])
REFERENCES [dbo].[PRODUCT_GROUP] ([Product_Group_ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_PRODUCT_GROUP]
GO
/****** Object:  ForeignKey [FK_PRODUCT_PROVIDER]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_PROVIDER] FOREIGN KEY([Prorvider_ID])
REFERENCES [dbo].[PROVIDER] ([Provider_ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_PROVIDER]
GO
/****** Object:  ForeignKey [FK_PRODUCT_SYS_USER]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_SYS_USER] FOREIGN KEY([User_ID])
REFERENCES [dbo].[SYS_USER] ([User_ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_SYS_USER]
GO
/****** Object:  ForeignKey [FK_PRODUCT_UNIT]    Script Date: 05/23/2017 00:30:08 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_UNIT] FOREIGN KEY([Unit])
REFERENCES [dbo].[UNIT] ([Unit_ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_UNIT]
GO
