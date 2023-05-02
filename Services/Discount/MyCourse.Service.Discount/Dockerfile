FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/
COPY Services/Discount/MyCourse.Service.Discount/*.csproj Services/Discount/MyCourse.Service.Discount/
RUN dotnet restore Services/Discount/MyCourse.Service.Discount/*.csproj
COPY . .
RUN dotnet publish Services/Discount/MyCourse.Service.Discount/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Service.Discount.dll" ]


