# NginxAndMicroservices
Este repositorio tiene un docker compose que levanta un docker para un nginx y cuatro dockers con sus apis rest.
![Alt text](image.png)

Local build 💻
Run command where is the docker-compose.yml file. In /NinxWeb

```
docker-compose up -d
```
Docker build
```
docker-compose up --build
```

Docker status view:
```
docker container ps
```

Paths: http://localhost:6001/
- ApiOne: /api/v1/pets - GET
- ApiTwo: api/v2/countries - GET
- ApiThree: api/v3/ipa - GET
- ApiFour: api/v4/random - GET