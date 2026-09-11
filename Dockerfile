# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# restore (cached unless project files change)
COPY PracticingCAE_Web.sln ./
COPY src/PracticingCAE.Web/PracticingCAE.Web.csproj src/PracticingCAE.Web/
COPY tests/PracticingCAE.Tests/PracticingCAE.Tests.csproj tests/PracticingCAE.Tests/
COPY tools/ContentGen/ContentGen.csproj tools/ContentGen/
RUN dotnet restore

# build & publish
COPY . .
RUN dotnet publish src/PracticingCAE.Web -c Release -o /app/publish --no-restore

# runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
COPY content ./content

# progress database lives on /data (mount a volume there)
ENV DATA_DIR=/data \
    ASPNETCORE_URLS=http://+:8080
VOLUME /data
EXPOSE 8080

ENTRYPOINT ["dotnet", "PracticingCAE.Web.dll"]
