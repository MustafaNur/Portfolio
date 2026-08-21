⚙️ Kurulum ve Çalıştırma Adımları
Projeyi kendi yerel ortamınızda ayağa kaldırmak için aşağıdaki adımları sırasıyla uygulayabilirsiniz:

Ön Gereksinimler
.NET 10 SDK

PostgreSQL Veritabanı Sunucusu

Tercihen Visual Studio 2022+ veya Visual Studio Code

Adım Adım Kurulum
Projeyi Klonlayın:

Bash
git clone [https://github.com/kullanici-adi/portfolio-yonetim-sistemi.git](https://github.com/kullanici-adi/portfolio-yonetim-sistemi.git)
cd portfolio-yonetim-sistemi
Veritabanı Bağlantısını Yapılandırın:
MyWebSiteUI/appsettings.json dosyasındaki connection string alanını kendi local PostgreSQL bilgilerinize göre güncelleyin:

JSON
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=PortfolioDb;Username=postgres;Password=sifreniz"
  }
}
Veritabanını Oluşturun (Migration):
Terminal veya Package Manager Console üzerinden veritabanı tablolarını aktarın:

Bash
dotnet ef database update --project DataAccess --startup-project MyWebSiteUI
Uygulamayı Çalıştırın:

Bash
dotnet run --project MyWebSiteUI
Uygulama yayına girdiğinde tarayıcınızdan https://localhost:7... adresine giderek projeyi görüntüleyebilirsiniz.

🖥️ Kullanım Rehberi
Ziyaretçi Sayfası (/): Tek sayfa (One-Page) düzeninde tasarlanmıştır. Hakkımda, Yetenekler, Deneyimler, Projeler ve İletişim bölümleri ViewComponent yapısıyla dinamik olarak yüklenir.

Admin Paneli (/Admin): ASP.NET Core Identity ile korunan yönetim ekranıdır. Yeni proje ekleme, yetenek güncelleme, mesaj okuma ve içerik düzenleme gibi tüm CRUD operasyonları bu alandan yürütülür.

