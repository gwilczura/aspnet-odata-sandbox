# odata sandbox

docker-compose -f ./infra/compose-infra.yaml up

CREATE EXTENSION citext;
CREATE EXTENSION IF NOT EXISTS citext;

dotnet ef migrations add init --project .\Wilczura.Odata.Adapters.Postgres --startup-project .\Wilczura.Odata.Host
dotnet ef database update --project .\Wilczura.Odata.Adapters.Postgres --startup-project .\Wilczura.Odata.Host
