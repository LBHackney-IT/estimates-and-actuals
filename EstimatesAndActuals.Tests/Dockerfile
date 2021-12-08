FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN

WORKDIR /app

# Copy csproj and nuget config and restore as distinct layers
COPY ./EstimatesAndActuals.sln ./
COPY ./EstimatesAndActuals/EstimatesAndActuals.csproj ./EstimatesAndActuals/
COPY ./EstimatesAndActuals.Tests/EstimatesAndActuals.Tests.csproj ./EstimatesAndActuals.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./EstimatesAndActuals/EstimatesAndActuals.csproj
RUN dotnet restore ./EstimatesAndActuals.Tests/EstimatesAndActuals.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out EstimatesAndActuals.Tests/EstimatesAndActuals.Tests.csproj

CMD dotnet test
