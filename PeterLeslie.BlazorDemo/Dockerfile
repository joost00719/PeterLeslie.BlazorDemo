#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PeterLeslie.BlazorDemo/PeterLeslie.BlazorDemo.csproj", "PeterLeslie.BlazorDemo/"]
RUN dotnet restore "PeterLeslie.BlazorDemo/PeterLeslie.BlazorDemo.csproj"
COPY . .
WORKDIR "/src/PeterLeslie.BlazorDemo"
RUN dotnet build "PeterLeslie.BlazorDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PeterLeslie.BlazorDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PeterLeslie.BlazorDemo.dll"]