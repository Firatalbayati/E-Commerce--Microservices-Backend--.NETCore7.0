FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/
COPY Services/PhotoStock/MyCourse.Service.PhotoStock/*.csproj Services/PhotoStock/MyCourse.Service.PhotoStock/
RUN dotnet restore Services/PhotoStock/MyCourse.Service.PhotoStock/*.csproj
COPY . .
RUN dotnet publish Services/PhotoStock/MyCourse.Service.PhotoStock/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Service.PhotoStock.dll" ]
