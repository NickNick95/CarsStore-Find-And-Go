FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Src/Services/Identity/Identity.API/Identity.API.csproj", "Src/Services/Identity/Identity.API/"]
RUN dotnet restore "Src/Services/Identity/Identity.API/Identity.API.csproj"
COPY . .
WORKDIR "/src/Src/Services/Identity/Identity.API"
RUN dotnet build "Identity.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Identity.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Identity.API.dll"]