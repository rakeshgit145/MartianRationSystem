# Project Name: Rationing System

I had provided the entire Rationing System project to download with Sql server Script which contains tables, which are used in the preoject. 
This project is build using solid principle as mentioned below layers:-
	1.DAL :- This is the data layer which consists the edmx and data models.Its reference is given inside the WebUI layer.
	2.Contracts :- It is a generic reposistery interface. In which CRUD Method's are defined.
	3.WebUI :- This is the presentation layer which contains the layer which is visible to the user.
    4.Model:- It Contains all model and helper class.
	5 RationUnitTest:- This Layer Contain the all unit test cases.
##Database Part:

1.First things to do is to Create Database, an scripts file is placed inside the "DbScript" folder in the "WebUI" project solution with 
  name "Script1.sql" & name "Script2.sql".First Execute Script1.sql then execute the Script2.sql.

2.Open the Script file in the  SQL and execute the script. The script will automatically create the database with name "RationingSystemDB".

3.It will also create all the required tables which is used inside the project, along with some pre-entered data.

4.After Creating Database now make changes for the ConnectionStrings in Web.Config

5.Change this connectionStrings to your Own Data Source with Sql UserName and Password.