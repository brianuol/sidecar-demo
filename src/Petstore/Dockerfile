FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Petstore.csproj src/Petstore/
RUN dotnet restore "src/Petstore/Petstore.csproj"
COPY . src/Petstore/.
WORKDIR "/src/src/Petstore"
RUN dotnet build "Petstore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Petstore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Petstore.dll"]
