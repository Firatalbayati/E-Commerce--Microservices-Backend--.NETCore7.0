FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/
COPY IdentityServer/MyCourse.IdentityServer/*.csproj IdentityServer/MyCourse.IdentityServer/
RUN dotnet restore IdentityServer/MyCourse.IdentityServer/*.csproj
COPY . .
RUN dotnet publish IdentityServer/MyCourse.IdentityServer/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.IdentityServer.dll" ]
