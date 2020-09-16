# <div align="center">RAMEN HOUSE</div>
 <div align="center">MSSA Demo Project - following Adam Freemans textbook</div>

## <div align="center">Create Solution and Projects</div>

## <div align="center">Chapter 7</div>

    dotnet new globaljson --sdk-version 3.1.101 --output RamenHouseSln/RamenProducts
    dotnet new web --no-https --output RamenHouseSln/RamenProducts --framework netcoreapp3.1
    dotnet new sln -o RamenHouseSln
    dotnet sln RamenHouseSln add RamenHouseSln/RamenProducts 
    dotnet new xunit -o RamenHouseSln/RamenProducts.Tests --framework netcoreapp3.1
    dotnet sln RamenHouseSln add RamenHouseSln/RamenProducts.Tests 
    dotnet add RamenHouseSln/RamenProducts.Tests reference RamenHouseSln/RamenProducts
   
![Welcome Page 1](https://github.com/Chester2171/Ramen-House/blob/master/WelcomeScreen1.PNG)

![Figure 7.9](https://github.com/Chester2171/Ramen-House/blob/master/Figure%207.9.PNG)

* What is Entity Framework?
    * Entity Framework is an object-relational mapper that is aimed at increasing developers productivity. Entity framework eliminates the need for most of the access code that developers need to write. 

* What is a Connection String?
    * A connection string provides the information that a provider need to communicate with a particular database. 

* What is a Database Context?
    * DbContext is a class provided by entity framework to establish connection to a database.

* What is a Model Repository?
    * The Model repository is a relational database that stores the metadata for projects and folders.

* Migration vs Scaffolding?
    * Migration is a way to keep the database schema in sync with the EF Core model by preserving data.  Scaffolding a database produces an Entity Framework model from an existing database
    
## <div align="center">Chapter 8</div>

![Figure 8.5](https://github.com/Chester2171/Ramen-House/blob/master/CH%208%20Figure%208.5.PNG)

![Figure 8.10](https://github.com/Chester2171/Ramen-House/blob/master/CH%208%20Figure%208.10.PNG)

![Figure 8.11](https://github.com/Chester2171/Ramen-House/blob/master/CH%208%20Figure%208.11.PNG)

![CH 8 Tests](https://github.com/Chester2171/Ramen-House/blob/master/CH%208%20Tests.PNG)
    
    
    
    
    
    
    
    
