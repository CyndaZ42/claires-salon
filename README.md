# Eau Claire's Salon

#### By _**Zac Waggoner**_  

#### _An MVC application to manage salon stylists and their clients._  

---

## Table of Contents

[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](/LICENSE)

---

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is an MVC application that was built using C#. The purpose of this application is to ..._

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Clone this git repository: <a href="https://github.com/CyndaZ42/claires-salon.git">https://github.com/CyndaZ42/claires-salon.git</a>
<li>Clone the repository for this project using the "git clone" command and including the copied URL.
<li>in the terminal, navigate to the root directory of the newly created file named "HairSalon.Solution".
<li>From the root directory, navigate to the "HairSalon" directory.
<li>Move onto "SQL Workbench" instructions below to re-create database necessary to run this project.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "HairSalon" directory of the project*  
   <pre>HairSalon.Solution
   ├── HairSalon
   │  ├── Controllers
   │  ├── Models
   │  ├── Views
   │  ├─── Program.cs
   │  ├─── Startup.cs
   │  ├─── HairSalon.csproj
   │  └─── <strong>appsetting.json</strong>
   └── HairSalon.Tests</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=zac_waggoner;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>

<li>Once "appsettings.json" file has been created, navigate back to SQL Workbench.
<li>Import the database named "zac_waggoner.sql" from the root directory of the project.<br><br>
How to Import a Database:
<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "Administration" tab in SQL Workbench.
  <li>Click "Data Import/Restore".
  <li>Select the radio button "Import from Self-Contained File" and include file path to the sql file of this project you cloned to your machine.
  <li>In "Default Schema to be Imported to" click "New".
  <li>Name the schema "zac_waggoner" then click "OK".
  <li>Once named, switch to "Import Progress" tab and click "Start Import".
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>HairSalon.Solution
   ├── <strong>HairSalon</strong>
   └── HairSalon.Tests</pre>

Run `$ dotnet restore` in the console<br>
Run `$ dotnet run` in the console
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _No known issues_