# Unreal Engine Behaviour Tree Tutorial

## Author: Minsi Chen

## Introduction

Behaviour Trees in Unreal Engine provide developers an asset-based approach to designing and implementing intelligence into non-player characters in video games.
The screenshot below shows a behaviour tree representing the actions that can be executed by a non-player enemy character.

![An example behaviour tree.](/figures/behavior-tree-quick-start-step-3-12.png "An example behaviour tree.")
*An example behaviour tree representing an enemy NPC's actions. Source: <https://dev.epicgames.com/documentation/en-us/unreal-engine/behavior-tree-in-unreal-engine---quick-start-guide>*

In this tutorial session, you will be given a vehicle project as a starting point.
Our aim is to introduce a simply chase behaviour to the computer controlled vehicles.

The programming part of this tutorial is C++ based.
However, you do not need any prior coding experience in C++.
You will be given the code snippet and the tasks set in this document will guide you through the code base of this project.


## Learning outcomes:

Working through this activity, you should be able to:
- Understand the basic components of a behaviour tree
- Configure a working behaviour tree with simple tasks and services
- Extend the start-up project in your own time and at your own pace

## Activity 1: Getting acquainted with Unreal Engine Editor and Visual Studio

<details>

<summary> Task 1: Open the VehicleStarter project in Unreal Engine Editor</summary>

1. Open the Unreal Engine Editor by double clickingt the "Unreal Engine 5.4.3" shortcut on the desktop

2. When presented with the following dialog box, click Browse to open the VehicleStarter project. The project should be in the C:\Work folder.

![](/figures/UE5_open_existing_project_UI.png)

3. Unreal Engine may need to convert the project. If you see the following dialog box, select More Options then click "Convert in-place".

![](/figures/UE5_project_conversion_UI.png)

4. Unreal Engine Editor should now convert and open the project. This may take a few minutes. Once the project is loaded, you should see a window similar to the screenshot below without the additional cars. You can play the level by clicking the green triangle play button.
![](/figures/UE5_editor.png)

</details>

<details>

<summary> Task 2: Adding an NPC vehicle to the map </summary>

1. Open the Content Browser by clicking the "Content Browser" button located at the bottom left corner of the editor. This will bring up the asset for this project as shown in the following screenshot

![](/figures/UE5_content_browser.png)

2. To add an NPC vehicle to the map, drag the "AIStarterWheeledVehiclePawn" from the Content Browser into the level. You can place it anywhere you like. This process spawns an instance of AI vehicle but the vehicle will not do anything if you hit play.

3. The NPC vehicle does not have a torque and AI controller setup by default. To add a torque curve, select the vehicle you just added and use the detail panel on the right to assign a torque curve as shown in the image below.

![](/figures/UE5_BT_adjust_torque.png)

4. Finally, we need setup the AI vehicle to use our own custom AIController. To do this, we will use the detail panel to change the AI Controller Class to AIWheeledVehicleController, see the screenshot below.

![](/figures/UE5_changing_aicontroller.png)

5. If you hit play now, you should see the AI vehicle making a left hand turn at full throttle. This is not very useful but it verifies that our controller and engine torque are setup.
</details>

<details>

<summary> Task 3: Explore the VehicleStarter project source code in Visual Studio </summary>

At this point, you should have the project loaded for Activity 2.
The purpose of this task is to get you familiarise with Visual Studio which will be used later for adding additional functionality into the project.
Additionally, it also shows you how these source files are related to the game objects and asset you have seen so far.

To open the Visual Studio project, click Tools on the menu bar located at the top of the Unreal Engine Editor, then select Open Visual Studio. You should see Visual Studio similar to the screenshot below.

![](/figures/UE5_VS_UI.png)

The panel on the left is known as the Solution Explore which shows all the files related to this project.
The files we are interested in are all located under Games->VehicleStart->Source->VehicleStarter, e.g. those files with .cpp and .h extension.

This may look overwhelming at first glance, but we can ignore all the implementation details in this tutorial.

There is also a close relationship between the source code and the vehicle you have seen in the editor.
For example, the player controlled vehicle is actually a class called `StarterWheeledVehiclePawn` defined in the source file `StarterWheeledVehiclePawn.h` and `StarterWheeledVehiclePawn.cpp`.

Similarly, the AI controlled vehicle is represented by the class `AIStarterWheeledVehiclePawn`.
**Can you locate the source files for this class in the Solution Explorer?** 
</details>

## Activity 2: Implementing simple steering behaviour using behaviour trees and blackboard

The objective of this activity is to implement a simple steering behaviour for the NPC vehicle.
This simple behaviour should enable our computer controlled vehicle to track and pursue the player vehicle.

<details>

<summary> Task 1: Calculating the steering angle and driving direction </summary>

</details>

<details>

<summary> Task 2: Implementing the steering and throttling as behaviour tree tasks and services

</details>

<details>

<summary> Task 3: Configuring the behaviour tree asset in Unreal Engine Editor </summary>

</details>

<details>

<summary> Task 4: Test the behaviour tree on the AI controlled vehicle </summary>

</details>