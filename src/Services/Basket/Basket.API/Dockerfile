FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 63979
EXPOSE 44353

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY src/Services/Basket/Basket.API/Basket.API.csproj src/Services/Basket/Basket.API/
RUN dotnet restore src/Services/Basket/Basket.API/Basket.API.csproj
COPY . .
WORKDIR /src/src/Services/Basket/Basket.API
RUN dotnet build Basket.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Basket.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Basket.API.dll"]
