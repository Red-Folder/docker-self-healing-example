FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY Web/obj/Docker/publish .
COPY Healthcheck/obj/Docker/publish Healthcheck
EXPOSE 80
ENTRYPOINT ["dotnet", "Web.dll"]