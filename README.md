# OnlineChat

Uygulamanın amacı; bu uygulama basit bir şekilde bir sohbet, mesajlaşma uygulamasıdır. Uygulama arayüzü içerisinde odalar ve bu odalara giriş kuralları tanımlanacaktır. Yeni üyeler temel seviye odalardan başlarken üst seviye odalara geçmek için odalarda yayınlanan anlık bilgi sorularını cevaplayarak puan biriktirmeleri beklenecektir. Diğer üst seviye odalara geçebilmek için bu puanları kullanacaklardır.  <br>

The purpose of the application; this app is simply a chat, messaging app. Rooms and entrance rules to these rooms will be defined in the application interface. While new members start from the basic level rooms, they will be expected to accumulate points by answering the instant information questions posted in the rooms in order to move on to the higher level rooms. They will use these points to move on to other higher level rooms. 



<hr>


Mimari Yapı - Architectural Building 

<h2>Core</h2> <br>
Proje alt yapısının tüm çekirdek sistemlerini içerir. Bu katman Cross Cutting Concern, Generic Repository, Jwt, Mail, RabbitMQ, Elastic Search vb. yapıların AOP yöntemleriyle ve/veya tek satırlık kodlarla hazır olarak sunulduğu ve sunulacağı katmandır.<br><br>

It includes all core systems of the project infrastructure.
This layer includes Cross Cutting Concern, Generic Repository, Jwt, Mail, RabbitMQ, Elastic Search etc. It is the layer where the structures are presented and presented ready-made with AOP methods and/or single-line codes. 

<h2>Entities</h2><br>
Projede kullanılan veritabanı varlık/modellerin temsil eden sınıfların kullanıldığı katmandır. <br><br>
The database used in the project is the layer where the classes representing the entities/models are used. 


<h2>DataAccess (Dal) </h2> <br>
Projenin veri erişim katmanıdır.<br><br>
It is the data access layer of the project

<h2>Business (Bll) </h2> <br>
Projede gerçekleşecek tüm iş kuralları ve uygulamaları bu katmanda yer almaktadır.<br><br>
All business rules and practices that will take place in the project are included in this layer. 
