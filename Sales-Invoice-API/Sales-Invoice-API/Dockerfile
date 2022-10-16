#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Sales-Invoice-API/Sales-Invoice-API.csproj", "Sales-Invoice-API/"]
RUN dotnet restore "Sales-Invoice-API/Sales-Invoice-API.csproj"
COPY . .
WORKDIR "/src/Sales-Invoice-API"
RUN dotnet build "Sales-Invoice-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sales-Invoice-API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sales-Invoice-API.dll"]
