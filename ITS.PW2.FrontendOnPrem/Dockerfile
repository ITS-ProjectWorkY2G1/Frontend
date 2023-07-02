#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ITS.PW2.FrontendOnPrem/ITS.PW2.FrontendOnPrem.csproj", "ITS.PW2.FrontendOnPrem/"]
RUN dotnet restore "ITS.PW2.FrontendOnPrem/ITS.PW2.FrontendOnPrem.csproj"
COPY . .
WORKDIR "/src/ITS.PW2.FrontendOnPrem"
RUN dotnet build "ITS.PW2.FrontendOnPrem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ITS.PW2.FrontendOnPrem.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ITS.PW2.FrontendOnPrem.dll"]