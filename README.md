![](https://raw.githubusercontent.com/eahs/FBLASocialApp/development/Media/YakkaLogo.png)

# FBLA Social App 1.0 README

By Makenna Swartz, Samyutka Neeraj, and Vincent Lauro

Easton Area High School

Easton, PA

  

  

Yakka is a professional social media app giving students the ability to share real life events with the option to put that on their resume. It is a mobile application for Android and iOS devices. To login into the app, users must first sign in using an email and password or authenticate using Google. Once in the app, members can view their wall, add friends, privately message other students, create posts, view their resume, and much more! On the “Settings” page, users will have access to their profile information, the Terms of Service, Privacy Policy, and all of our other important links to help make Yakka a safer and better social media platform.

  

  

## Features

  

- Designed for Android and iOS devices
- Login System utilizing JWTs
- Ability to sign in using Google
- Information about Yakka and the TOS
- Create posts that get featured on your personal wall
- An accompanied backend for administrative purposes
- Secure server running 24/7
- Change privacy settings on your account, giving you control over who can see it
- Swagger for easy-to-use API documentation
- Posts can have multiple reactions of different types
- Able to add posts to favorites
- Chats and private messages
- A bug reporting system


  

  

## Folder Layout

  

**/Compiled App**

  

> Contains our compiled, signed app in APK form for Android platforms

  

**/Documentation**

  

> Contains PDF overview of the app along with screenshots and explanations of all functionality

  

**/Source**

  

> Contains Visual Studio 2019 solution file

  

  

## How To Run

  

This mobile application was developed in C# using Visual Studio 2019 and the Xamarin Platform on Microsoft Windows. Contained within the competition submission is a folder named “CompiledApp” that contains a signed APK that was created for Android and iOS phones and emulators. Simply install the APK to your mobile device and run.

  

  

## Build Instructions

  

Visual Studio Requirements:

  

- Visual Studio 2019 Windows Community Edition

- Android Platform 28 SDK (Pie)

  

In order to build you will need Visual Studio or Visual Studio for Mac. Upon opening the Visual Studio solution it will immediately download all necessary packages from Nuget. You will need to execute a debug version of either the FBLASocialApp.Android or FBLASocialApp.iOS project either on a simulator or by connecting an Android mobile device that has Developer Options and Enable USB debugging turned on.
  

## Resources Used

  

Menu Icons from Icons8 - https://icons8.com/

Background Image from Pexels - https://www.pexels.com/

Font Awesome - https://fontawesome.com/

Pixabay - https://pixabay.com/

Unsplash - https://unsplash.com/


  

## Software and Services Used

  

GitHub - [https://github.com/](https://github.com/)

  

> Github is an online source hosting service based around the Git version control system. We utilized Github to store source code revisions during this project.

  

  

ZenHub - [https://zenhub.com/](https://zenhub.com/)

  

> ZenHub was used to create a product backlog, set goals and assign tasks to assure that we met the deadline and that all team members new their responsibilities.

  

  

GitKraken - [https://www.gitkraken.com/](https://www.gitkraken.com/)

  

> Gitkraken was utilized to manage code revisions, resolve merge conflicts, and test experimental branch features.

  

  

Instabug - [https://instabug.com/](https://instabug.com/)

  

> We utilize Instabug to provide comprehensive bug reporting and in-app feedback from our users during beta testing. Instabug automatically attaches steps to reproduce the bug, network request logs and view hierarchy inspections with each bug report. It also allows users to record videos demonstrating their problem.

  

  

Microsoft Visual Studio 2019

  

> IDE for developing Xamarin.Forms applications in C#

  

  

Balsamiq - [https://balsamiq.com/](https://balsamiq.com/)

  

> Balsamiq was used to create wireframes and UI mockups so that we had a reference to work off of.

  

  

## Additional Software Components

  

Newtonsoft.Json by James Newton-King - [https://www.nuget.org/packages/Newtonsoft.Json/](https://www.nuget.org/packages/Newtonsoft.Json/)

  

> Json.NET is a popular high-performance JSON framework for .NET



Microsoft.AppCenter by Microsoft -  https://azure.microsoft.com/en-us/services/app-center/



> This package contains the basic functionalities that all App Center services use to communicate with the backend, including reports on analytics and crashes.



MonkeyCache by James Montemagno - https://github.com/jamesmontemagno/monkey-cache



> A simple caching library to cache any data structure for a specific amount of time in any .NET application. Additionally, offers simple HTTP methods for caching web request data.



JSON Web Tokens(JWT) by Auth0 - https://jwt.io



> Authentication system using tokens creating a secure way to access information and data.



### Xamarin

Xamarin.Essentials by Microsoft - [https://www.nuget.org/packages/Xamarin.Essentials/](https://www.nuget.org/packages/Xamarin.Essentials/)

  

> Xamarin.Essentials: a kit of essential API's for your apps

  

Xamarin.Forms by Microsoft - [https://www.nuget.org/packages/Xamarin.Forms/](https://www.nuget.org/packages/Xamarin.Forms/)

  

> Build native UIs for iOS, Android, UWP, macOS, Tizen and many more from a single, shared C# codebase

  

Xamarin.FFImageLoading by Daniel Luberda, Fabien Molinet - [https://www.nuget.org/packages/Xamarin.FFImageLoading/](https://www.nuget.org/packages/Xamarin.FFImageLoading/)

  

> Xamarin Library to load images quickly and easily

  

### Syncfusion

Syncfusion Essential UI Kit for Xamarin by Syncfusion Inc. - https://www.syncfusion.com/essential-xamarin-ui-kit 

  

> This Essential UI Kit repository contains elegantly designed XAML templates for Xamarin.Forms apps. These templates are compatible with Android, iOS, and UWP platforms, and use the MVVM design pattern to provide trouble-free integration.

  

  

Syncfusion.Xamarin.Core by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.Core/](https://www.nuget.org/packages/Syncfusion.Xamarin.Core/)

  

> This package contains common classes and interfaces that are used in other Syncfusion Xamarin UI controls
  
  

Syncfusion.Xamarin.SfListView by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.SfListView/](https://www.nuget.org/packages/Syncfusion.Xamarin.SfListView/)

  

> Syncfusion ListView for Xamarin.Forms is a feature rich list control that renders a set of data items with views or custom templates. It has many features like grouping, sorting, filtering, paging, swiping, multiple selection, dragging and dropping, and layout types. This control has also been optimized to work with large amounts of data.

  

Syncfusion.Xamarin.SfComboBox by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.SfComboBox/](https://www.nuget.org/packages/Syncfusion.Xamarin.SfComboBox/)

  

> The Syncfusion Combo Box for Xamarin.Forms is used to select an item by typing a value or selecting a value from the list.

  

Syncfusion.Xamarin.Buttons by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.Buttons/](https://www.nuget.org/packages/Syncfusion.Xamarin.Butons/)

  

> The Syncfusion Buttons for Xamarin.Forms is a custom button control with UI customization, toggle states, and theme support. You can set icons,custom content, background images  background images and corner edge radii and customize the appearance for different visual states using the visual state manager.



Syncfusion.Xamarin.Cards by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.Cards/](https://www.nuget.org/packages/Syncfusion.Xamarin.Cards/)

  

> Syncfusion Cards for Xamarin.Forms provides a perfect way to display content in an intuitive way.



 Syncfusion.Xamarin.SFBadgeView by Syncfusion Inc. - [https://www.nuget.org/packages/Syncfusion.Xamarin.SFBadgeView/](https://www.nuget.org/packages/Syncfusion.Xamarin.SFBadgeView/)

  

> Syncfusion BadgeView control for Xamarin.Forms is a notification control consists of small shapes such as circle and rectangle which contain a number or message. It is used to show the notification count, messages and status of something. It has key features such as animation, predefined shapes and badge color types. The position of the control can be easily customizable.



## References

  
 
- https://github.com/eahs/FBLAManager
- “FBLA-PBL.” FBLA-PBL, www.fbla-pbl.org/.
- https://www.fbla-pbl.org/fbla/competitive-events/

  

## License

  

The MIT License (MIT)

  

Copyright (c) 2020

  

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

  

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

