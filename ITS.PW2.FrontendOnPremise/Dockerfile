#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ITS.PW2.FrontendOnPremise/ITS.PW2.FrontendOnPremise.csproj", "ITS.PW2.FrontendOnPremise/"]
COPY ["ModelsOnPrem/ModelsOnPrem.csproj", "ModelsOnPrem/"]
COPY ["Models/Models.csproj", "Models/"]
COPY ["ServicesOnPrem/ServicesOnPrem.csproj", "ServicesOnPrem/"]
RUN dotnet restore "ITS.PW2.FrontendOnPremise/ITS.PW2.FrontendOnPremise.csproj"
COPY . .
WORKDIR "/src/ITS.PW2.FrontendOnPremise"
RUN dotnet build "ITS.PW2.FrontendOnPremise.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ITS.PW2.FrontendOnPremise.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ITS.PW2.FrontendOnPremise.dll"]