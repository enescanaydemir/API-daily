İşte istediğiniz şekilde README.md dosyasını oluşturacak içerik:

# API-daily

API-daily, .NET Core kullanılarak ASP.NET ile geliştirilmiş, modüler ve katmanlı mimariye sahip bir web API uygulamasıdır. Bu proje, **ApiDaily.Api**, **ApiDaily.Data**, **ApiDaily.Entity**, **ApiDaily.Service**, ve **ApiDaily.Shared** katmanlarından oluşmaktadır.

## Proje Yapısı

- **ApiDaily.Api**: API katmanı; kullanıcıların taleplerini işler ve diğer katmanlarla iletişim kurar.
- **ApiDaily.Data**: Veri erişim katmanı; veritabanı işlemleri için kullanılır.
- **ApiDaily.Entity**: Entity katmanı; proje içerisindeki veri modellerini içerir.
- **ApiDaily.Service**: Servis katmanı; iş mantığı ve hizmet katmanını temsil eder.
- **ApiDaily.Shared**: Projede ortak kullanılan yardımcı sınıfları ve metodları içerir.

## Özellikler

- Katmanlı Mimari
- Modüler yapı
- Entity Framework Core ile Veritabanı işlemleri
- Dependency Injection (DI) desteği
- RESTful API tasarımı

## Gereksinimler

- **.NET SDK**: 6.0 veya daha üzeri
- **Visual Studio 2022** veya **VS Code**
- **SQL Server**: Veritabanı yönetimi için
- **Git**: Sürüm kontrol sistemi için

## Kurulum

1. **Proje deposunu klonlayın**:
   ```bash
   git clone https://github.com/enescanaydemir/API-daily.git
   cd API-daily

2.	Bağımlılıkları yükleyin:

    dotnet restore


3.	Veritabanını oluşturun:
    Veritabanını oluşturmak için migration işlemini başlatın ve güncelleyin:

    dotnet ef migrations add InitialMigration -s ApiDaily.Api -p ApiDaily.Data
    dotnet ef database update -s ApiDaily.Api -p ApiDaily.Data


4.	Proje ayarlarını yapılandırın:
    appsettings.json dosyasını açarak ConnectionStrings bölümünde kendi SQL Server bağlantı dizesini düzenleyin:

    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=.;Database=ApiDailyDb;Trusted_Connection=True;"
    }
    }


5.	Projeyi çalıştırın:

    dotnet run --project ApiDaily.Api



## Kullanım

## API şu uç noktalara sahiptir:

## Örnek Uç Noktalar:
1.	GET /api/users - Tüm kullanıcıları listeler.
2.	POST /api/users - Yeni bir kullanıcı ekler.
3.	GET /api/products - Tüm ürünleri listeler.
4.	POST /api/products - Yeni bir ürün ekler.

## API’nin tam dökümantasyonuna ulaşmak için swagger arayüzünü kullanabilirsiniz:
	•	Swagger UI: http://localhost:5000/swagger

## Geliştirme
1.	Yeni bir özellik eklemek için:
	•	İlgili katmana (ör. Api, Data, Entity) gerekli değişiklikleri yapın.
	•	Tüm katmanların birbirine olan referanslarını kontrol edin.
2.	Unit Testler:
	•	Geliştirilen özellikler için testler yazmayı unutmayın. Test projeleri henüz oluşturulmamışsa, yeni bir test projesi ekleyebilirsiniz.

## Katkıda Bulunma
1.	Fork yapın: Projeyi kendi GitHub hesabınıza fork edin.
2.	Dal oluşturun: Yeni bir özellik eklemek için dal oluşturun.

git checkout -b yeni-ozellik


3.	Değişikliklerinizi yapın ve commit edin:

git commit -m "Yeni özellik eklendi"


4.	Pull Request gönderin: Ana depoya geri gönderin.
