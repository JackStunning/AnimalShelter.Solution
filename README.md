# Animal Shelter Api

#### _Api made with C#, 4/3/2020_

#### By _**Jack Dunning**_

## Description

_CRUD Api made in C# that has random Pets with Name, Species and Gender properties that you can Get, Post, Search, Edit and Delete._

## Setup/Installation Requirements

* _Download .NET from here: https://dotnet.microsoft.com/download/dotnet-core/current_
* _Download .NET script in the Terminal with this command { dotnet tool install -g dotnet-script }_

* _Download MySQL from here: https://dev.mysql.com/downloads/_
  * _In MySQL_
    * CREATE DATABASE animal_shelter;
    * USE animal_shelter;
    * CREATE TABLE animals (AnimalId serial PRIMARY KEY, AnimalName LONGTEXT, Species LONGTEXT, Gender LONGTEXT);

* _Git clone Or download the zip file from gihub here: https://github.com/JackStunning/AnimalShelter.Solution_

* _In the Terminal run this command { dotnet ef migrations add Initial }_
* _In the Terminal run this command { dotnet ef database update }_
* _In the Terminal run this command { dotnet run }_

* _Download Postman from here: https://www.postman.com/downloads/_
  * _In Postman_
    * _Create and Save a new Request_
    * _In the url bar enter: http://localhost:5000/api/animals_
    * _On the left of the url bar select the type of Request you want, ex: GET, POST, PUT, etc..._
    * _On the right of the url click SEND_

## Specs 

  Specs are gonna be written for Postman, although, you can make your own client to use this api.

  * _Spec:_ When user configures Postman.
      * _Input:_ user opens Postman, Creates, Saves, adds http://localhost:5000/api/animals to url bar and clicks send
      * _Output:_ in the body underneath the params section, there should be an array with a bunch of animal objects with properties. 
      Ex: [
            {
                "animalIds": [],
                "animalId": 1,
                "animalName": "Burger",
                "species": "Dog",
                "gender": "Male"
            },
            {
                "animalIds": [],
                "animalId": 2,
                "animalName": "Hotdog",
                "species": "Cat",
                "gender": "Female"
            },
            {
                "animalIds": [],
                "animalId": 3,
                "animalName": "Slinko",
                "species": "Snake",
                "gender": "Male"
            },
            {
                "animalIds": [],
                "animalId": 4,
                "animalName": "Larry",
                "species": "Bird",
                "gender": "Male"
            },
            {
                "animalIds": [],
                "animalId": 5,
                "animalName": "Shelly",
                "species": "Turtle",
                "gender": "Female"
            }
        ]

  * _Spec:_ If user Sends the Request type Get.
      * _Input:_ user selects Get for the Request type and clicks Send
      * _Output:_ in the body underneath the params section, there should be an array with a bunch of animal objects

  * _Spec:_ If user wants to Get specific Animal.
      * _Input:_ user selects Get for the Request type, enters the AnimalId at the end of the url (ex: http://localhost:5000/api/animals/{AnimalId}), and clicks Send
      * _Output:_ in the body underneath the params section, there should be an array with the Animal that you wanted

  * _Spec:_ If user wants to Post new Animal.
      * _Input:_ user selects Post for the Request type. Enters the root url (http://localhost:5000/api/animals) in the url bar. Change the Params tab to Body tab and enter an object with Animal properties (ex: { "animalIds": [], "animalId": 1, "animalName": "Burger", "species": "Dog", "gender": "Male"}). Then click Send.
      * _Output:_ should give back a 200 OK status and then if you Get request http://localhost:5000/api/animals you should see your new Animal

  * _Spec:_ If user wants to Edit an Animal.
      * _Input:_ user selects Edit for the Request type. enters the AnimalId of the animal they want to select at the end of the url (ex: http://localhost:5000/api/animals/{AnimalId}). Change the Params tab to Body tab and edit Animal properties (ex: { "animalIds": [], "animalId": 1, "animalName": "NotBurger", "species": "Frog", "gender": "Mam"}). Then click Send.
      * _Output:_ should give back a 200 OK status and then if you Get request http://localhost:5000/api/animals you should see your Animal has been edited with your new changes

  * _Spec:_ If user wants to Delete an Animal.
      * _Input:_ user selects Delete for the Request type. enters the AnimalId of the animal they want to select at the end of the url (ex: http://localhost:5000/api/animals/{AnimalId}).Then click Send.
      * _Output:_ should give back a 200 OK status and then if you Get request http://localhost:5000/api/animals you should see your Animal has been removed from the list

  * _Spec:_ If user wants to Get a random Animal.
      * _Input:_ user selects Get for the Request type. enters random at the end of the url (ex: http://localhost:5000/api/animals/random).Then click Send.
      * _Output:_ should give back a 200 OK status and in the body underneath the params section, there should be an array with a random Animal

  * _Spec:_ If user wants to Get an Animal by Name.
      * _Input:_ user selects Get for the Request type. Query the AnimalName of the animal they want to select at the end of the url (ex: http://localhost:5000/api/animals/?animalName=Burger).Then click Send.
      * _Output:_ should give back a 200 OK status and in the body underneath the params section, there should be an array with Burger's Animal object

  * _Spec:_ If user wants to Get an Animal by Species.
      * _Input:_ user selects Get for the Request type. Query the Species of the animal they want to select at the end of the url (ex: http://localhost:5000/api/animals/?species=Dog).Then click Send.
      * _Output:_ should give back a 200 OK status and in the body underneath the params section, there should be an array with Burger's Animal object cause he is the only Dog

  * _Spec:_ If user wants to Get an Animal by Gender.
      * _Input:_ user selects Get for the Request type. Query the Gender of the animal they want to select at the end of the url (ex: http://localhost:5000/api/animals/?gender=Male).Then click Send.
      * _Output:_ should give back a 200 OK status and in the body underneath the params section, there should be an array with only Animal objects with gender properties equal to Male

## Further Exploration
    
Enabling CORS: CORS, Cross-Origin Resource Sharing, is something I wanted to look into was enabling for my Api because after working with Apis for a little bit now one of the most annoying issues is CORS errors. Cors errors happen because of your browsers security implementations, The Same-Origin Policy. This is really good for stopping some nefarious hackers from stealing your cookie data with sensative information on it, but we can get around this by defining which specific sites we can request in our Startup.cs. Currently The only origins enabled is http://localhost:*, so anything with http://localhost:* as it's root won't give CORS errors. This will hopefully make it CORS errors don't happen as much.

Startup.cs: In our Startup.cs I set the policy name to "_myAllowSpecificOrigins", this is non specific and can be changed to anything. In ConfigureServices function I call services.AddCors method with options as parameter. Inside that I call options.AddPolicy with MyAllowSpecificOrigins and builder parameters. What We are doing with AddPolicy is adding what specific sites we actually want to allow as a policy and set that to our MyAllowSpecificOrigins variable. I then call app.UseCors(MyAllowSpecificOrigins); to run the function in our app on startup so we can enable CORS immediately so nothing crashes on startup if they would normally get a CORS error.

## Known Bugs

_No known bugs_

## Support and contact details
 
_Email: JackStunning9001@gmail.com_

## Technologies Used

_C#, .NET, MSTest, MySQL, Html, Bootstrap, Entity Framework, RestSharp, Postman_

### License

*Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN*

Copyright (c) 2020 **_Jack Dunning_**