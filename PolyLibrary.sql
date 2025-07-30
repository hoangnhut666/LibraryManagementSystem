USE master
GO

CREATE DATABASE PolyLibrary;
GO

USE PolyLibrary;
GO

CREATE TABLE Roles
(
    [RoleID] VARCHAR(10) PRIMARY KEY,
    [RoleName] NVARCHAR(50) UNIQUE NOT NULL,
    [Description] NVARCHAR(200)
);


CREATE TABLE Users
(
    [UserID] VARCHAR(10) PRIMARY KEY,
    [Username] VARCHAR(50) UNIQUE NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [Email] VARCHAR(100) UNIQUE NOT NULL,
    [FullName] NVARCHAR(100),
    [RoleID] VARCHAR(10) NOT NULL,
    [IsActive] BIT DEFAULT 1,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);


CREATE TABLE Publishers
(
    [PublisherID] VARCHAR(10) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    [Address] NVARCHAR(200),
    [Phone] VARCHAR(20),
    [Email] VARCHAR(50)
);


CREATE TABLE Authors
(
    [AuthorID] VARCHAR(10) PRIMARY KEY,
    [FullName] NVARCHAR(100) NOT NULL,
    [Biography] NVARCHAR(MAX),
    [DateOfBirth] DATE,
    [DateOfDeath] DATE,
);


CREATE TABLE Categories
(
    [CategoryID] VARCHAR(10) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL UNIQUE,
    [Description] NVARCHAR(255),
);


CREATE TABLE Books
(
    [BookID] VARCHAR(10) PRIMARY KEY,
    [ISBN] VARCHAR(20) UNIQUE NOT NULL,
    [Title] NVARCHAR(200) NOT NULL,
    [PublisherID] VARCHAR(10),
    [PublicationYear] INT,
    [CategoryID] VARCHAR(10),
    [ShelfLocation] NVARCHAR(50),
    [NumberOfPages] INT,
    [Language] NVARCHAR(50),
    [Description] NVARCHAR(MAX),
    [CoverImage] VARBINARY(MAX),
    FOREIGN KEY (PublisherID) REFERENCES Publishers(PublisherID) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE SET NULL ON UPDATE CASCADE
);


CREATE TABLE BookAuthors
(
    [BookAuthorID] INT PRIMARY KEY IDENTITY(1,1),
    [BookID] VARCHAR(10) NOT NULL,
    [AuthorID] VARCHAR(10) NOT NULL,
    FOREIGN KEY (BookID) REFERENCES Books(BookID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID) ON DELETE CASCADE ON UPDATE CASCADE,
    UNIQUE (BookID, AuthorID)
);


