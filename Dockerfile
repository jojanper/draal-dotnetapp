FROM microsoft/dotnet:latest

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

CMD ["dotnet", "run", "--server.urls", "http://*:5000"]
