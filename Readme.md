# Unity Test | Juan Diego Mozo Osorio
In this repository is the solution of the Unity test for Juan Diego Mozo Osorio.

For all the project was used the Unity 2020.3.2f1 

## First part
Please solve the following problems. You can use the Unity Documentation, Scripting Reference, Stack Overflow, Google, etc:

For everyone of this exersice I created a individual project for each.

> 1.1 Extend the following vertex and fragment shader to use Light Probe illumination from the scene, affecting the object being rendered.
``` bash
1-1 Shader
```
For this exersice the shader just need the wordPos and wordNormal for the work, in the next image is the comparation between the original shader and the new shader.

![Exersice 1](./images/1.png?raw=true "Shader works")


> 1.2 Create a native plugin with a function written in C/C++, which is called from Unity in a C# script and receives the following struct from C#:

``` bash
struct TwoStrings {
  string string1;
  string string2;
  string concatenated;
}
```

> After calling the native function from C#, passing as argument an object of type TwoStrings, the variable “concatenated” of the object will store the two strings in “string1” and “string2” concatenated.
``` bash
1-2 Native Plugin
```

Well my native plugin

![Exersice 2](./images/2.png?raw=true "Native Plugin")

> 1.3 Create a Unity project using Unity’s C# Job System to calculate the sum of the R channel, for each texture element of a texture. To do this, split the texture into four regions of equal size, the operation should be processed by jobs running in parallel.

The pararel Job System calculate the texture of all this cubes and give a sum of them.

![Exersice 3](./images/3.png?raw=true "JobSystem")

> 1.4 Use VFX Graph to create a particle system that moves along a Bezier curve.

I used differents nodes for the creation of this Bezier curve which can be edit easily.

![Exersice 4](./images/4.png?raw=true "ParticleSystem")

> 1.5 Create two prefabs using cubes with a shared material, packing each prefab into a separate asset bundle. Use a script to load the prefabs and instantiate them in the scene. Do not use Addressables.

![Exersice 5](./images/5.png?raw=true "Prefabs")

## First part technical information
The Unity project cotains the next packages:
``` bash
  - JetBrains Rider Editor 2.0.7
  - Jobs 0.8.0
  - Test Framework 1.1.24
  - TextMeshPro 3.0.4
  - Timeline 1.4.7
  - Unity Collaborate 1.3.9
  - Unity UI 1.0.0
  - Universal RP 10.4.0
  - Visual Studio Code Editor 1.2.3
  - Visual Studio Editor 2.0.7
```

Assets used:
``` bash
  - Gridbox Prototype Materials 1.0.0
```

## Second part
Please, try to answer the following questions in your own words:
> 2.1 Describe the next Technologies and what are they can be used for:
>> 2.1.1 Scriptable Build Pipeline

It's the way of how Unity builds the content of the app.

>> 2.1.2 Scriptable Render Pipeline

It's the way of how the game objects in the scene are going to be renderer, mainly focused on the lights. You can create your own.

>> 2.1.3 Addressables

They are assets that can be called from anywhere inside the project.

>> 2.1.4 IL2CPP

It's a way of assembling the projects to different platforms.

>> 2.1.5 Nested Prefabs

I guess they are prefabs inside prefabs.

> 2.2 Mention at least two problems of Unity’s non-incremental Garbage Collector.

1. Animate the UI with the animator (I have read that since 2019.3 they solved this issue but sometimes still rendering that animation infinite so I prefer to use Tween instead)

2. The use of Invoke and Destroy.

> 2.3 Unity LTS, TECH release, Beta or Alpha

The best is the Unity LTS because is the version with support meanwhile the Teach release is the version in between. But a Beta is a version in development with possible bugs and an Alpha is a version with bugs assurance, the best decision is never to use these two for a project.

> 2.4 What is your preferred version control system and why do you prefer it over
others?

Well, I really haven't tried the new Input control system because always have a lot of trouble with the projects I work on, so I really prefer the old input control system.

> 2.5 What is your favorite IDE and why?

I really like Visual Studio Community because is the most complete respect to Unity, I know Visual Studio Code has a lot but a lot of plugins but this one never give me the feeling of a real IDE.

> 2.6 What issues or limitations have you recently experienced using Unity?

Recently after works for more than 3 hours on the project, every time I want to open a script Unity opens a new Visual Studio Community complete and not a tab (Like usually does) and the project starts to get slower every time and I have to reset my PC.

> 2.7 What strategies or best practices can be used to optimize the CPU and GPU
usage in an application made with Unity?

Well, that depends on the project and platform, for basics if you have any 3D model you can comprise first with the 3d modeler, then Unity has differents options for compress 3D models. After that the sprites if they are divisible by 4 they can be compressed. And in the Profiler Window, you can watch what is the main problem for your CPU and GPU usage.

> 2.8 How do you catch and investigate crashes happening in a released game?

Well if it is in QA testing I'll use the log entry which one I can get in the build settings and can be saved in the middle of the game.

> 2.9 Compare the following function and macro definitions. In what cases will they produce different results and/or side effects?

``` bash
int square(int val) { return val*val; }
#define square(val) (val*val)
```

The first one is a normal function and will return an integer and the second one is a platform that is #define witch define directives like UnityEditor so I don't think that one it's going to work.

> 2.10 What is the package manager in Unity and what is the alternative way of adding a package than via the package manager UI?

The package manager in Unity is an easy way of add and control differents packages for a project, This now works in different ways inside the project without oversaturating and cluttering the assets section. Another way of add is with a .unitypackage which is a format to add the package in the Assets Folder.

> 2.11 Examine the following function. What does it accomplish?

```bash
int someFunction(int i) {
  int n = 0;
  while (i) {
    i &= i-1;
    n++;
  }
  return n;
}
```
This function returns an integer, when calling it and giving it the value inside it, it reproduces a while loop which I don't know if it would work since this "& =" is used for booleans.


# Last words
Thank you so much for this opportunity I really enjoy doing this test, it was a good challenge to improve my Unity skills and my knowledge of this tool.