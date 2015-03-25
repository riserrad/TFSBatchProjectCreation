TFSBatchProjectCreation
=======================

This application aims to support the creation of a large volume of Team Projects. 

The traditional method of creating a Team Project in TFS is through Visual Studio, in the Team Explorer Wizard. There is also the createteamproject command line , from Team Foundation Server Power Tools, which allows you to create a Team Project through the Command Prompt. 

However, these alternatives can become onerous if the volume of Team Projects to be created is very large. 

**In which scenario this app may be useful?**

This app was born with the objective of minimizing the time and effort spent in the work described above. But which scenario would I need to create a batch of Team Projects? 

The answer is simple: ALM administrators and consultants certainly have already gone through a migration scenario where it was necessary to change the name and / or Process Template selected in the creation of Team Project. We all know that these are information that, once created the project, cannot be changed. 

For source and work items migration, we already have the TFS Integration Platform. However, this tool does not cover the (re) creation of Team Projects. And this is where this app comes into play.

**How to**

All you need to do is create a text file containing the Team Project names and if each one will use Sharepoint Portal or not. Like this:

	Team Project 1|Yes
	Team Project 2|No
	Team Project 3|Yes
	Team Project 4|Yes

In this example, only the **Team Project 2** will **not** use the Sharepoint Portal feature.

After that, in the app, you need to:

* Select the Team Project Collection the Team Projects will be created;
* Select the Text File that contains the Team Projects information;
* Select the Log File location;
* Select the Process Template you want to use in the Team Projects.

**Requirements**
* Team Foundation Server Power Tools