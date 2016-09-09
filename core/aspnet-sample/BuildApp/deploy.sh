#!/bin/bash

docker rm -f 'docker ps -aq -f name=build_*'

set -a
source ./src/web/env/app.${ASPNETCORE_ENVIRONMENT}.env

cat docker-compose.yml | envsubst | docker-compose -f - -p build_ up -d