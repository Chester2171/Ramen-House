# Ramen-House
 MSSA Demo Project - following Adam Freemans textbook

## Create Solution and Projects

    dotnet new globaljson --sdk-version 3.1.101 --output RamenHouseSln/RamenProducts
    dotnet new web --no-https --output RamenHouseSln/RamenProducts --framework netcoreapp3.1
    dotnet new sln -o RamenHouseSln
    dotnet sln RamenHouseSln add RamenHouseSln/RamenProducts 
    dotnet new xunit -o RamenHouseSln/RamenProducts.Tests --framework netcoreapp3.1
    dotnet sln RamenHouseSln add RamenHouseSln/RamenProducts.Tests 
    dotnet add RamenHouseSln/RamenProducts.Tests reference RamenHouseSln/RamenProducts
