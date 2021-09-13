# Get base SDK Image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copy the CSPROJ & SLN files and restore any dependencies (VIA NUGET)
COPY BinaryTreeWebAPI.sln ./
COPY BinarySearchTreeTests/*.csproj ./BinarySearchTreeTests/
COPY BinaryTree.CoreProject/*.csproj ./BinaryTree.CoreProject/
COPY BinaryTree.EntitiesProject/*.csproj ./BinaryTree.EntitiesProject/
COPY BinaryTreeWebAPI/*.csproj ./BinaryTreeWebAPI/
RUN dotnet restore

# Copy the project files and build our release
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "BinaryTreeWebAPI.dll"]