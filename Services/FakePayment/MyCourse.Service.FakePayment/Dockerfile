FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/Course.Shared/*.csproj Shared/Course.Shared/
COPY Services/FakePayment/MyCourse.Service.FakePayment/*.csproj Services/FakePayment/MyCourse.Service.FakePayment/
RUN dotnet restore Services/FakePayment/MyCourse.Service.FakePayment/*.csproj
COPY . .
RUN dotnet publish Services/FakePayment/MyCourse.Service.FakePayment/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","MyCourse.Service.FakePayment.dll" ]

