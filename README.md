# KisiselWebProjesi
Asp.Net Mvc İle Kişisel Web Sitesi Entity FrameWork Code First Yapısı Kullanılarak Yapılmıştır.
Proje Yapımında Ana Sayfa Ve Admin Login Sayfasında Sadece Html Ve Css Kullanılmıştır. 
Admin Teması w3schools Sidebar Bölümünden Alınmış Ve Üzerinde Bir Kaç Değişiklik Yapılmıştır.
Admin Temasında Bootstrap CDN Eklenip Buton Ve Tablolar Bootstrap ile yapılmıştır.
# Projeden Görüntüler

**Ana Sayfa**
![Screenshot](https://user-images.githubusercontent.com/48470345/93139263-164a4380-f6e9-11ea-9a2f-67842371132e.png)

 **Admin Login Sayfası**
![Screenshot](https://user-images.githubusercontent.com/48470345/93140288-dbe1a600-f6ea-11ea-98a4-95059f0aef77.png)

 **Admin Panel Ana Sayfa**
![Screenshot](https://user-images.githubusercontent.com/48470345/93140369-fddb2880-f6ea-11ea-8e81-1fae3399ad50.png)

 **Admin Panel İkonlar Sayfası**
![Screenshot](https://user-images.githubusercontent.com/48470345/93140435-1c412400-f6eb-11ea-9d54-ab188097b071.png)

# Veri Tabanı Oluşturma
Veri Tabanın Oluşturmak İçin Web.Config Dosya Ayarlarındaki Data Source Kısmına Kendi Sql Serverınızı Yazmanız Gerekiyor.
Sonrasında Pacgake Manager Console Kısmına >Enabled-Migrations Yazıp Enter Tuşuna Basınız.
Oluşan Configurations Dosyası İçeriğini *AutomaticMigrationsEnabled = true;* Şeklinde Değiştiriniz.
Sonrasında *update-database* Yazıp Enter Tuşuna Basınız.
Bu İşlemleri Tam Olarak Yaptığınızda Veri Tabanı Oluşup Projeyi Başlattığınızda Proje Sorunsuz Çalışır.
