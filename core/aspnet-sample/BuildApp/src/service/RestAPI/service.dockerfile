FROM microsoft/dotnet:latest

MAINTAINER Amal

COPY . /service

WORKDIR /service

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 8019/tcp

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:8019"]