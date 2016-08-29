FROM microsoft/dotnet:latest

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 8018/tcp

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:8018"]
