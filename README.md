# Groceries

## 1. Description
WIP

## 2. Requirements
- Docker
- DockerCompose
- .Net Core 5

## 3. Installation

### 3.1 Infrastructure
To spin up your MySQL server on Docker, you can use the docker compose bundled with the project. This will allow you to spin up all the dependencies with few commands. Otherwise, feel free to use any instance of the required dependencies and re-configure appsettings.json accordingly.

**Note:** You may want to check out the specific configuration for the dependencies below before running this.

To do this get into the Infrastructure folder and, given that you already have docker-compose installed, run:
```docker-compose up -d```

#### 3.1.1 Database
If you are running on Windows, you will need to set up the ENV variable for the MySQL volume path first. You can run on your powershell:

```$env:MYSQL_VOLUME_LOCATION = '{your-path-here}'```
(without the curly brackets)

### 3.2 Migrations
You will need to initialize your database structure. For that purpose, given that you already started your DB engine, you will need to run the migrations. On powershell run the following command:

```Update-Database```
