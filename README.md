# Information

## Project structure 

 - src - source code of backend microservices
 
 - postman - postman collection to test api 

## Source code 

 - Softeq.Education.TrialsSystem - main solution file that contains all projects
 
 ![image](https://user-images.githubusercontent.com/110222378/189868123-06f57fa4-b037-4caa-b5d0-9f254969c356.png)
 
 - docker-compose.yml (docker-compose.override.yml) - docker-compose file to start microservice
 

# Practice: 


1. Clone repository.

2. Start the project from the src folder using the commands below 

```

docker-compose build
docker-compose up 

```
3.Go to http://localhost:4101/swagger/index.html and make sure that the service is alive, you should see swagger documentation.

![image](https://user-images.githubusercontent.com/110222378/189659761-8ee1b3dc-dbac-4f0e-888b-c30611622b8a.png)

4.  To start only single service use the next command

```
docker-compose up um.users.service   

```

5. Open Softeq.Education.TrialsSystem solution file, and set up TrialsSystem.UsersService.Api as a start project

6. Start project, you should see the same swagger documentation.
