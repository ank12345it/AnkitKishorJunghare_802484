FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["TrainingService/TrainingService.csproj", "TrainingService/"]
RUN dotnet restore "TrainingService/TrainingService.csproj"
COPY . .
WORKDIR "/src/TrainingService"
RUN dotnet build "TrainingService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrainingService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrainingService.dll"]