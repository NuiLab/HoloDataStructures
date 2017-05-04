Author: Paola Jiron
Project: OOP3D
Senior Project Spring 2017

The OOP3D project folder is composed of several files and folders:

Folders:

	- .vs - visual studio integrated files
	
    ----- App [Manually created when Builting the project in Unity] - If this folder does not exist, it is created when building the project for the first
																	time. If existing or after first build - it generates/contains the following:
																	
																	.vs file, GeneratedProjects, OOP3D (same copy of the parent directory), Unity folder,
																	UnityCommon.props, UnityOverwrite.txt, and ...
																	
															********OOP3D.sln (THIS IS THE FILE YOU DOUBLE CLICK TO DEPLOY THE APPLICATION where VS opens up
																	and you deploy on VS followed by Building and RUNning the application on the emulator or the Hololens Device)
																	
																	
		
	
	- Assets - [Most important] This folder holds all folders that contain the objects (with their materials) created for the scenes of the application.
								- Objects:
												Blob, 
												Coffee_Maker, 
												Cube, 
												Cursor, 
												Drawers_Array, 
												Stack, 
												Train
												
								- Audio : 
												Holds the soundtrack that plays during the time the application is ON.
												
								- Light : 
												Handles the lighting of the scenes.
								
								- Scenes : 
												Holds all the scenes created that form the application.
								
								- Scripts :
												The scripts that add funtionality to the application, objects, Gaze and Gestures recognition, etc.
												
								- Four other meta files.
	
	- Library - Libraries involved and used for the functionality of the software
	
	- ProjectSettings - Holds the assets of all managers and build settings
	
	- UWP - Holds the two json files necessary for the application to run
	
	- ClassDiagram1.cd - VS generated diagram
	
	- GlobalSuppression.cs - Runtime generated file
	
	- OOP3D.csproj, OOP3D.Editor.csproj, OOP3D.sln - application files generated on runtime
	
	-README.md - the README that displays all information of file structures in the GitHub
	
	