<h2>Technologies I used in this project</h2>
<ul>
   <li>.Net 7.0 Microservice Architecture</li>
  <li>Asynchronous and Aynchronous between Microservices</li>
  <li>API Gateway ( Ocelot Libarary)</li>
  <li>RabbitMQ</li>
  <li>Docker & Docker Compose</li>
  <li>IdentityServer4</li>
  <li>JWT configuration</li>
  <li>AccessToken/RefreshToken</li>
  <li>Domain Driven Design</li>
  <li>AutoMapper Library</li>
  <li>Dapper</li>
  <li>CQRS Pattern</li>
  <li>PostgreSQL</li>
  <li>MongoDB</li>
  <li>SqlServer</li>
  <li>Swagger</li>
</ul>  

<h2>Microservices</h2>
<dl>
  <h4>Catalog Microservice</h4>
  <dd>Our microservice that will be responsible for holding and presenting information about our courses.</dd>
  <dd>
  <li>MongoDb (Database)</li>
  <li>One-To-Many/One-To-One relationship</li>
  </dd>
</dl>
<br>
<dl>
  <h4>Basket Microservice</h4>
  <dd>Our microservice that will be responsible for basket operations.</dd>
  <dd>
  <li>RedisDB(Database)</li>
  </dd>
</dl>
<br>
<dl>
  <h4>Discount Microservice</h4>
  <dd>Our microservice that will be responsible for the discount coupons that will be defined to the user.</dd>
  <dd>
  <li>PostgreSQL(Database)</li>
  </dd>
</dl>
<br>
<dl>
  <h4>Order Microservice</h4>
  <dd>Our microservice that will be responsible for order processing.</dd>
  <dd>
  <li>Sql Server(Database)</li>
  <li>Domain Driven Design</li>
  <li>CQRS (MediatR Library)</li>
  </dd>
</dl>
<br>
<dl>
  <h4>FakePayment Microservice</h4>
  <dd>Our microservice that will be responsible for payment processing.</dd>
</dl>
<br>
<dl>
  <h4>IdentityServer Microservice</h4>
  <dd>Our microservice that will be responsible for keeping user data, generating tokens and refresh tokens.</dd>
  <dd>
  <li>Sql Server(Database)</li>
  </dd>
</dl>
<br>
<dl>
  <h4>PhotoStock Microservice</h4>
  <dd>Our microservice that will be responsible for keeping and presenting course photos.</dd>
</dl>
<br>
<dl>
  <h4>API Gateway</h4>
  <dd>
  <li>Ocelot Library</li>
  </dd>
</dl>
<br>
<dl>
  <h4>Message Broker</h4>
  <dd>
  <li>I used RabbitMQ as message queue system</li>
  <li>I used MassTransit library to communicate with RabbitMQ</li>
  <li>RabbitMQ (MassTransit Library)</li>
  </dd>
</dl>
<br>
<dl>
  <h4 style="color:red;">Identity Server</h4>
  <dd>
  <li>Generating Token / RefreshToken</li>
  <li>Protecting our microservices with Access Token</li>
  <li>Building a structure in accordance with OAuth 2.0 / OpenID Connect protocols</li>
  </dd>
</dl>
<br>
<dl>
  <h4>Asp.Net Core MVC Microservice</h4>
  <dd>Our UI microservice, which will display the data received from microservices to the user and be responsible for interacting with the user.</dd>
 <dd><a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Frontend--.NETCore7.0">ECommerce--Services</a></dd>
</dl>
<br>
<br>
<br>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/0b193a33-f5eb-4f01-b1e0-366a462b774d" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/0b193a33-f5eb-4f01-b1e0-366a462b774d"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/37c84244-6db7-43ff-b8cc-f599b2aee71c" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/37c84244-6db7-43ff-b8cc-f599b2aee71c"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/9f3d8d56-880a-449d-9b12-a81557e16931" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/9f3d8d56-880a-449d-9b12-a81557e16931"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/8f314a6b-9c8a-4f7c-9212-5f1bb5083be5" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/8f314a6b-9c8a-4f7c-9212-5f1bb5083be5"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/a56e75b0-8ca6-4067-9ffc-9902e888c223" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/a56e75b0-8ca6-4067-9ffc-9902e888c223"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/cad40bdf-db28-457b-a909-80cbcfe5f5cb" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/cad40bdf-db28-457b-a909-80cbcfe5f5cb"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/42560711-5f2f-412d-8437-66c4bc5efe0a" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/42560711-5f2f-412d-8437-66c4bc5efe0a"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/859e696f-ca54-407c-880d-60429f974d47" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/859e696f-ca54-407c-880d-60429f974d47"/>
</a>
<a href="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/d7b66939-a907-4161-b6eb-94ecf4245033" target="_blank">
<img width="350" height="220" style="border-radius:2%;" src="https://github.com/Firatalbayati/E-Commerce--Microservices-Backend--.NETCore7.0/assets/47159612/d7b66939-a907-4161-b6eb-94ecf4245033"/>
</a>
