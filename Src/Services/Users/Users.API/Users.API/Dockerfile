FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Src/Services/Users/Users.API/Users.API/Users.API.csproj", "Src/Services/Users/Users.API/Users.API/"]
RUN dotnet restore "Src/Services/Users/Users.API/Users.API/Users.API.csproj"
COPY . .
WORKDIR "/src/Src/Services/Users/Users.API/Users.API"
RUN dotnet build "Users.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Users.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Users.API.dll"]