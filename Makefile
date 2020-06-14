build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
watch:
	dotnet watch --project src/src.csproj run
start:
	dotnet run --project src/src.csproj
test:
	dotnet test