📜 Lisans
Bu proje kişisel portföy sergileme ve geliştirme amacıyla tasarlanmıştır. Dilediğiniz gibi inceleyebilir, çatallayabilir (fork) ve kendi projenizde kullanabilirsiniz.
"""

with open("README.md", "w", encoding="utf-8") as f:
f.write(content)

print("README.md başarıyla oluşturuldu.")

Aşağıda projeniz için özel olarak hazırlanmış, tek parça ve eksiksiz **`README.md`** dosyasının Markdown içeriği yer almaktadır.

[file-tag: code-generated-file-0-1787254135428089621]

```markdown
# Portfolio Yönetim Sistemi

ASP.NET Core MVC ve PostgreSQL kullanılarak geliştirilmiş, N-Tier Architecture (Çok Katmanlı Mimari) ve Repository Design Pattern ilkelerine dayanan kişisel portföy ve içerik yönetim uygulamasıdır.

Bu proje, modern web geliştirme standartlarına uygun olarak tasarlanmış olup ziyaretçilere şık bir vitrin sunarken, yöneticilere ise Identity altyapısı ile korunan kapsamlı bir yönetim paneli (Admin Dashboard) sağlar.

---

## 💡 Proje Amacı ve Mimari Yaklaşım

Projenin temel amacı; kod tekrarını önleyen (**DRY**), sorumlulukların ayrıştırıldığı (**Separation of Concerns**) ve katmanlar arası bağımlılıkların en aza indirildiği (**Loose Coupling**) sürdürülebilir bir sistem kurmaktır.

- **Tek Sayfa (One-Page) Vitrin:** Ana sayfadaki Hakkımda, Yetenekler, Deneyimler, Projeler ve İletişim gibi bölümler `ViewComponent` yapısıyla modüler hale getirilmiştir. Böylece `HomeController` spagetti koda dönüşmez, her bileşen kendi verisini bağımsız olarak yönetir.
- **Güvenli Yönetim Paneli:** `/Admin` yetki alanında (Area) çalışan panelle tüm içerikler dinamik olarak eklenebilir, güncellenebilir veya silinebilir.

---

## 🚀 Öne Çıkan Özellikler

- **Çok Katmanlı Mimari (N-Tier Architecture):** Core, DataAccess, Business ve Presentation (UI) katmanları ile modüler yapı.
- **Generic Repository & Unit of Work Pattern:** Veritabanı CRUD (Create, Read, Update, Delete) işlemlerinin tek bir jenerik merkezden yönetimi.
- **Modüler UI (ViewComponent):** Tek sayfa vitrin mimarisinde esnek ve bileşen bazlı dinamik veri sunumu.
- **Katmanlı Doğrulama (FluentValidation):** İş kurallarının ve veri doğrulamalarının Business katmanında güvenli bir şekilde işlenmesi.
- **Güvenlik ve Yetkilendirme:** ASP.NET Core Identity altyapısı ile korunan Admin Paneli.
- **Modern Arayüz:** Ziyaretçi ve Admin tarafında Tailwind CSS ile responsive ve estetik tasarım.

---

## 🛠️ Teknolojiler ve Kütüphaneler

### **Back-End & Mimariler**
- **Framework:** .NET 10 / ASP.NET Core MVC
- **ORM:** Entity Framework Core 10
- **Veritabanı:** PostgreSQL (Npgsql.EntityFrameworkCore.PostgreSQL)
- **Kimlik Doğrulama:** ASP.NET Core Identity
- **Validasyon:** FluentValidation
- **Tasarım Desenleri:** N-Tier Architecture, Generic Repository Pattern, Dependency Injection (DI)

### **Front-End & UI**
- **Şablon Motoru:** Razor Views & ViewComponents
- **CSS Framework:** Tailwind CSS
- **İkonlar:** FontAwesome / Custom SVG

---

## 📐 Proje Yapısı ve Klasör Hiyerarşisi

```text
WebSite/
├── Core/                              # Temel Varlıklar ve Sözleşmeler (Interfaces)
│   ├── Entities/                      # Veritabanı Tablo Modelleri (About, Project, Skill vs.)
│   └── Interfaces/                    # Generic Repository ve Servis Arayüzleri
│
├── DataAccess/                        # Veritabanı Bağlantısı ve Veri Erişim Katmanı
│   ├── Context/                       # PortfolioContext (EF Core & Identity)
│   ├── Migrations/                    # PostgreSQL Migration Dosyaları
│   └── Repositories/                 # GenericRepository ve Somut Sınıflar
│
├── Business/                          # İş Mantığı ve Validasyon Katmanı
│   ├── Concrete/                      # Manager Sınıfları (ProjectManager, SkillManager vs.)
│   ├── Interfaces/                    # İş Katmanı Servis Arayüzleri
│   └── ValidationRules/               # FluentValidation Doğrulama Kuralları
│
├── MyWebSiteUI/                       # Sunum Katmanı (ASP.NET Core MVC)
│   ├── Areas/
│   │   └── Admin/                     # Admin Paneli (Area)
│   │       ├── Controllers/           # Admin CRUD Yönetim Controller'ları
│   │       ├── Views/                 # Admin Panel Arayüz Sayfaları
│   │       └── Views/Shared/          # Admin Layout ve Ortak Bileşenler
│   ├── Controllers/                   # Ziyaretçi Tarafı Controller'ları (HomeController vb.)
│   ├── Views/                         # Ziyaretçi Tarafı View ve ViewComponent'ler
│   ├── wwwroot/                       # Statik Dosyalar (CSS, JS, Görseller, Tailwind Output)
│   ├── Program.cs                     # DI Kayıtları ve Pipeline Ayarları
│   └── appsettings.json               # Veritabanı ve Uygulama Konfigürasyonu
└── dotnet-tools.json                  # Entity Framework Tools vb. Yerel Araç Tanımları
⚙️ Kurulum ve Çalıştırma Adımları
Projeyi kendi yerel ortamınızda ayağa kaldırmak için aşağıdaki adımları sırasıyla uygulayabilirsiniz:

Ön Gereksinimler
.NET 10 SDK

PostgreSQL Veritabanı Sunucusu

Tercihen Visual Studio 2022+ veya Visual Studio Code

Adım Adım Kurulum
Projeyi Klonlayın:

Bash
git clone [https://github.com/kullanici-adi/portfolio-yonetim-sistemi.git](https://github.com/kullanici-adi/portfolio-yonetim-sistemi.git)
cd portfolio-yonetim-sistemi
Veritabanı Bağlantısını Yapılandırın:
MyWebSiteUI/appsettings.json dosyasındaki connection string alanını kendi local PostgreSQL bilgilerinize göre güncelleyin:

JSON
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=PortfolioDb;Username=postgres;Password=sifreniz"
  }
}
Veritabanını Oluşturun (Migration):
Terminal veya Package Manager Console üzerinden veritabanı tablolarını aktarın:

Bash
dotnet ef database update --project DataAccess --startup-project MyWebSiteUI
Uygulamayı Çalıştırın:

Bash
dotnet run --project MyWebSiteUI
Uygulama yayına girdiğinde tarayıcınızdan https://localhost:7... adresine giderek projeyi görüntüleyebilirsiniz.

🖥️ Kullanım Rehberi
Ziyaretçi Sayfası (/): Tek sayfa (One-Page) düzeninde tasarlanmıştır. Hakkımda, Yetenekler, Deneyimler, Projeler ve İletişim bölümleri ViewComponent yapısıyla dinamik olarak yüklenir.

Admin Paneli (/Admin): ASP.NET Core Identity ile korunan yönetim ekranıdır. Yeni proje ekleme, yetenek güncelleme, mesaj okuma ve içerik düzenleme gibi tüm CRUD operasyonları bu alandan yürütülür.