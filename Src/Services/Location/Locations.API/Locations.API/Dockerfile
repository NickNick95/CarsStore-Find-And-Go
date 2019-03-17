FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Src/Services/Location/Locations.API/Locations.API/Locations.API.csproj", "Src/Services/Location/Locations.API/Locations.API/"]
RUN dotnet restore "Src/Services/Location/Locations.API/Locations.API/Locations.API.csproj"
COPY . .
WORKDIR "/src/Src/Services/Location/Locations.API/Locations.API"
RUN dotnet build "Locations.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Locations.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Locations.API.dll"]