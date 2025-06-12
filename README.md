# Nordic Backend (.NET core web api)
This is the dotnet back end built for the company 'Nordicmade'. The front end code uses Nextjs and is at https://github.com/mckenzie-mm/nordic-frontend. The dotnet backed code is shared between the "wwurm winery" website and the Charm Accessories websites. Different json files are used for each website and selected when the app is built.

The app runs on an AWS container service (ECS). This was chosen instead of Kubernetes due to the lower cost and ease with which a demonstration setup could be configured with ECS. It is deployed with infra-structure as a code (CDK). It is currently deployed only in the Australian AWS region and will be slow to load in Europe/Norway. The CDK code used to deploy the dotnet and Nextjs is at: https://github.com/mckenzie-mm/ecs-nordic-cdk

The app separates the backend code from the Nextjs into an independent dotnet service to allow for the possibility of independent frontend and backend scaling if necessary. Although the backend could have been built using nodejs (to be consistent with the frontend) current research indicates that dotnet outperforms nodejs in speed tests (google, for example: https://www.youtube.com/watch?v=iFbpaRjRpOc).

The code was built on a linux laptop using the dotnet cli with ASP.NET Core controller-based web API. The database is an Sqlite database. This was chosen in place of a postgres or SqlServer database due it's small size, which would otherwise have required an additional EC2 instance. Also, the low data size (< 1000) associated with these particular web apps did not warrant a more elaborate database.

The .NET nuget package, "Dapper", was used for making the SQL queries (my personal preference over Entity Framework). The DTO was coded manually (again my personal preference over AutoMapper).


