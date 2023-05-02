FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY MyCourse.Gateway/*.csproj MyCourse.Gateway/
RUN dotnet restore MyCourse.Gateway/*.csproj
COPY . .
RUN dotnet publish MyCourse.Gateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Gateway.dll" ]
