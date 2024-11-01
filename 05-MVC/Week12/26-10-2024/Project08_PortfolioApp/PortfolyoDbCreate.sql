use master
GO

if DB_ID('PortfolyoDb') IS NOT NULL
BEGIN
    ALTER DATABASE PortfolyoDb set single_user with ROLLBACK IMMEDIATE
    DROP DATABASE PortfolyoDb
END
GO
CREATE DATABASE PortfolyoDb COLLATE Turkish_CI_AS
GO

use PortfolyoDb
go

CREATE table AppSettings(
    Id int PRIMARY KEY IDENTITY,
    BrandName NVARCHAR(100) not NULL,
    HeroTitle NVARCHAR(200) not NULL,
    HeroSubTitle NVARCHAR(300) not NULL,
    HeroImageUrl NVARCHAR(1000) NOT NULL,
    AboutText NVARCHAR(3000) not NULL,
    AboutImageUrl NVARCHAR(1000) not NULL,
    SkillsImageUrl NVARCHAR(1000) NOT NULL,
    AddressText NVARCHAR(500) not NULL,
    AddressDistrict NVARCHAR(100) NOT NULL,
    AddressCity NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(50) not NULL,
    Email NVARCHAR(100) not NULL,
    GoogleMap NVARCHAR(1000) not NULL,
    CreatedDate DATETIME NOT NULL DEFAULT getDate(),
    ModifiedDate DATETIME 
)
GO

INSERT into AppSettings(BrandName, HeroTitle,HeroSubTitle,HeroImageUrl,AboutText,AboutImageUrl,SkillsImageUrl,AddressText,AddressDistrict,AddressCity,PhoneNumber,Email,GoogleMap)

VALUES 
    (
        'Kemal Kodyazar',
        'Backend Developer',
        'Dotnet | Asp.Net Core MVC | Asp.Net Core WebAPI',
        'http://localhost:5100/ui/img/hero-img.png',
        ' <p>Acunmedya Akademi''de aldığım yazılım eğitimi sırası ve sonrasında yaptığım çalışmalarla kendimi geliştirdim. Hem backend hem frontend alanında bilgi sahibi olmama rağmen, kendimi backend tarafında geliştiriyorum.</p>
    <h4>Eğitim Aldığım Konular</h4>
    <ul>
        <li>C#</li>
        <li>OOP</li>
        <li>HTML, CSS, JS</li>
        <li>Entity Framework Core</li>
    </ul>',
    'c:\Users\tunacan\Documents\GitHub\BackendBootcampDersler\05-MVC\Week12\26-10-2024\Project08_PortfolioApp\wwwroot\ui\img\about-img.png',
    '!c:\Users\tunacan\Documents\GitHub\BackendBootcampDersler\05-MVC\Week12\26-10-2024\Project08_PortfolioApp\wwwroot\ui\img\skills-img.png',
    'Cemal Reşit Rey Yolu, Medium Plaza K:4',
    'Kadıköy',
    'İstanbul',
    '90 555 458 52 45',
    'info@kemalkodyazar.com',
    'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3012.862199311377!2d29.105485475511504!3d40.96259752223722!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cabbe7eee803fb%3A0x2f64ecd26d22527a!2sYowa%20Academy!5e0!3m2!1str!2str!4v1729941831623!5m2!1str!2str',

    )
    GO

    CREATE TABLE Socials (
        Id int PRIMARY KEY IDENTITY,
        Name NVARCHAR(50) not NULL,
        Url NVARCHAR(500) not NULL,
        Icon NVARCHAR(20) not NULL,
        IsActive bit not NULL DEFAULT getDate(),
        CreatedDate DATETIME NOT NULL DEFAULT getDate(),
        ModifiedDate DATETIME 
)
GO

INSERT into Socials(Name, Url, Icon)
VALUES
    ('Github', 'https://www.github.com', 'github'),
    ('Linkedin', 'https://www.linkedin.com', 'linkedin'),
    ('Medium', 'https://www.medium.com', 'medium'),
    ('Facebook', 'https://www.facebook.com', 'facebook')

    GO  

    CREATE TABLE Skills(
        Id int PRIMARY KEY IDENTITY,
        Name NVARCHAR(50) not NULL,
        Rate TINYINT not NULL,
        IsActive bit not NULL DEFAULT getDate(),
        CreatedDate DATETIME NOT NULL DEFAULT getDate(),
        ModifiedDate DATETIME 
    )

    GO

    INSERT into Skills(Name,Rate)
    VALUES
        ('Html', 100),
        ('Css', 95),
        ('JavaScript', 90),
        ('AspNet Core MVC', 85)
GO

CREATE TABLE Services(
        Id int PRIMARY KEY IDENTITY,
        Title NVARCHAR(50) not NULL,
        Description NVARCHAR(500) not NULL,
        Icon NVARCHAR(20) not NULL,
        IsActive bit not NULL DEFAULT getDate(),
        CreatedDate DATETIME NOT NULL DEFAULT getDate(),
        ModifiedDate DATETIME 
)
GO

INSERT into Services(Title, Description, Icon)
VALUES
    ('SEO Hizmeti', 'Arama motoru optimizasyonu', 'activitiy'),
    ('Web uygulamaları', 'İSteğe özel web uygulamaları geliştirme', 'bounding-box-circles icon'),
    ('Server Yönetimi', 'Sunucuların bakım ve onarımının yapılması', 'calendar4-week icon'),
    ('SPA', 'Single Page Application uygulamalarının geliştirilmesi', 'broadcast icon')
GO

CREATE TABLE Categories(
      Id int PRIMARY KEY IDENTITY,
        Name NVARCHAR(50) not NULL,
        IsActive bit not NULL DEFAULT getDate(),
        CreatedDate DATETIME NOT NULL DEFAULT getDate(),
        ModifiedDate DATETIME 
)
GO

INSERT into Categories(Name)
VALUES('MVC'),('Frontend'),('API')
GO

CREATE TABLE Projects(
        Id int PRIMARY KEY IDENTITY,
        Name NVARCHAR(50) not NULL,
        Description NVARCHAR(500) not NULL,
        GithubUrl NVARCHAR(1000) NOT NULL,
        ImageUrl NVARCHAR(1000) NOT NULL,
        IsActive bit not NULL DEFAULT getDate(),
        CreatedDate DATETIME NOT NULL DEFAULT getDate(),
        ModifiedDate DATETIME ,
        CategoryId int FOREIGN KEY REFERENCES Categories (Id)
)
go

insert into Projects(Name, Description,GithubUrl,ImageUrl)
VALUES
    ('Proje1', 'Proje 1 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project1.jpg' ),
    ('Proje1', 'Proje 2 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project2.jpg' ),
    ('Proje1', 'Proje 3 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project3.jpg' ),
    ('Proje1', 'Proje 4 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project4.jpg' ),
    ('Proje1', 'Proje 5 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project5.jpg' ),
    ('Proje1', 'Proje 6 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project6.jpg' ),
    ('Proje1', 'Proje 7 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project7.jpg' ),
    ('Proje1', 'Proje 8 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project8.jpg' ),
    ('Proje1', 'Proje 9 Açıklaması', 'https://www.github.com/project1','https://localhost:5100/ui/img/projects/project9.jpg' ),