# Ürün Yönetim Sistemi (ASP.NET Core MVC)

Bu proje, bir şirketin ürünlerini yönetmesini sağlayan basit bir ASP.NET Core MVC uygulamasıdır. Kullanıcılar sistem üzerinden ürünleri listeleyebilir, yeni ürün ekleyebilir, mevcut ürünleri düzenleyebilir, detaylarını görebilir ve silebilir.

## Kullanılan Teknolojiler

- ASP.NET Core MVC (.NET 8.0)
- Razor View Engine (cshtml)
- In-Memory veri yapısı (static list)
- Visual Studio 2022

## Özellikler

- Ürün listeleme (Index)
- Yeni ürün ekleme (Create)
- Ürün detaylarını görüntüleme (Details)
- Ürün düzenleme (Edit)
- Ürün silme (Delete)

## Projeyi Çalıştırmak İçin

1. Visual Studio 2022 ile projeyi açın.
2. `Program.cs` içinde `ProductController` açılış olarak ayarlanmıştır.
3. `Ctrl + F5` ile projeyi çalıştırın.
4. Açılan tarayıcıda ürün yönetimi sayfası görüntülenecektir.

## Dosya Yapısı
UrunYonetimSistemi/ │ ├── Controllers/ │ └── ProductController.cs ├── Models/ │ └── Product.cs ├── Views/ │ └── Product/ │ ├── Index.cshtml │ ├── Create.cshtml │ ├── Edit.cshtml │ ├── Details.cshtml │ └── Delete.cshtml ├── Program.cs ├── README.md


## 👤 Geliştirici

Bu proje YGA Nisan 2. Hafta Proje Ödevi kapsamında hazırlanmıştır.  
Geliştiren: Güler Yolcu

