FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN

WORKDIR /app

# Copy csproj and nuget config and restore as distinct layers
COPY ./Estimates_And_Actuals.sln ./
COPY ./Estimates_And_Actuals/Estimates_And_Actuals.csproj ./Estimates_And_Actuals/
COPY ./Estimates_And_Actuals.Tests/Estimates_And_Actuals.Tests.csproj ./Estimates_And_Actuals.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Estimates_And_Actuals/Estimates_And_Actuals.csproj
RUN dotnet restore ./Estimates_And_Actuals.Tests/Estimates_And_Actuals.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Estimates_And_Actuals.Tests/Estimates_And_Actuals.Tests.csproj

CMD dotnet test
