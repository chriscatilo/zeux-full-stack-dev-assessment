# Assesment for Full Stack Developer with Zeux 

## Pre-requisites

Ensure you have the following installed:

1. dotnet 2.1 SDK or later
2. node 8.12 or later

## Initializing a development environment

Once cloned, start a terminal session and go to folder `./Zeux.API`. Execute the following:

```
dotnet dev-certs https --trust
dotnet watch run
```
This will create a local SSL certificate for HTTPS and will start the Web API & rebuild on changes. The endpoints are `http://localhost:5000` and `https://localhost:5001`.

Then start another terminal session and go to folder `./zeux-app`. Execute the following:

```
npm install
npm start
```
This will install all dependencies to the Angular app, and start the web app.

Open a browser on `http://locahost:4200`