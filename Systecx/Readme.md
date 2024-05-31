Systecx MiniAssignment

The project was created using .NET 6 and MySql 8.0

Customer REST APIs

GET - /customers/count - Display the total number of customers
GET - /customers       - Display the details of each customer

Suuplier REST APIs

GET - /suppliers/count - Display the total number of suppliers
GET - /suppliers       - Display the details of each supplier

Meeting REST APIs

GET - /meetings/count - Display the total number of meetings
GET - /meetings       - Display the details of each meeting

Transaction REST APIs

GET - /transactions/{id} - Display the statuses associated with each transaction


MicroServices Architecture

The project used microservices architecture to create each of the modules: Customer, Supplier, Meeting and Transaction.
Each Microservice has the following components:
	Model 
	DataBase Context
	Services
	Repository and
	Controller

It includes CRUD operations
It uses best practices and SOLID principles
It uses EntitiyFramework Core


Repository Pattern

It has two purpose it is an abstration of data layer and it is a way to centralize handling the domain object. 
It is like a middle layer between the application and data access logic. It makes code easy to maintain and test.


API Gateway

This pattern is a service provides a single-entry point into the certain groups of microservices. 
It is similar to Facade pattern from object-oriented desing, in this case it is a part of a distributed system.


Ocelot API Gateway

It is a Lightweight API Gateway that recommended for simpler approches. Ocelot is an Open Source API Gateway built using .NET Core. 
It is aimed at microservices architectures where there is a need for a unified entry point into the system.
It is lightweight, fast, scalable and provides routing, filtering, caching, authentication, rate limiting and load balancing out of the box. 
The main reason to choose Ocelot for our reference application is because it is a lightweight .NET Core API Gateway. It is easy to use and configure.