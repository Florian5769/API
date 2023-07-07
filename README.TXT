La TodoAPI est une API Web en C# ASP.NET Core 6.0 utilisée pour gérer des éléments de tâches à faire (todos). Elle utilise EF Core pour accéder aux données, 
l'injection de dépendance pour la gestion des dépendances, et AutoMapper pour mapper les entités aux objets de transfert de données (DTO). 
Elle est basée sur une architecture à trois niveaux, comprenant une couche API, une couche métier et une couche de données.
 Elle implémente également le modèle de référentiel pour la gestion des opérations de base sur les données.


Prérequis 

Visual Studio Code
C# pour Visual Studio Code 
Kit de développement logiciel (SDK) .NET 7.0

Visual Studio Code lance le navigateur par défaut sur http://localhost:53895
Ajoutez /swagger à l’URL, https://localhost:53895/swagger.


Dans ASP.NET Core, les services tels que le contexte de base de données doivent être inscrits auprès du conteneur d’injection de dépendances. 
Le conteneur fournit le service aux contrôleurs.

dotnet run pour executer l'api
