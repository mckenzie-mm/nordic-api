# Nordic Backent (.NET web api)
This is the dotnet back end built for the company 'Nordicmade'. The front end code use Nextjs and is at https://github.com/mckenzie-mm/nordic-frontend. 

The app runs on an AWS container service (ECS). This was chosen instead of Kubernetes due to the lower cost. It is currently only on Australian AWS and will be slow to load in Europe/Norway. 

The app separates the backend code from the Nextjs into an independent dotnet service to allow for the possibility of independent frontend and backend scaling if necessary. Although the backend could have been built using nodejs to be consistent with the frontend, current research indicates that dotnet consistently outperforms nodejs in speed tests (google, for example: https://www.youtube.com/watch?v=iFbpaRjRpOc).
