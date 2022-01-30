# OnlineChat
Mimari Yapı

Core
Proje alt yapısının tüm çekirdek sistemlerini içerir. Bu katman Cross Cutting Concern, Generic Repository, Jwt, Mail, RabbitMQ, Elastic Search vb. yapıların AOP yöntemleriyle ve/veya tek satırlık kodlarla hazır olarak sunulduğu ve sunulacağı katmandır.

It includes all core systems of the project infrastructure.
This layer includes Cross Cutting Concern, Generic Repository, Jwt, Mail, RabbitMQ, Elastic Search etc. It is the layer where the structures are presented and presented ready-made with AOP methods and/or single-line codes. 

Entities
Projede kullanılan veritabanı varlık/modellerin temsil eden sınıfların kullanıldığı katmandır. 

The database used in the project is the layer where the classes representing the entities/models are used. 


DataAccess (Dal)
Projenin veri erişim katmanıdır.

It is the data access layer of the project

Business (Bll)
Projede gerçekleşecek tüm iş kuralları ve uygulamaları bu katmanda yer almaktadır.

All business rules and practices that will take place in the project are included in this layer. 
