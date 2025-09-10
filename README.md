# Triangle Drawer App

 Konsol tabanlı bir C# uygulamasıdır. Kullanıcıdan alına boyut bilgisine göre **sağ, sol, ters sağ, ters sol ve eşkenar üçgenleri** konsola çizer. Uygulama **Single Responsibilty Principle (SRP)** ve Kod tekrarını önleme prensiplerine uygun olarak tasarlanmıştır.

## Özellikler
- Kullanıcıdan pozitif bir sayı ile üçgen boyutu alma.
- Sağ açılı üçgen çizme
- Sol açılı üçgen çizme
- Ters sağ açılı üçgen çizme
- Ters sol açılı üçgen çizme
- Eşkenar Üçgen Çizme
- Kod tekrarında nkaçınmak için metot ve sınıf ayrımı.

## Sınıflar ve Sorumluluklar
- **InputHandler**: Kullanıcıdan veri alır.
- **TriangleDrawer** : Üçgenleri çizer.
- **Program**: Uygulamanın ana akışını yönetir.

## Gereksinimler
- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) veya üstü.

## Kurulum ve Çalıştırma
1. Projeyi klonlayın veya indirin:
    ```bash
     git clone <repo-link>
     cd TriangleApp
2. Konsol Uygulamasını Çalıştırın
   ```bash
   dotnet run
3. Ekranda İstenen Üçgen boyutunu girin.


   

