# Kanbang

This project is a work in progress.

## Developer guidance
This project is separated into 2 parts:

* Web API - powered by ASP.NET MVC Web API
* Client app - angular2 app.

### Folder structure
Kanbang/
├──Kangbang.Core				* business logic layer
├──Kangbang.Database			* database project to generate schema
└──Kangbang.Web					* web api project and client app projects
   ├──Client					* client app. this is a clone of [angular2-webpack-starter](https://github.com/angular-class/angular2-webpack-starter). This folder should not be included in the Visual Studio solution.
   └──Index.html				* entry point to the client app.

### How to build and run client app
* Install [nodejs](https://nodejs.org/)
* Run *$(SolutionDir)/tsc-watch.bat*. This will start TypeScript compiler and will watch your typescript files for changes. When changes are detected the TypeScript files will be auto-recompiled.
* Run *Kanbang.Web* project. The homepage will show the client app.
