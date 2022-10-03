[Tutorial: Create a minimal web API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api)

dotnet dev-certs https --trust

curl -X POST https://localhost:5001/todoitems -H "Content-Type: application/json" -d '{"name":"walk dog", "isComplete":true}'


VS Code: Install Extension 'Thunder Client'





$params = @{"Name"="walk dog"; "IsComplete"=true;}

Invoke-WebRequest -Uri https://localhost:5001/todoitems -Method POST -Body $params -ContentType "application/json"


$body = @{
 "Name"="12345678"
 "IsComplete"="true"
} | ConvertTo-Json

$header = @{
 "Accept"="application/json"
 "Content-Type"="application/json"
} 

Invoke-RestMethod -Uri "https://localhost:5001/todoitems" -Method 'Post' -Body $body -Headers $header | ConvertTo-HTML