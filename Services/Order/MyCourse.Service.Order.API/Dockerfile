FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/

COPY Services/Order/MyCourse.Service.Order.API/*.csproj Services/Order/MyCourse.Service.Order.API/
COPY Services/Order/MyCourse.Service.Order.Application/*.csproj Services/Order/MyCourse.Service.Order.Application/
COPY Services/Order/MyCourse.Service.Order.Domain/*.csproj Services/Order/MyCourse.Service.Order.Domain/
COPY Services/Order/MyCourse.Service.Order.Domain.Core/*.csproj Services/Order/MyCourse.Service.Order.Domain.Core/
COPY Services/Order/MyCourse.Service.Order.Infrastructure/*.csproj Services/Order/MyCourse.Service.Order.Infrastructure/

RUN dotnet restore Services/Order/MyCourse.Service.Order.API/*.csproj
COPY . .
RUN dotnet publish Services/Order/MyCourse.Service.Order.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Service.Order.API.dll" ]

