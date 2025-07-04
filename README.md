
# Library Automation 🇬🇧

## Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Admin Panel](#admin-panel)

# About the Project

This software is a library automation system developed to track and manage all operations in a library. The program is managed by staff, and users appear as if they are already registered online.

## Features

### 1. **Staff Registration and Authorization**
- **Staff Registration:** When a staff member registers, their account is created with authority level `1` (inactive). The admin account (Username: Hamza, Password: Admin) must log in and set the authority to `2` (active) for the staff to be able to log in.
- **Caps Lock Warning:** The system warns the user if Caps Lock is on during login and registration.

### 2. **User Loan Transactions**
- **Loaning Books:** The staff searches for the user by their national ID number (TC Kimlik No). When selecting a book, the barcode is entered manually (not scanned). The system records the book name, user name, national ID, loan date, and return date.
- **Stock Management:** When a book is loaned, it is deducted from the stock. When returned, it is added back.

### 3. **Loan Return**
- **Returning Books:** Loans are returned via the loan return screen. There is no loan history kept for any user (this can be improved in the future).

### 4. **Overdue Books**
- **Overdue Tracking:** Overdue and non-overdue books are listed separately. Currently, only listing is available. Payment system and advanced tracking can be added in the future.

### 5. **Book Information and Stock**
- **Book Details:** Books are registered with the following information:
  - Barcode
  - Book Name
  - Author
  - Page Count
  - Shelf Number
  - Stock Amount

### 6. **User Information and Management**
- **User Listing:** All users in the system can be viewed. No loan history is kept for users (this can be improved).
- **User Management:** Staff can update, delete, or add new users. Staff accounts must be authorized by the admin to log in.

---


### Requirements
- **.NET Framework 4.7.2 or higher**
- **Microsoft Access**
- **To run and use the project, [Access Database Engine](https://www.microsoft.com/en-us/download/details.aspx?id=54920) must be installed.**

---

## User Interface

### 1. Registration Screen
Staff register via the system. After registration, the admin must authorize the account. Caps Lock warning is shown if active.

### 2. Login Screen
Username: Hamza, Password: Admin. Caps Lock warning is shown if active.

### 3. Loaning Books
User is searched by national ID, book is selected by entering the barcode. Loan and return dates are recorded, and stock is updated accordingly.

### 4. Loan Return
Loans are returned; no user loan history is kept.

### 5. Overdue Books
Overdue and non-overdue books are listed separately.

---


# Kütüphane Otomasyonu 🇹🇷

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Admin Paneli](#admin-paneli)

# Proje Hakkında

Bu yazılım, bir kütüphanedeki tüm işlemleri takip etmek ve yönetmek için geliştirilmiş bir otomasyon sistemidir. Program, personel tarafından yönetilir ve kullanıcılar internet üzerinden hazır bir şekilde kaydolmuş gibi işlem yapar.

## Özellikler

### 1. **Personel Kayıt ve Yetkilendirme**
- **Personel Kayıt:** Personel kayıt olduğunda hesabı `1` (pasif) yetkiyle oluşturulur. Admin hesabı (Kullanıcı adı: Hamza, Şifre: Admin) giriş yapıp personele `2` (aktif) yetki vermelidir, aksi takdirde personel giriş yapamaz.
- **Caps Lock Uyarısı:** Giriş ve kayıt ekranlarında Caps Lock açıkken kullanıcıya uyarı verilir.

### 2. **Kullanıcı Emanet İşlemleri**
- **Emanet Verme:** Personel, kullanıcıyı TC kimlik numarası ile arar ve bulur. Kitap seçerken barkod numarası yazılır (okutulmaz). Kitap adı, kullanıcı adı, TC kimlik numarası, verildiği tarih ve alınacağı tarih kaydedilir.
- **Stoktan Düşürme:** Emanet verilen kitap stoktan düşer, geri alındığında tekrar eklenir.

### 3. **Emanet Geri Alma**
- **Emanet Geri Alınması:** Emanetler, emanet alma ekranında geri alınır. Herhangi bir kullanıcıya ait emanet geçmişi tutulmaz (geliştirilebilir).

### 4. **Geçikmiş Kitaplar**
- **Geçikme Takibi:** Geçiken ve gecikmeyen kitaplar ayrı ayrı listelenir. Şu an için sadece listeleme yapılmaktadır. Ödeme sistemi ve gelişmiş takip ileride eklenebilir.

### 5. **Kitap Bilgileri ve Stok**
- **Kitap Bilgileri:** Kitaplar aşağıdaki bilgilerle kaydedilir:
  - Barkod
  - Kitap Adı
  - Yazar
  - Sayfa Sayısı
  - Raf Sayısı
  - Stok Miktarı

### 6. **Kullanıcı Bilgileri ve Yönetimi**
- **Kullanıcı Listeleme:** Sistemdeki tüm kullanıcılar görüntülenebilir. Kullanıcıya ait emanet geçmişi tutulmaz (geliştirilebilir).
- **Kullanıcı Yönetimi:** Personel, kullanıcı bilgilerini güncelleyebilir, silebilir veya yeni kullanıcı ekleyebilir. Personel hesabı admin tarafından yetkilendirilmeden giriş yapamaz.

---


### Gereksinimler
- **.NET Framework 4.7.2 ve üzeri**
- **Microsoft Access**
- **Projeyi çalıştırmak ve kullanmak için [Access Database Engine](https://www.microsoft.com/en-us/download/details.aspx?id=54920) kurulmuş olmalıdır.**

---

## Kullanıcı Arayüzü

### 1. Kayıt Ekranı
Personel, sistem üzerinden kaydolur. Kayıt sonrası admin tarafından yetki verilmelidir. Caps Lock açıkken uyarı verilir.

### 2. Giriş Ekranı
Kullanıcı adı: Hamza, Şifre: Admin. Caps Lock açıkken uyarı verilir.

### 3. Emanet Verme
Kullanıcı TC kimlik numarası ile aranır, kitap barkod numarası yazılarak seçilir. Emanet ve iade tarihleri kaydedilir, stok güncellenir.

### 4. Emanet Alma
Emanetler geri alınır, kullanıcıya ait emanet geçmişi tutulmaz.

### 5. Geçikmiş Kitaplar
Geciken ve gecikmeyen kitaplar ayrı ayrı listelenir.
