@echo off
start   cmd.exe /C "cd AuthenticationAPI & title AuthenticationAPI & dotnet run"
start   cmd.exe /C "cd DepartmentAPI & title DepartmentAPI & dotnet run"
start   cmd.exe /C "cd Gateway & title Gateway & dotnet run"