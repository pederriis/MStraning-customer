#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 444

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MStraning-customer/MStraning-customer.csproj", "MStraning-customer/"]
RUN dotnet restore "MStraning-customer/MStraning-customer.csproj"
COPY . .
WORKDIR "/src/MStraning-customer"
RUN dotnet build "MStraning-customer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MStraning-customer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MStraning-customer.dll"]