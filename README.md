# draal-dotnetapp
> .NET Core application playground.

## Quickstart

### Install dependencies
```
npm install # npm i
```

### Start server
```
npm run docker-build
npm run docker-run # or npm run docker-rund
```
Server is located at http://localhost:5000. To test the server run:
```
curl -X POST -v -H "Content-Type: application/json" -d '{"Name":"5555","Genre":"123456789"}' "http://localhost:5000/api/band"
curl -v "http://localhost:5000/api/band"
```

Docker compose is used to build and run multi-container Docker applications. Current setup is such that application runs in one
container and the (PostgreSQL) database in another container. Database data is mapped to local folder via Docker volumes.

### Stop server
```
npm run docker-down # when started with "npm run docker-rund"
```

---------

## Useful (docker and dotnet) commands
```
# Stop and remove containers
docker stop $(docker ps -a -q)
docker rm $(docker ps -a -q)

# Remove images
docker rmi $(docker images -q)

docker system prune

dotnet --info
```

---------

## Some .NET Core links

### How to

*   [Add a Controller and View](https://go.microsoft.com/fwlink/?LinkID=398600)
*   [Add an appsetting in config and access it in app.](https://go.microsoft.com/fwlink/?LinkID=699562)
*   [Manage User Secrets using Secret Manager.](https://go.microsoft.com/fwlink/?LinkId=699315)
*   [Use logging to log a message.](https://go.microsoft.com/fwlink/?LinkId=699316)
*   [Add packages using NuGet.](https://go.microsoft.com/fwlink/?LinkId=699317)
*   [Add client packages using Bower.](https://go.microsoft.com/fwlink/?LinkId=699318)
*   [Target development, staging or production environment.](https://go.microsoft.com/fwlink/?LinkId=699319)

### Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

### Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

## License

[MIT](/LICENSE)

