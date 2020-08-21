# Title

#### Latest version date

#### By Deryck Jackson

## Description



## User Stories



## Specifications

| Spec | Input | Output |
| :---: | :---: | :---: |
|  |  |

## Swagger API Documentation

[Swagger Docs](https://app.swaggerhub.com/apis-docs/deryck2/message-board_solution/1.0)

## Setup and Installation

* .NET Core 2.2 will need to be installed, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* For Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* For Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
* You will need a API development tool like Postman or a way to make API requests: https://www.postman.com/downloads/
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* Navigate to the newly created `MessageBoard.Solution` folder
* Navigate to the `MessageBoard` subfolder and run `dotnet restore`
* Run `dotnet ef database update` in the terminal
* Run `dotnet build` to build the app and `dotnet run` to run it
* The web app will now be available on `http://localhost:5000/` in your browser
* You will need to get the JWT Authentication Token, Send the following code in the RAW section of your API request body

  ![Request Body](UserAuthRequest.PNG)  

  ![Response Body](AuthResponseBody.PNG)
* Copy the Token from the Value field of the Token Key from the response body of your request and attach it to the Bearer section of the header section of any requests made to API paths requiring Authentication

  ![Bearer Token](BearerTokenLocation.PNG)

## Tech used

* C#
* ASP.NET MVC
* Entity Framework Core
* MYSQL

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Deryck Jackson