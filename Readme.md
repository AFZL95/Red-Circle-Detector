# Red :heart_eyes: Circle Detector

it is one of the classroom activities i have been done in "Robotics" course.
simply detect any rounded red objects using the "Emgu-CV" library and the C# programming language.

![scr](https://github.com/AFZL95/Red-Circle-Detector/blob/master/img/scr.png)

## Requirements:
> Emgu cv 
 it is the Open-CV library equivalent for the C#
 it could be found at [Emgu-cv](http://www.emgu.com/wiki/index.php/Download_And_Installation).

 > very very little skill of C(sharp) [ I totally ashamed of saying that word  :grimacing: ] 

> you can easily get used to working with Microsoft Visual Studio stuff in a few days (like i wrongly did in my present semester becuz of my Professor enforcements)
  
 > around 5-10 minutes of your spare time and a little enthusiasm!

## so what I gonna do to run this?
1. first of all, you have to promise yourself that you not gonna use Visual Studio and any other Microsoft development stuff from now on.

2. download the Emgu_CV for your platform and install it.

3. run the "ImageProcessing.sln"

4. I deliberately deleted the "packages" directory and some other dll's that Visual studio copies from the Emgu-CV installation directory into the project in the way of reducing project size. so you have to include it manually using the visual studio's dependency handler that called "Nuget package manager".

5. proceed to the "Nuget package manager" with the menu below:
 > /Tools/Nuget package manager/Package Manager Console
 
6. like the figure below you can download and resolve dependencies. when all dependencies are downloaded, you are ready to go.

![Nuget](https://github.com/AFZL95/Red-Circle-Detector/blob/master/img/Nuget.png) 

7. finally run the project and hold a rounded Pepsi in front of your webcam.
