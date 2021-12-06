.PHONY: setup
setup:
	docker-compose build

.PHONY: build
build:
	docker-compose build estimates-and-actuals

.PHONY: serve
serve:
	docker-compose build estimates-and-actuals && docker-compose up estimates-and-actuals

.PHONY: shell
shell:
	docker-compose run estimates-and-actuals bash

.PHONY: test
test:
	docker-compose up test-database & docker-compose build estimates-and-actuals-test && docker-compose up estimates-and-actuals-test

.PHONY: lint
lint:
	-dotnet tool install -g dotnet-format
	dotnet tool update -g dotnet-format
	dotnet format

.PHONY: restart-db
restart-db:
	docker stop $$(docker ps -q --filter ancestor=test-database -a)
	-docker rm $$(docker ps -q --filter ancestor=test-database -a)
	docker rmi test-database
	docker-compose up -d test-database
