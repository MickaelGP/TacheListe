# Liste de tâches - Formation CDA
Ce projet est une petite application console développée en C# dans le cadre de la formation Concepteur Développeur d’Applications (CDA).
Elle permet d’ajouter, consulter et supprimer des tâches.
## Stack technique
 - Langage : C#
 - Framework : .NET 8

## Objectif pédagogique
Ce projet a pour but de mettre en pratique les notions suivantes :
- Création d’une application console en C#.
- Utilisation de la configuration via appsettings.json.
- Interaction avec une base de données SQL.
- Mise en place de tests unitaires avec NUnit.
- Structuration du code selon de bonnes pratiques.
## Prérequis
Avant de lancer l'application, assurez-vous d’avoir installé les dépendances suivantes via NuGet :
 - Microsoft.Data.SqlClient
 - Microsoft.Extensions.Configuration.EnvironmentVariables
 - Microsoft.Extensions.Configuration.Json
 - Microsoft.Extensions.Configuration.Binder

## Installation
Suivez les étapes ci-dessous pour installer et exécuter l’application localement :

1.  Cloner le dépôt :
```bash
git clone https://github.com/MickaelGP/TacheListe
cd TacheListe
```
2. Créer la base de données.
```bash
   Utilisez le script SQL fourni dans le dépôt (script.sql) pour créer la base de données.
```
3. Configurer l'application
   - Créez un fichier appsettings.json à la racine du projet avec le contenu suivant :
```JSON
 "Settings" : {
   "DbConnectionString": "Vôtre chaine de connexion",
   "DbConnectionStringTest": "Vôtre chaine de connexion pour effectuer les test unitaires"
 }
```
- Remplacez les chaînes de connexion par les vôtres.

4. Lancer l'application :
```bash
 dotnet run
```

## Auteur
- MickaelGP - https://github.com/MickaelGP


## License
Ce projet est sous licence MIT. Pour plus d'informations, consultez le fichier [LICENSE](LICENSE).