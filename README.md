Glimpse.EF1Test
===============

A super-minimalistic test project to test Glimpse.EF1 plugin with WebForms/EF1 on .NET 3.5

Quick notes
===========

- Project features single ASPX page that does a simple SELECT on a table via EF1 model.
- Glimpse.Ado needs is initialized in the Global.asax file (it has to be initialized due to WebActivator not being available)
- The DLLs in the Libraries folder are release builds of the Glimpse fork at https://github.com/mheimann/Glimpse
- In order to test it you need to create a database with appropriate tables (using the Db/CreateTables.sql file) and change the connection string in the Web.config file to your particular database server, database, user, password, ...

Disclaimer
==========

- This repository only exists as a quick test for the Glimpse.EF1 plugin that was added in the Glimpse fork at https://github.com/mheimann/Glimpse
