FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/
COPY Services/Catalog/MyCourse.Service.Catalog/*.csproj Services/Catalog/MyCourse.Service.Catalog/
RUN dotnet restore Services/Catalog/MyCourse.Service.Catalog/*.csproj
COPY . .
RUN dotnet publish Services/Catalog/MyCourse.Service.Catalog/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Service.Catalog.dll" ]
