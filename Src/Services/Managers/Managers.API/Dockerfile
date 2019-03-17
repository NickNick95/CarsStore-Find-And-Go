FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Src/Services/Managers/Managers.API/Managers.API.csproj", "Src/Services/Managers/Managers.API/"]
RUN dotnet restore "Src/Services/Managers/Managers.API/Managers.API.csproj"
COPY . .
WORKDIR "/src/Src/Services/Managers/Managers.API"
RUN dotnet build "Managers.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Managers.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Managers.API.dll"]