# _Pierre's Bakery_

#### _A C# console application for a bakery., Feb 28 2020_

#### By _**Benjamin Thom**_

## Description

A user can create a Pierre's Bakery order for bread and/or pastries and the application will provide a total cost for the user's custom order.

## Preview
![Landing Page Preview](img/pierres-bakery-preview.png)

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User receives a welcome message with bread and pastry prices along with the current specials.|NA|"Welcome to Pierre's Bakery! Bakery Menu: Bread $5, Pastry $2 Current Specials: Bread: Buy 2, Get 1 Free Pastry: Buy 3 for $5"|
|User receives the following message "Would you like to order bread? Type 'y' for yes and 'n' for no"|"y"|"Enter the number of loaves of bread you would like to order:"|
|User enters the number of breads they would like to order and presses enter|"3"|Order Summary: 3 loaf(s) of bread for $10|
|User receives the following message "Would you like to order pastry(s)? Type 'y' for yes and 'n' for no"|"y"|"Enter the number of pastries you would like to order:"|
|User enters the number of pastries they would like to order and presses enter|"3"|Order Summary: 3 pastry(s) for $5|
|User receives a closing message thanking them for visiting|NA|Thank you for visiting - We look forward to doing business with you in the future!|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/pierres-bakery.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} pierres-bakery```
* On Windows: ```pierres-bakery```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/pierres-bakery.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "pierres-bakery".
* Right-click "index.html" and select your preferred browser or text editor.

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/pierres-bakery/issues) here on GitHub._

## Technologies Used

* C#
* .Net Core

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Benjamin Thom_**