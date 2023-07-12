# ApiJobOpportunity
This is a repository about a job search with .net core 3.1.
The service consumes an external service, sends subscriptions for registered users and saves the data in memory.
##

Endpoints:
https://localhost:5001/api/v1/JobOpportunity/suscriptions - POST
Add user:
```
{
	"id": 6,
	"username": "other",
	"email": "agusfas_5@hotmail.com",
	"InterestPositionsName": "Database Analyst"
}
```
https://localhost:5001/api/v1/JobOpportunity/suscriptions/user - GET

https://localhost:5001/api/v1/JobOpportunity - POST

Add opportunity:
```
{
	"id": 1,
	"name": "Database Analyst",
	"country": "Argentina",
	"salary": 1545
}
```

https://localhost:5001/api/v1/JobOpportunity?name=Database Analyst - GET with filters.

To run the project:
```
dotnet run
```

	