CREATE TABLE BookCopies
(
    [CopyID] VARCHAR(10) PRIMARY KEY,
    [BookID] VARCHAR(10) NOT NULL,
    [Barcode] VARCHAR(50) UNIQUE NOT NULL,
    [Status] NVARCHAR(20) DEFAULT N'Có sẵn' CHECK (Status IN (N'Có sẵn', N'Đang cho mượn', N'Thất lạc', N'Hư hỏng', N'Đang sửa chữa')),
    [ConditionNotes] NVARCHAR(255),
    [PurchaseDate] DATE,
    [PurchasePrice] DECIMAL(10,2),
    FOREIGN KEY (BookID) REFERENCES Books(BookID) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE Members
(
    [MemberID] VARCHAR(10) PRIMARY KEY,
    [FullName] NVARCHAR(100) NOT NULL,
    [Email] VARCHAR(100) UNIQUE,
    [Phone] VARCHAR(20),
    [Address] NVARCHAR(200),
    [DateOfBirth] DATE,
    [JoinDate] DATE DEFAULT GETDATE(),
    [Status] NVARCHAR(20) DEFAULT N'Hoạt động' CHECK (Status IN (N'Hoạt động', N'Không hoạt động', N'Bị đình chỉ', N'Hết hạn')),
    [Photo] VARBINARY(MAX)
);


CREATE TABLE Loans
(
    [LoanID] VARCHAR(10) PRIMARY KEY,
    [CopyID] VARCHAR(10) NOT NULL,
    [MemberID] VARCHAR(10) NOT NULL,
    [UserID] VARCHAR(10),
    [LoanDate] DATETIME DEFAULT GETDATE(),
    [DueDate] DATETIME NOT NULL,
    [ReturnDate] DATETIME,
    [Status] NVARCHAR(20) DEFAULT N'Đang mượn' CHECK (Status IN (N'Đang mượn', N'Đã trả', N'Quá hạn', N'Thất lạc')),
    [Notes] NVARCHAR(255),
    FOREIGN KEY (CopyID) REFERENCES BookCopies(CopyID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL ON UPDATE CASCADE
);


CREATE TABLE Fines
(
    [FineID] VARCHAR(10) PRIMARY KEY,
    [LoanID] VARCHAR(10) NOT NULL,
    [Amount] DECIMAL(10,2) NOT NULL,
    [IssueDate] DATETIME DEFAULT GETDATE(),
    [Paid] BIT DEFAULT 0,
    [Reason] NVARCHAR(255),
    FOREIGN KEY (LoanID) REFERENCES Loans(LoanID) ON DELETE CASCADE ON UPDATE CASCADE,
);


INSERT INTO Roles
    ([RoleID], [RoleName], [Description])
VALUES
    ('ROLE001', N'Quản trị viên', N'Toàn quyền quản lý hệ thống thư viện.'),
    ('ROLE002', N'Thủ thư', N'Quản lý sách, mượn trả, thành viên.'),
    ('ROLE003', N'Thành viên', N'Người dùng thông thường, có thể mượn sách, đặt chỗ.');


INSERT INTO Users
    ([UserID], [Username], [Password], [Email], [FullName], [RoleID], [IsActive])
VALUES
    ('USER001', 'admin', 'admin123', 'admin@polylibrary.com', N'Trần Ngọc Hà', 'ROLE001', 1),
    ('USER002', 'thuthu01', 'thuthu123', 'thuthu01@polylibrary.com', N'Nguyễn Thị Hoa', 'ROLE002', 1),
    ('USER003', 'nhanvien01', 'nhanvien123', 'nhanvien01@polylibrary.com', N'Trần Văn Long', 'ROLE002', 1),
    ('USER004', 'annguyen', 'annguyen123', 'an.nguyen@example.com', N'Nguyễn Văn An', 'ROLE003', 1),
    ('USER005', 'binhtran', 'binhtran123', 'binh.tran@example.com', N'Trần Thị Bình', 'ROLE003', 1),
    ('USER006', 'cuongle', 'cuongle123', 'cuong.le@example.com', N'Lê Minh Cường', 'ROLE003', 1),
    ('USER007', 'dungpham', 'dungpham123', 'dung.pham@example.com', N'Phạm Thu Dung', 'ROLE003', 1),
    ('USER008', 'anhhoang', 'anhhoang123', 'anh.hoang@example.com', N'Hoàng Việt Anh', 'ROLE003', 1),
    ('USER009', 'thaodo', 'thaodo123', 'thao.do@example.com', N'Đỗ Thị Thảo', 'ROLE003', 1),
    ('USER010', 'vinhbui', 'vinhbui123', 'vinh.bui@example.com', N'Bùi Quang Vinh', 'ROLE003', 1),
    ('USER011', 'tuvu', 'tuvu123', 'tu.vo@example.com', N'Võ Thanh Tú', 'ROLE003', 1),
    ('USER012', 'kimdang', 'kimdang123', 'kim.dang@example.com', N'Đặng Thị Kim', 'ROLE003', 1),
    ('USER013', 'phatnguyen', 'phatnguyen123', 'phat.nguyen@example.com', N'Nguyễn Đức Phát', 'ROLE003', 1),
    ('USER014', 'maicao', 'maicao123', 'mai.cao@example.com', N'Cao Thị Mai', 'ROLE003', 1),
    ('USER015', 'khaidinh', 'khaidinh123', 'khai.dinh@example.com', N'Đinh Bá Khải', 'ROLE003', 1);
GO



INSERT INTO Publishers
    ([PublisherID], [Name], [Address], [Phone], [Email])
VALUES
    ('PUB001', N'Nhà Xuất Bản Trẻ', N'161B Lý Chính Thắng, P.Võ Thị Sáu, Q.3, TP.HCM', '02838465691', 'nxbtre@nxbtre.com.vn'),
    ('PUB002', N'Nhà Xuất Bản Kim Đồng', N'248 Cống Quỳnh, P.Phạm Ngũ Lão, Q.1, TP.HCM', '02838363737', 'kimdong@kimdong.com.vn'),
    ('PUB003', N'Nhà Xuất Bản Tổng Hợp TP.HCM', N'62 Nguyễn Thị Minh Khai, P.Đa Kao, Q.1, TP.HCM', '02838225330', 'nxbtonghop@hcm.vnn.vn'),
    ('PUB004', N'Nhà Xuất Bản Lao Động', N'175 Giảng Võ, Cát Linh, Đống Đa, Hà Nội', '02438452009', 'nxblaodong@gmail.com'),
    ('PUB005', N'Nhà Xuất Bản Chính Trị Quốc Gia Sự Thật', N'6/86 Duy Tân, Dịch Vọng Hậu, Cầu Giấy, Hà Nội', '02438253818', 'nxbctqg@nxbctqg.vn'),
    ('PUB006', N'Nhà Xuất Bản Phụ Nữ', N'39 Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội', '02439434098', 'nxbphunu@fpt.vn'),
    ('PUB007', N'Nhà Xuất Bản Văn Học', N'18 Nguyễn Du, Bùi Thị Xuân, Hai Bà Trưng, Hà Nội', '02439423689', 'nxbvanhoc@gmail.com'),
    ('PUB008', N'Nhà Xuất Bản Khoa Học Tự Nhiên và Công Nghệ', N'18 Hoàng Quốc Việt, Nghĩa Đô, Cầu Giấy, Hà Nội', '02437910471', 'nxbkhcn@vast.vn'),
    ('PUB009', N'Nhà Xuất Bản Giáo Dục Việt Nam', N'81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02439421717', 'nxb@nxbgd.vn'),
    ('PUB010', N'Nhà Xuất Bản Thông Tin và Truyền Thông', N'115 Trần Duy Hưng, Trung Hòa, Cầu Giấy, Hà Nội', '02435560935', 'nxbtntt@mic.gov.vn'),
    ('PUB011', N'Nhà Xuất Bản Dân Trí', N'12 Nguyễn Công Hoan, Ngọc Khánh, Ba Đình, Hà Nội', '02437710323', 'nxb_dantri@gmail.com'),
    ('PUB012', N'Nhà Xuất Bản Mỹ Thuật', N'51 Trần Hưng Đạo, Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02439423689', 'nxbmythuat@gmail.com'),
    ('PUB013', N'Nhà Xuất Bản Xây Dựng', N'37 Lê Đại Hành, Lê Đại Hành, Hai Bà Trưng, Hà Nội', '02439745580', 'nxbxaydung@hn.vnn.vn'),
    ('PUB014', N'Nhà Xuất Bản Giao Thông Vận Tải', N'80 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02438221068', 'nxbgtvt@gmail.com'),
    ('PUB015', N'Nhà Xuất Bản Y Học', N'26B Bát Sứ, Hàng Bồ, Hoàn Kiếm, Hà Nội', '02438289809', 'nxbyhoc@gmail.com'),
    ('PUB016', N'Nhà Xuất Bản Thể Thao', N'12 Trịnh Hoài Đức, Cát Linh, Đống Đa, Hà Nội', '02437340057', 'nxbthethao@gmail.com'),
    ('PUB017', N'Nhà Xuất Bản Thanh Niên', N'62 Nguyễn Thái Học, Ba Đình, Hà Nội', '02438230504', 'nxbthanhnien@gmail.com'),
    ('PUB018', N'Nhà Xuất Bản Đại Học Quốc Gia TP.HCM', N'10 Đinh Tiên Hoàng, Bến Nghé, Q.1, TP.HCM', '02838293821', 'nxb.dhqg@hcm.edu.vn'),
    ('PUB019', N'Nhà Xuất Bản Đà Nẵng', N'10 Trần Phú, Hải Châu 1, Hải Châu, Đà Nẵng', '02363821033', 'nxb.danang@gmail.com'),
    ('PUB020', N'Nhà Xuất Bản Cần Thơ', N'160 Đường 30 Tháng 4, Hưng Lợi, Ninh Kiều, Cần Thơ', '02923830404', 'nxbcantho@gmail.com');


INSERT INTO Authors
    ([AuthorID], [FullName], [Biography], [DateOfBirth], [DateOfDeath])
VALUES
    ('AUTH001', N'Tô Hoài', N'Nhà văn nổi tiếng của Việt Nam, tác giả của "Dế Mèn Phiêu Lưu Ký".', '1920-09-23', '2014-07-06'),
    ('AUTH002', N'Vũ Trọng Phụng', N'Nhà văn hiện thực phê phán xuất sắc của văn học Việt Nam trước 1945.', '1911-10-21', '1939-10-13'),
    ('AUTH003', N'Dale Carnegie', N'Nhà văn, diễn giả người Mỹ, chuyên gia về phát triển bản thân và kỹ năng giao tiếp.', '1888-11-24', '1955-11-01'),
    ('AUTH004', N'Stephen Hawking', N'Nhà vật lý lý thuyết, vũ trụ học người Anh, tác giả của nhiều cuốn sách khoa học phổ biến.', '1942-01-08', '2018-03-14'),
    ('AUTH005', N'Dan Senor', N'Tác giả người Mỹ, đồng tác giả của "Quốc Gia Khởi Nghiệp".', '1966-09-06', NULL),
    ('AUTH006', N'Nguyễn Du', N'Đại thi hào dân tộc Việt Nam, tác giả của "Truyện Kiều".', '1765-11-23', '1820-09-18'),
    ('AUTH007', N'Nguyễn Nhật Ánh', N'Nhà văn Việt Nam chuyên viết cho tuổi mới lớn và thiếu nhi.', '1955-05-07', NULL),
    ('AUTH008', N'Khuyết danh', N'Tác giả không rõ tên, thường là các tác phẩm dân gian hoặc truyền miệng.', NULL, NULL),
    ('AUTH009', N'Yuval Noah Harari', N'Nhà sử học, triết học người Israel, tác giả của "Sapiens: Lược Sử Loài Người".', '1976-02-24', NULL),
    ('AUTH010', N'Paulo Coelho', N'Tiểu thuyết gia người Brazil, nổi tiếng với cuốn "Nhà Giả Kim".', '1947-08-24', NULL),
    ('AUTH011', N'Robert Kiyosaki', N'Nhà đầu tư, doanh nhân, tác giả người Mỹ, nổi tiếng với "Cha Giàu Cha Nghèo".', '1947-04-08', NULL),
    ('AUTH012', N'Gosho Aoyama', N'Họa sĩ truyện tranh người Nhật Bản, tác giả của "Thám Tử Lừng Danh Conan".', '1963-06-21', NULL),
    ('AUTH013', N'Bộ Giáo dục và Đào tạo', N'Cơ quan quản lý giáo dục của Việt Nam, chịu trách nhiệm biên soạn sách giáo khoa.', NULL, NULL),
    ('AUTH014', N'Shunmyo Masuno', N'Thiền sư, kiến trúc sư cảnh quan người Nhật Bản, tác giả của "Nghệ Thuật Sống Đơn Giản".', '1953-02-28', NULL),
    ('AUTH015', N'Nhiều tác giả', N'Tập hợp các tác phẩm của nhiều tác giả khác nhau.', NULL, NULL),
    ('AUTH016', N'Alex Rovira', N'Tác giả, diễn giả người Tây Ban Nha, đồng tác giả của "Bí Mật Của Sự May Mắn".', '1969-03-01', NULL),
    ('AUTH017', N'Fernando Trías de Bes', N'Tác giả, nhà kinh tế học người Tây Ban Nha, đồng tác giả của "Bí Mật Của Sự May Mắn".', '1967-05-12', NULL),
    ('AUTH018', N'Ngô Tất Tố', N'Nhà văn hiện thực phê phán, nổi tiếng với tác phẩm "Tắt đèn".', '1893-06-09', '1954-01-20'),
    ('AUTH019', N'Nam Cao', N'Nhà văn hiện thực lớn của văn học Việt Nam, tác giả của "Chí Phèo".', '1917-10-29', '1951-11-30'),
    ('AUTH020', N'Xuân Diệu', N'Nhà thơ lãng mạn nổi tiếng của phong trào Thơ mới.', '1916-02-02', '1985-12-18'),
    ('AUTH021', N'Hồ Chí Minh', N'Lãnh tụ vĩ đại của dân tộc Việt Nam, nhà thơ, nhà văn.', '1890-05-19', '1969-09-02'),
    ('AUTH022', N'Võ Nguyên Giáp', N'Đại tướng, Tổng tư lệnh Quân đội Nhân dân Việt Nam, nhà lý luận quân sự.', '1911-08-25', '2013-10-04'),
    ('AUTH023', N'Trần Đăng Khoa', N'Nhà thơ, nhà báo Việt Nam, nổi tiếng từ khi còn nhỏ.', '1958-04-24', NULL),
    ('AUTH025', N'Nguyễn Đình Chiểu', N'Nhà thơ lớn của miền Nam Việt Nam, tác giả của "Lục Vân Tiên".', '1822-05-13', '1888-07-03'),
    ('AUTH026', N'Nguyễn Khuyến', N'Nhà thơ trào phúng nổi tiếng của Việt Nam.', '1835-02-15', '1909-02-15'),
    ('AUTH027', N'Chế Lan Viên', N'Nhà thơ hiện đại Việt Nam, thuộc phong trào Thơ mới.', '1920-10-20', '1989-06-19'),
    ('AUTH028', N'Tố Hữu', N'Nhà thơ cách mạng Việt Nam.', '1920-10-04', '2002-12-09');




INSERT INTO Categories
    ([CategoryID], [Name], [Description])
VALUES
    ('CAT001', N'Văn học', N'Các tác phẩm văn học, tiểu thuyết, truyện ngắn, thơ ca.'),
    ('CAT002', N'Kinh tế - Quản lý', N'Sách về kinh tế học, quản trị kinh doanh, tài chính, marketing.'),
    ('CAT003', N'Khoa học - Công nghệ', N'Sách về khoa học tự nhiên, công nghệ thông tin, kỹ thuật.'),
    ('CAT004', N'Lịch sử - Địa lý', N'Sách về lịch sử Việt Nam và thế giới, địa lý, văn hóa.'),
    ('CAT005', N'Giáo dục - Sách tham khảo', N'Sách giáo khoa, sách bài tập, sách luyện thi, cẩm nang học tập.'),
    ('CAT006', N'Kỹ năng sống - Phát triển bản thân', N'Sách về phát triển cá nhân, kỹ năng mềm, tâm lý học ứng dụng.'),
    ('CAT007', N'Thiếu nhi', N'Truyện cổ tích, truyện tranh, sách giáo dục cho trẻ em.'),
    ('CAT008', N'Nghệ thuật - Giải trí', N'Sách về âm nhạc, hội họa, điện ảnh, nhiếp ảnh, ẩm thực.'),
    ('CAT009', N'Sức khỏe - Y học', N'Sách về dinh dưỡng, chăm sóc sức khỏe, y học phổ thông.'),
    ('CAT010', N'Du lịch - Khám phá', N'Cẩm nang du lịch, sách ảnh, hồi ký khám phá.'),
    ('CAT011', N'Tâm linh - Tôn giáo', N'Sách về triết học, tôn giáo, tâm linh.'),
    ('CAT012', N'Chính trị - Xã hội', N'Sách về chính trị, xã hội học, luật pháp.'),
    ('CAT013', N'Nông nghiệp - Môi trường', N'Sách về nông nghiệp, bảo vệ môi trường, sinh thái học.'),
    ('CAT014', N'Thể thao - Giải trí', N'Sách về các môn thể thao, trò chơi, giải trí.'),
    ('CAT015', N'Công nghệ thông tin', N'Sách chuyên sâu về lập trình, mạng máy tính, phần mềm.'),
    ('CAT016', N'Ngoại ngữ', N'Sách học tiếng Anh, tiếng Nhật, tiếng Hàn, tiếng Trung.'),
    ('CAT017', N'Gia đình - Nữ công gia chánh', N'Sách về nuôi dạy con, nấu ăn, làm đẹp, quản lý gia đình.'),
    ('CAT018', N'Tạp chí - Báo', N'Các ấn phẩm định kỳ, tạp chí chuyên ngành.'),
    ('CAT019', N'Truyện tranh - Manga', N'Các bộ truyện tranh, manga, comic.'),
    ('CAT020', N'Sách chuyên ngành', N'Sách chuyên sâu cho các lĩnh vực kỹ thuật, khoa học cụ thể.');


INSERT INTO Books
    ([BookID], [ISBN], [Title], [PublisherID], [PublicationYear], [CategoryID], [ShelfLocation], [NumberOfPages], [Language], [Description], [CoverImage])
VALUES
    ('BOOK001', '978-604-2-00001-1', N'Dế Mèn Phiêu Lưu Ký', 'PUB001', 1941, 'CAT007', N'Kệ A1', 180, N'Tiếng Việt', N'Cuộc phiêu lưu của chú dế mèn qua thế giới tự nhiên.', NULL),
    ('BOOK002', '978-604-2-00002-8', N'Số Đỏ', 'PUB003', 1938, 'CAT001', N'Kệ B2', 250, N'Tiếng Việt', N'Tiểu thuyết trào phúng về xã hội Việt Nam thời Pháp thuộc.', NULL),
    ('BOOK003', '978-604-2-00003-5', N'Đắc Nhân Tâm', 'PUB001', 1936, 'CAT006', N'Kệ C3', 320, N'Tiếng Việt', N'Cẩm nang về nghệ thuật giao tiếp và đối nhân xử thế.', NULL),
    ('BOOK004', '978-604-2-00004-2', N'Lược Sử Thời Gian', 'PUB008', 1988, 'CAT003', N'Kệ D4', 280, N'Tiếng Việt', N'Giới thiệu các khái niệm cơ bản về vũ trụ học và vật lý.', NULL),
    ('BOOK005', '978-604-2-00005-9', N'Quốc Gia Khởi Nghiệp', 'PUB002', 2009, 'CAT002', N'Kệ E5', 400, N'Tiếng Việt', N'Phân tích sự phát triển kinh tế thần kỳ của Israel.', NULL),
    ('BOOK006', '978-604-2-00006-6', N'Truyện Kiều', 'PUB007', 1820, 'CAT001', N'Kệ A2', 350, N'Tiếng Việt', N'Kiệt tác thơ Nôm của Nguyễn Du.', NULL),
    ('BOOK007', '978-604-2-00007-3', N'Mắt Biếc', 'PUB001', 1990, 'CAT001', N'Kệ B3', 200, N'Tiếng Việt', N'Câu chuyện tình yêu tuổi học trò đầy lãng mạn.', NULL),
    ('BOOK008', '978-604-2-00008-0', N'Thám Tử Lừng Danh Conan - Tập 1', 'PUB002', 1994, 'CAT019', N'Kệ F1', 190, N'Tiếng Việt', N'Bộ truyện tranh trinh thám nổi tiếng của Nhật Bản.', NULL),
    ('BOOK009', '978-604-2-00009-7', N'Sapiens: Lược Sử Loài Người', 'PUB003', 2011, 'CAT004', N'Kệ D5', 500, N'Tiếng Việt', N'Khám phá lịch sử loài người từ bình minh đến hiện tại.', NULL),
    ('BOOK010', '978-604-2-00010-3', N'Nhà Giả Kim', 'PUB001', 1988, 'CAT001', N'Kệ C4', 220, N'Tiếng Việt', N'Câu chuyện về hành trình đi tìm kho báu và ý nghĩa cuộc sống.', NULL),
    ('BOOK011', '978-604-2-00011-0', N'Cha Giàu Cha Nghèo', 'PUB004', 1997, 'CAT002', N'Kệ E1', 280, N'Tiếng Việt', N'Những bài học về tài chính cá nhân và đầu tư.', NULL),
    ('BOOK012', '978-604-2-00012-7', N'Tắt Đèn', 'PUB007', 1939, 'CAT001', N'Kệ A3', 230, N'Tiếng Việt', N'Phản ánh cuộc sống khổ cực của người nông dân Việt Nam.', NULL),
    ('BOOK013', '978-604-2-00013-4', N'Chí Phèo', 'PUB007', 1941, 'CAT001', N'Kệ B4', 150, N'Tiếng Việt', N'Tác phẩm kinh điển về người nông dân trong xã hội cũ.', NULL),
    ('BOOK014', '978-604-2-00014-1', N'Bí Mật Của Sự May Mắn', 'PUB001', 2004, 'CAT006', N'Kệ C5', 160, N'Tiếng Việt', N'Câu chuyện ngụ ngôn về cách tạo ra may mắn cho chính mình.', NULL),
    ('BOOK015', '978-604-2-00015-8', N'Lĩnh Nam Chích Quái', 'PUB007', 1400, 'CAT004', N'Kệ D1', 300, N'Tiếng Việt', N'Tuyển tập các truyện cổ tích và truyền thuyết Việt Nam.', NULL);



INSERT INTO BookAuthors
    ([BookID], [AuthorID])
VALUES
    ('BOOK001', 'AUTH001'),
    ('BOOK002', 'AUTH002'),
    ('BOOK003', 'AUTH003'),
    ('BOOK004', 'AUTH004'),
    ('BOOK005', 'AUTH005'),
    ('BOOK006', 'AUTH006'),
    ('BOOK007', 'AUTH007'),
    ('BOOK008', 'AUTH012'),
    ('BOOK009', 'AUTH009'),
    ('BOOK010', 'AUTH010'),
    ('BOOK011', 'AUTH011'),
    ('BOOK012', 'AUTH018'),
    ('BOOK013', 'AUTH019'),
    ('BOOK014', 'AUTH016'),
    ('BOOK014', 'AUTH017');



INSERT INTO BookCopies
    ([CopyID], [BookID], [Barcode], [Status], [ConditionNotes], [PurchaseDate], [PurchasePrice])
VALUES
    ('COPY001', 'BOOK001', 'BC001001', N'Có sẵn', N'Sách mới', '2023-01-15', 85000.00),
    ('COPY002', 'BOOK001', 'BC001002', N'Đang cho mượn', N'Gáy sách hơi cũ', '2023-01-15', 85000.00),
    ('COPY003', 'BOOK002', 'BC002001', N'Có sẵn', N'Sách mới', '2023-02-20', 90000.00),
    ('COPY004', 'BOOK003', 'BC003001', N'Có sẵn', N'Bìa hơi cong', '2023-03-10', 120000.00),
    ('COPY005', 'BOOK004', 'BC004001', N'Có sẵn', N'Sách đẹp', '2023-04-05', 150000.00),
    ('COPY006', 'BOOK005', 'BC005001', N'Đang cho mượn', N'Hơi rách bìa', '2023-05-01', 180000.00),
    ('COPY007', 'BOOK006', 'BC006001', N'Có sẵn', N'Sách mới', '2023-06-12', 75000.00),
    ('COPY008', 'BOOK007', 'BC007001', N'Có sẵn', N'Bìa tốt', '2023-07-20', 95000.00),
    ('COPY009', 'BOOK008', 'BC008001', N'Có sẵn', N'Sách mới', '2023-08-01', 45000.00),
    ('COPY010', 'BOOK009', 'BC009001', N'Đang cho mượn', N'Gáy sách bị bạc màu', '2023-09-15', 250000.00),
    ('COPY011', 'BOOK010', 'BC010001', N'Có sẵn', N'Sách mới', '2023-10-01', 100000.00),
    ('COPY012', 'BOOK011', 'BC011001', N'Có sẵn', N'Bị ố một vài trang', '2023-11-10', 130000.00),
    ('COPY013', 'BOOK012', 'BC012001', N'Có sẵn', N'Sách mới', '2023-12-05', 80000.00),
    ('COPY014', 'BOOK013', 'BC013001', N'Đang cho mượn', N'Hơi nhàu bìa', '2024-01-01', 60000.00),
    ('COPY015', 'BOOK014', 'BC014001', N'Có sẵn', N'Sách mới', '2024-02-28', 70000.00),
    ('COPY016', 'BOOK001', 'BC001003', N'Hư hỏng', N'Rách bìa trước', '2022-10-01', 85000.00),
    ('COPY017', 'BOOK002', 'BC002002', N'Đang sửa chữa', N'Bị bong gáy', '2023-03-01', 90000.00),
    ('COPY018', 'BOOK003', 'BC003002', N'Thất lạc', N'Không rõ lý do', '2022-05-10', 120000.00),
    ('COPY019', 'BOOK004', 'BC004002', N'Có sẵn', N'Chữ viết bút chì', '2023-06-15', 150000.00),
    ('COPY020', 'BOOK005', 'BC005002', N'Có sẵn', N'Còn tốt', '2024-01-20', 180000.00);



INSERT INTO Members
    ([MemberID], [FullName], [Email], [Phone], [Address], [DateOfBirth], [JoinDate], [Status], [Photo])
VALUES
    ('MEM001', N'Nguyễn Văn An', 'an.nguyen@example.com', '0912345678', N'123 Nguyễn Trãi, Q.1, TP.HCM', '1990-03-15', '2022-01-10', N'Hoạt động', NULL),
    ('MEM002', N'Trần Thị Bình', 'binh.tran@example.com', '0901234567', N'45 Hai Bà Trưng, Q.3, TP.HCM', '1985-07-22', '2022-02-01', N'Hoạt động', NULL),
    ('MEM003', N'Lê Minh Cường', 'cuong.le@example.com', '0987654321', N'67 Trần Hưng Đạo, Q.5, TP.HCM', '1992-11-01', '2022-03-05', N'Hoạt động', NULL),
    ('MEM004', N'Phạm Thu Dung', 'dung.pham@example.com', '0778899001', N'89 Lê Lợi, Q.1, TP.HCM', '1998-01-20', '2022-04-15', N'Hoạt động', NULL),
    ('MEM005', N'Hoàng Việt Anh', 'anh.hoang@example.com', '0868123456', N'10 Nguyễn Huệ, Q.1, TP.HCM', '2000-09-05', '2022-05-20', N'Hoạt động', NULL),
    ('MEM006', N'Đỗ Thị Thảo', 'thao.do@example.com', '0945678901', N'25 Cộng Hòa, Q.Tân Bình, TP.HCM', '1995-04-10', '2022-06-01', N'Hoạt động', NULL),
    ('MEM007', N'Bùi Quang Vinh', 'vinh.bui@example.com', '0933221100', N'78 Pasteur, Q.3, TP.HCM', '1980-12-30', '2022-07-11', N'Hoạt động', NULL),
    ('MEM008', N'Võ Thanh Tú', 'tu.vo@example.com', '0909112233', N'99 Lý Tự Trọng, Q.1, TP.HCM', '1993-06-18', '2022-08-08', N'Hoạt động', NULL),
    ('MEM009', N'Đặng Thị Kim', 'kim.dang@example.com', '0707445566', N'12 Nguyễn Thị Minh Khai, Q.1, TP.HCM', '1991-02-25', '2022-09-09', N'Hoạt động', NULL),
    ('MEM010', N'Nguyễn Đức Phát', 'phat.nguyen@example.com', '0898776655', N'30 Nam Kỳ Khởi Nghĩa, Q.3, TP.HCM', '1997-08-14', '2022-10-10', N'Hoạt động', NULL),
    ('MEM011', N'Cao Thị Mai', 'mai.cao@example.com', '0919887766', N'40 Võ Văn Tần, Q.3, TP.HCM', '1989-01-01', '2023-01-01', N'Hoạt động', NULL),
    ('MEM012', N'Đinh Bá Khải', 'khai.dinh@example.com', '0903123123', N'55 Lê Thị Riêng, Q.1, TP.HCM', '1994-05-23', '2023-02-14', N'Hoạt động', NULL),
    ('MEM013', N'Trương Cẩm Ly', 'ly.truong@example.com', '0777555333', N'60 Điện Biên Phủ, Q.Bình Thạnh, TP.HCM', '1996-09-09', '2023-03-20', N'Hoạt động', NULL),
    ('MEM014', N'Huỳnh Gia Bảo', 'bao.huynh@example.com', '0966444222', N'70 Bùi Thị Xuân, Q.1, TP.HCM', '2001-03-03', '2023-04-01', N'Hoạt động', NULL),
    ('MEM015', N'Lý Hải Đăng', 'dang.ly@example.com', '0888999111', N'80 CMT8, Q.3, TP.HCM', '1987-11-11', '2023-05-05', N'Hoạt động', NULL);



INSERT INTO Loans
    ([LoanID], [CopyID], [MemberID], [UserID],[LoanDate], [DueDate], [ReturnDate], [Status], [Notes])
VALUES
    ('LOAN001', 'COPY002', 'MEM001', 'USER001', '2024-06-20 10:00:00', '2024-07-04 10:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN002', 'COPY006', 'MEM003', 'USER002', '2024-06-25 11:30:00', '2024-07-09 11:30:00', NULL, N'Đang mượn', NULL),
    ('LOAN003', 'COPY010', 'MEM005', 'USER003', '2024-06-28 14:00:00', '2024-07-12 14:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN004', 'COPY014', 'MEM007', 'USER004', '2024-07-01 09:00:00', '2024-07-15 09:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN005', 'COPY001', 'MEM002', 'USER005', '2024-05-01 10:00:00', '2024-05-15 10:00:00', '2024-05-14 16:00:00', N'Đã trả', NULL),
    ('LOAN006', 'COPY003', 'MEM004', 'USER006', '2024-05-10 14:00:00', '2024-05-24 14:00:00', '2024-05-25 09:00:00', N'Quá hạn', N'Trả muộn 1 ngày'),
    ('LOAN007', 'COPY004', 'MEM006', 'USER007', '2024-06-01 16:00:00', '2024-06-15 16:00:00', '2024-06-15 15:30:00', N'Đã trả', NULL),
    ('LOAN008', 'COPY005', 'MEM008', 'USER008', '2024-06-05 09:30:00', '2024-06-19 09:30:00', '2024-06-19 09:30:00', N'Đã trả', NULL),
    ('LOAN009', 'COPY007', 'MEM009', 'USER009', '2024-06-10 11:00:00', '2024-06-24 11:00:00', '2024-06-23 10:00:00', N'Đã trả', NULL),
    ('LOAN010', 'COPY008', 'MEM010', 'USER010', '2024-06-15 13:00:00', '2024-06-29 13:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN011', 'COPY009', 'MEM011', 'USER011', '2024-06-18 15:00:00', '2024-07-02 15:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN012', 'COPY011', 'MEM012', 'USER012', '2024-06-22 10:30:00', '2024-07-06 10:30:00', NULL, N'Đang mượn', NULL),
    ('LOAN013', 'COPY012', 'MEM013', 'USER013', '2024-06-27 08:00:00', '2024-07-11 08:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN014', 'COPY013', 'MEM014', 'USER014', '2024-06-30 14:30:00', '2024-07-14 14:30:00', NULL, N'Đang mượn', NULL),
    ('LOAN015', 'COPY015', 'MEM015', 'USER015', '2024-07-03 16:00:00', '2024-07-17 16:00:00', NULL, N'Đang mượn', NULL);


INSERT INTO Fines
    ([FineID], [LoanID], [Amount], [IssueDate], [Paid], [Reason])
VALUES
    ('FINE001', 'LOAN006', 15000.00, '2024-05-25 10:00:00', 0, N'Trả sách quá hạn 1 ngày'),
    ('FINE002', 'LOAN001', 20000.00, GETDATE(), 0, N'Làm rách bìa sách'),
    ('FINE003', 'LOAN002', 10000.00, GETDATE(), 0, N'Làm ố một vài trang sách'),
    ('FINE004', 'LOAN003', 25000.00, GETDATE(), 0, N'Làm mất mã vạch sách'),
    ('FINE005', 'LOAN004', 30000.00, GETDATE(), 0, N'Làm mất sách'),
    ('FINE006', 'LOAN005', 5000.00, '2024-05-15 11:00:00', 1, N'Trả sách quá hạn 1 ngày (đã thanh toán)'),
    ('FINE007', 'LOAN007', 12000.00, GETDATE(), 0, N'Làm cong gáy sách'),
    ('FINE008', 'LOAN008', 8000.00, GETDATE(), 0, N'Viết bút chì vào sách'),
    ('FINE009', 'LOAN009', 18000.00, GETDATE(), 0, N'Làm rách trang sách'),
    ('FINE010', 'LOAN010', 22000.00, GETDATE(), 0, N'Làm hỏng sách (không thể sửa chữa)'),
    ('FINE011', 'LOAN011', 15000.00, GETDATE(), 0, N'Trả sách quá hạn 2 ngày'),
    ('FINE012', 'LOAN012', 10000.00, GETDATE(), 0, N'Làm bẩn bìa sách'),
    ('FINE013', 'LOAN013', 50000.00, GETDATE(), 0, N'Làm mất sách quý hiếm'),
    ('FINE014', 'LOAN014', 7000.00, GETDATE(), 0, N'Làm nhàu bìa sách'),
    ('FINE015', 'LOAN015', 13000.00, GETDATE(), 0, N'Trả sách quá hạn 3 ngày');
GO


INSERT INTO Fines
    ([FineID], [LoanID], [Amount], [IssueDate], [Paid], [Reason])
VALUES
    ('FINE007', 'LOAN007', 12000.00, '2024-06-15 10:00:00', 0, N'Làm cong gáy sách'),
    ('FINE008', 'LOAN008', 8000.00, '2024-06-19 09:30:00', 0, N'Viết bút chì vào sách'),
    ('FINE009', 'LOAN009', 18000.00, '2024-06-23 10:00:00', 0, N'Làm rách trang sách'),
    ('FINE010', 'LOAN010', 22000.00, '2024-06-29 13:00:00', 0, N'Làm hỏng sách (không thể sửa chữa)'),
    ('FINE011', 'LOAN011', 15000.00, '2024-07-02 15:00:00', 0, N'Trả sách quá hạn 2 ngày'),
    ('FINE012', 'LOAN012', 10000.00, '2024-07-06 10:30:00', 0, N'Làm bẩn bìa sách'),
    ('FINE013', 'LOAN013', 50000.00, '2024-07-10 09:00:00', 0, N'Làm mất sách quý hiếm'),
    ('FINE014', 'LOAN014', 7000.00, '2024-07-12 14:00:00', 0, N'Làm nhàu bìa sách'),
    ('FINE015', 'LOAN015', 13000.00, '2024-07-15 11:30:00', 0, N'Trả sách quá hạn 3 ngày');
GO


CREATE PROCEDURE SearchAuthors
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        AuthorID,
        FullName,
        Biography,
        DateOfBirth,
        DateOfDeath
    FROM Authors
    WHERE 
        AuthorID LIKE '%' + @SearchTerm + '%' OR
        FullName LIKE '%' + @SearchTerm + '%'
    ORDER BY FullName;
END;


EXEC SearchAuthors 'AUTH001';
EXEC SearchAuthors N'Nguyễn';
EXEC SearchAuthors N'Tô Hoài';
EXEC SearchAuthors N'tô hoài';
GO



CREATE PROCEDURE SearchBooks
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT
        b.BookID,
        b.Title
    FROM
        Books b
        LEFT JOIN Publishers p ON b.PublisherID = p.PublisherID
        LEFT JOIN Categories c ON b.CategoryID = c.CategoryID
        LEFT JOIN BookAuthors ba ON b.BookID = ba.BookID
        LEFT JOIN Authors a ON ba.AuthorID = a.AuthorID

    WHERE 
        @SearchTerm IS NULL OR
        b.BookID LIKE '%' + @SearchTerm + '%' OR
        b.Title LIKE '%' + @SearchTerm + '%' OR
        b.ISBN LIKE '%' + @SearchTerm + '%' OR
        a.FullName LIKE '%' + @SearchTerm + '%' OR
        c.Name LIKE '%' + @SearchTerm + '%' OR
        p.Name LIKE '%' + @SearchTerm + '%'

    GROUP BY
        b.BookID,
        b.Title
    ORDER BY 
        b.Title;
END;


EXEC SearchBooks N'Dế Mèn';
EXEC SearchBooks N'kim đồng';
EXEC SearchBooks N'Tô Hoài';
GO


CREATE PROCEDURE GetAuthorsByBookID
    @BookID VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        a.FullName
    FROM
        Authors a
        INNER JOIN BookAuthors ba ON a.AuthorID = ba.AuthorID
    WHERE 
        ba.BookID = @BookID
    ORDER BY 
        a.FullName;
END;


EXEC GetAuthorsByBookID 'BOOK001';
EXEC GetAuthorsByBookID 'BOOK014';



SELECT a.*
FROM Authors a
    JOIN BookAuthors ba ON a.AuthorID = ba.AuthorID
WHERE ba.BookID = 'BOOK014'
GO


CREATE PROCEDURE SearchBookCopies
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT
        bc.CopyID,
        b.Title
    FROM
        Books b
        LEFT JOIN Publishers p ON b.PublisherID = p.PublisherID
        LEFT JOIN Categories c ON b.CategoryID = c.CategoryID
        LEFT JOIN BookAuthors ba ON b.BookID = ba.BookID
        LEFT JOIN Authors a ON ba.AuthorID = a.AuthorID
        LEFT JOIN BookCopies bc ON bc.BookID = b.BookID


    WHERE 
        @SearchTerm IS NULL OR
        b.BookID LIKE '%' + @SearchTerm + '%' OR
        b.Title LIKE '%' + @SearchTerm + '%' OR
        b.ISBN LIKE '%' + @SearchTerm + '%' OR
        a.FullName LIKE '%' + @SearchTerm + '%' OR
        c.Name LIKE '%' + @SearchTerm + '%' OR
        p.Name LIKE '%' + @SearchTerm + '%' OR
        bc.CopyID LIKE '%' + @SearchTerm + '%' OR
        bc.Barcode LIKE '%' + @SearchTerm + '%'

    GROUP BY
        bc.CopyID,
        b.Title
    ORDER BY 
        b.Title;
END;

EXEC SearchBookCopies N'Dế Mèn';
EXEC SearchBookCopies N'kim đồng';
EXEC SearchBookCopies N'Tô Hoài';


SELECT
    ba.BookAuthorID,
    ba.BookID,
    b.Title,
    ba.AuthorID,
    a.FullName
FROM BookAuthors ba
    JOIN Authors a ON a.AuthorID = ba.AuthorID
    JOIN Books b ON b.BookID = ba.BookID
ORDER BY ba.BookAuthorID DESC
GO

SELECT
    l.LoanID,
    l.CopyID,
    b.Title,
    m.FullName,
    u.FullName,
    l.LoanDate,
    l.DueDate,
    l.ReturnDate,
    l.Status
FROM Loans l
    JOIN BookCopies bc ON bc.CopyID = l.CopyID
    JOIN Books b ON b.BookID = bc.BookID
    JOIN Members m ON m.MemberID = l.MemberID
    LEFT JOIN Users u ON u.UserID = l.UserID;


SELECT
    u.UserID,
    u.FullName,
    r.RoleName
FROM Users u
    JOIN Roles r ON r.RoleID = u.RoleID
GO

CREATE PROCEDURE SearchUsers
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        u.UserID,
        u.FullName,
        r.RoleName
    FROM Users u
        JOIN Roles r ON r.RoleID = u.RoleID
    WHERE 
        @SearchTerm IS NULL OR
        u.UserID LIKE '%' + @SearchTerm + '%' OR
        u.FullName LIKE '%' + @SearchTerm + '%' OR
        r.RoleName LIKE '%' + @SearchTerm + '%' OR
        u.Email LIKE '%' + @SearchTerm + '%' OR
        u.Username LIKE '%' + @SearchTerm + '%'
    ORDER BY u.UserID DESC;
END;

EXEC SearchUsers N'USER001';
EXEC SearchUsers N'Thủ thư';
EXEC SearchUsers N'Nguyễn';
GO


CREATE PROCEDURE SearchMembers
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM
        Members m
    WHERE 
        @SearchTerm IS NULL OR
        m.MemberID LIKE '%' + @SearchTerm + '%' OR
        m.DateOfBirth LIKE '%' + @SearchTerm + '%' OR
        m.FullName LIKE '%' + @SearchTerm + '%' OR
        m.Email LIKE '%' + @SearchTerm + '%' OR
        m.Phone LIKE '%' + @SearchTerm + '%' OR
        m.Address LIKE '%' + @SearchTerm + '%'
    ORDER BY 
        m.MemberID DESC;
END;

EXEC SearchMembers N'MEM001';
EXEC SearchMembers N'Nguyễn';

SELECT *
FROM Members
ORDER BY MemberID DESC;


SELECT *
FROM BookAuthors

SELECT *
FROM Books

DELETE FROM Books
WHERE BookID='BOOK001';

UPDATE BookAuthors
SET AuthorID = 'AUTH005'
WHERE BookAuthorID = 1;

SELECT *
FROM BookAuthors
WHERE BookID = 'BOOK014'

UPDATE BookAuthors SET BookID = 'BOOK008', AuthorID = 'AUTH009' WHERE BookAuthorID = 2
GO

CREATE PROCEDURE SearchFines
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        f.FineID,
        f.LoanID,
        m.FullName,
        f.Amount
    FROM
        Fines f
        JOIN Loans l ON f.LoanID = l.LoanID
        JOIN Members m ON l.MemberID = m.MemberID
    WHERE 
        @SearchTerm IS NULL OR
        f.FineID LIKE '%' + @SearchTerm + '%' OR
        m.FullName LIKE '%' + @SearchTerm + '%' OR
        l.LoanDate LIKE '%' + @SearchTerm + '%' OR
        l.DueDate LIKE '%' + @SearchTerm + '%' OR
        l.ReturnDate LIKE '%' + @SearchTerm + '%'
    ORDER BY 
        f.FineID DESC;
END;

EXEC SearchFines N'FINE007';
EXEC SearchFines N'Nguyễn';
GO

SELECT *
FROM Fines


SELECT
    f.FineID AS MaPhieuPhat,
    f.LoanID AS MaPhieuMuon,
    u.FullName AS TenhanhVien,
    f.Amount AS SoTien
FROM Fines f
    JOIN Users u ON u.UserID = f.LoanID
ORDER BY f.FineID DESC


SELECT
    f.FineID,
    f.LoanID,
    m.FullName,
    f.Amount
FROM Fines f
    JOIN Loans l ON l.LoanID=f.LoanID
    JOIN Members m ON m.MemberID=l.MemberID
ORDER BY f.FineID DESC

SELECT *
FROM Fines
GO

CREATE PROCEDURE SearchLoans
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        l.LoanID,
        l.CopyID,
        b.Title,
        m.MemberID,
        m.FullName,
        u.FullName,
        l.LoanDate,
        l.DueDate,
        l.ReturnDate,
        l.[Status]
    FROM
        Loans l
        JOIN Users u ON u.UserID = l.UserID
        JOIN BookCopies bc ON bc.CopyID = l.CopyID
        JOIN Books b ON b.BookID = bc.BookID
        JOIN Members m ON m.MemberID = l.MemberID
    WHERE 
        @SearchTerm IS NULL OR
        l.LoanID LIKE '%' + @SearchTerm + '%' OR
        b.Title LIKE '%' + @SearchTerm + '%' OR
        m.MemberID LIKE '%' + @SearchTerm + '%' OR
        m.FullName LIKE '%' + @SearchTerm + '%' OR
        u.FullName LIKE '%' + @SearchTerm + '%' OR
        l.LoanDate LIKE '%' + @SearchTerm + '%' OR
        l.DueDate LIKE '%' + @SearchTerm + '%' OR
        l.ReturnDate LIKE '%' + @SearchTerm + '%' OR
        l.[Status] LIKE '%' + @SearchTerm + '%'
    ORDER BY 
        l.LoanID DESC;
END;

EXEC SearchLoans N'LOAN001';
EXEC SearchLoans N'Nguyễn';

SELECT
    l.LoanID AS MaMuon,
    l.CopyID AS MaBanSao,
    b.Title AS TenSach,
    m.MemberID AS MaThanhVien,
    m.FullName AS TenThanhVien,
    u.FullName AS TenNhanVien,
    l.LoanDate AS NgayMuon,
    l.DueDate AS HanTra,
    l.ReturnDate AS NgayTra,
    l.Status AS TrangThai
FROM Loans l
JOIN BookCopies bc ON bc.CopyID = l.CopyID
JOIN Books b ON b.BookID = bc.BookID
JOIN Members m ON m.MemberID = l.MemberID
LEFT JOIN Users u ON u.UserID = l.UserID
WHERE l.UserID = 'USER020'
ORDER BY LoanID DESC

        -- public string? MaMuon { get; set; }
        -- public string? MaBanSao { get; set; }
        -- public string? TenSach { get; set; }
        -- public string? MaThanhVien { get; set; }
        -- public string? TenThanhVien { get; set; }
        -- public string? TenNhanVien { get; set; }
        -- public DateTime NgayMuon { get; set; }
        -- public DateTime HanTra { get; set; }
        -- public DateTime? NgayTra { get; set; }
        -- public string? TrangThai { get; set; }

INSERT INTO Loans
    ([LoanID], [CopyID], [MemberID], [UserID],[LoanDate], [DueDate], [ReturnDate], [Status], [Notes])
VALUES
    ('LOAN030', 'COPY005', 'MEM001', 'USER020', '2024-06-20 10:00:00', '2024-07-04 10:00:00', NULL, N'Đang mượn', NULL),
    ('LOAN031', 'COPY003', 'MEM003', 'USER020', '2024-06-25 11:30:00', '2024-07-09 11:30:00', NULL, N'Đang mượn', NULL),
    ('LOAN032', 'COPY004', 'MEM005', 'USER020', '2024-06-28 14:00:00', '2024-07-12 14:00:00', NULL, N'Đang mượn', NULL)

SELECT *
FROM Loans