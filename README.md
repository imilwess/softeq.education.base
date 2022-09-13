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
7. Lern structure of project what nuget packages and how they use.
8. UsersService should contains 2  aggregates UserAggregates and Device Agregate, add Device  aggregate to Domain project with fileds below

```
  Id: string
  SerialNumber: string,
  Model:string
  Type: 
      DeviceType:
             Id:   string
             Name: string 
FirmwareVersion:string
```
9. Add many to many relations between Device and User aggregates. Because one user can wear several devices and one device can be used by many users as well 

10. Finish implementation CRUD in UsersController(only controller without saving data to DB) and add City Controller with CRUD and Request, Response models

11. Add FluentValidation for UserRequest models
   - The participant(user) should be older than 18 years 
   - Email should be valid
   - Name and Surname should not be empty or whitespace, Name!=Surname
   - Add necessary validation for CityRequest as well

12. Add a new controller with CRUD operations for Device aggregate.

13. Add commands and queries using IMediatr for all CRUD api operation

15. Add custom validation in CommandHandler for cases below, use custom Exception and use a Filter(Api/Filters) to handle and log them  
   - User not found
   - User with such email already exist
   
15. Implement UserTaskMicroservice

17. Use postman for test all API ( collection: postman/TrialsSystemCollections.postman_collection.json, env:local.postman_environment.json)

# Additional tasks
1. Implement Email validation with FluentValidation by following requirements, if email dont mach several requarmens, return all errors 

e.g. 

```
Email:"Email address can't end with '.' character, 
       Email address can't contain empty spaces, 
       domain-part too long - the maximum length is 255 characters"
       

```

or 

```
Email:["Email address can't end with '.' character", 
       "Email address can't contain empty spaces", 
       "domain-part too long - the maximum length is 255 characters"]
       

```

But if domain-part or local-part is missing don't validate them and return a single error.

### General
 - Email address cant ends with '.'
 - Email address cannot contain space
### Local-part
 - length should be less than 63 characters
 - "." is not the first or last character
 - "." shouldn't appear consecutivel
### Domain-part
- Ipv4 - valid
- Ipv6 - valid
- length should be less than 255 characters
- can contain labels with separation ".", each label is limited to a length of 63 characters
- top-level domain names are not all-numeric
- hyphen is not the first or last character
- allowed uppercase and lowercase Latin letters A to Z and a to z, digits 0 to 9
