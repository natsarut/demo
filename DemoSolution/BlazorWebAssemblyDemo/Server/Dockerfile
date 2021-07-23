#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BlazorWebAssemblyDemo/Server/BlazorWebAssemblyDemo.Server.csproj", "BlazorWebAssemblyDemo/Server/"]
COPY ["BlazorWebAssemblyDemo/Shared/BlazorWebAssemblyDemo.Shared.csproj", "BlazorWebAssemblyDemo/Shared/"]
COPY ["BlazorWebAssemblyDemo/Client/BlazorWebAssemblyDemo.Client.csproj", "BlazorWebAssemblyDemo/Client/"]
RUN dotnet restore "BlazorWebAssemblyDemo/Server/BlazorWebAssemblyDemo.Server.csproj"
COPY . .
WORKDIR "/src/BlazorWebAssemblyDemo/Server"
RUN dotnet build "BlazorWebAssemblyDemo.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorWebAssemblyDemo.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorWebAssemblyDemo.Server.dll"]

#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#COPY bin/Release/net5.0/publish/ app/
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#ENTRYPOINT ["dotnet", "BlazorWebAssemblyDemo.Server.dll"]