# 👨‍💻 Cooked To Order RESTful Web Api 👨‍💻
Bu proje, bir butik otel müşterilerinin otel odalarından yemek siparişi verebilmelerini sağlamak için bir RESTful API geliştirmeyi amaçlamaktadır. API, otel müşterilerinin yemek menüsünden seçim yapmalarını ve siparişlerini kolayca oluşturmalarını sağlar.


🟠Proje hakkında özet bilgi :

• Entity Framework, Software Architecture, NLog, Global Error Handling, Auto Mapper, Validation, Action Filter projemde tamamlanan kısımsınlar.

• Gelişmiş ve olgunlaşmış bir Web Api için içinde barındırdığı sayfalama, filtreleme, sıralama ve içerik pazarlığı olmak üzere Api güvenliği, ön belleğe alma, hız sınırlandırma gibi pek çok yapıyı içinde barındıran ileri düzey bir Web Api geliştirme aşamasında.

• Web api için Asp.Net Core 7.0 Versionunu kullanarak Katmanlı mimari üzerinde projeyi oluşturup, geliştirdim.


📌 Proje Açıklamaları 

📌 1 - Entity Framework Core 
• Entity Framework Core .Net nesneleri kullanarak bir veri tabanıyla çalışmaya olanak tanıyan ve Microsoft tarfından geliştirilmiş bir ORM teknolojisi aracıdır.
• Genel olarak yazılması gereken veri erişim kodunun çoğuna olan ihtiyacı ortadan kaldırır ve otomatik üretir.
• Bu projede SQL veri tabanı için CodeFirst yaklaşımı ile EF Core'un sağlamış olduğu yapıları kullanarak veri tabanı işlemlerimi tamamlamış oldum.

📌 2 - Yazılım Mimarisi (Software Architecture) 
• N-tier Architecture mimarisi ile 'Entities', 'Presentation', 'Repositories', 'Services', 'Core', 'Api' katmanları ile uygulamanın yönetimi geliştirdim.

📌 3 - NLog Uygulaması (NLog Implementation) 
• NLog kütüphanesini mimariye dahil ederek loglama işlemlerini gerçekleştirdim.

📌 4 - Global Hata Yönetimi (Global Error Handling) 
• Hatalı istek(Request) atıldığında Global Hata yönetimi ile yazmış olduğumuz Custom Error Messages bize göstererek çözüme daha hızlı ulaşmamızı sağlamaktadır.

📌 5 - AutoMapper 
• İki nesneyi birbirine eşleyen karmaşık koddan kurtulmak için AutoMapper kullandım.

📌 7 - Doğrulama (Validation) 
• Veri manipulasyonu yaptığımız zaman tanımladığımız bir dizi kural setinin ilgili varlıklar üzerinde uygulanmasını sağlamaktadır.
• Client ile Server arasında data alışverişi gerçekleşeceği zaman bu veriler üzerinde tanımladığımız kuralların geçerli olup olmadığını kontrol etmemize olanak sağlar.

📌 9 - Eylem Filtreleri (Action Filters) 
• Action Filter yapısı kullanarak global seviye de Log alma ve action seviyesinde Validation işlemlerini geçekleştirdim.


