# MassTransit-RabbitMQ-Observer-SpecificationFilter



# MassTransit RabbitMQ Observer Örnekleri

Bu projede, **MassTransit** ve **RabbitMQ** kullanılarak observer tasarım deseni üzerinde örnekler geliştirilmiştir. Observer'lar, belirli olayları dinlemek ve bu olaylar gerçekleştiğinde tepki vermek amacıyla kullanılır.

## İçerik

- **Observer Tasarım Deseni**: MassTransit ile çeşitli olayları dinleyen ve bu olaylara tepki veren observer örnekleri.
- **RabbitMQ Entegrasyonu**: MassTransit kullanarak RabbitMQ üzerinden mesajları yönetme ve işleme.
- **Örnek Observer'lar**: Mesajların işlenmesi, hatalar ve tamamlanma durumlarını ele alan observer örnekleri.

## Kullanım

1. Projeyi klonlayın:
    ```bash
    git clone [https://github.com/kullanici_adiniz/proje_adi.git](https://github.com/yilmazolmez/MassTransit-RabbitMQ-Observer-SpecificationFilter.git)
    cd proje_adi
    ```

2. Bağımlılıkları yükleyin:
    ```bash
    dotnet restore
    ```

3. Uygulamayı çalıştırın:
    ```bash
    dotnet run
    ```

4. RabbitMQ Management Console'a erişin:
    - `http://localhost:15672` adresine gidin.
    - Varsayılan kullanıcı adı ve şifre `guest` / `guest`'tır.

