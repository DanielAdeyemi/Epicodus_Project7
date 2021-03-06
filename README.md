## <div align="center">Pierre's Bakery</div>
#### <div align="center">📚 *Epicodus Independent Project # 7  (Week 1 of C#)  2/26 - 3/1/2021* </div> 
***<p align="right">By Daniel Adeyemi***</p>   
<p align="center">

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>    
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.

<div style="text-align:center"><img src="http://blog.fagorindustrial.com/wp-content/uploads/2018/05/Como-montar-un-bakery-new.jpg" alt="Bakery image" width="300"/></div>

___
## 🚩 *Description*:    
### *Want to try some delicious pastry or have fresh bread in your house? Check our app to know all about it (we also have special offers right now)*
##### *A console application for Pierre's Bakery. App displays greeting message with current prices and offers. After it prompts a user to input how many loaves of bread and pastries he/she wants to buy and displays final price. If you input negative number - it will be interpreted as 0.*


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Epicodus_Project7.git).
* * At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

<img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>

* Unzip the file, navigate to the `Bakery/Models` directory to check code or to the `Bakery.Tests/ModelTests` directory to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Epicodus_Project7.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet).*
### 📋 Specs:
![check-code-coverage](https://img.shields.io/badge/code--coverage-100%25-brightgreen)
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :------------- | :------------: | :-------------: |
| 01 | display price for bread | "" | 0 | ✅ |
| 02 | display price for pastry | "" | 0 | ✅ |
| 03 | if user inserts 1 loaf of bread display $5 | Bread:1 Pastry: 0| 5 | ✅ |
| 04 | if user inserts 1 pastry display $2 | Bread:0 Pastry: 1| 2 | ✅ |
| 05 | if user inserts 1 pastry and 1 bread display $7 | Bread:1 Pastry: 1| 7 | ✅ |
| 06 | if user inserts 2 loaves of bread display 10 | Bread:2 Pastry: 0 | 10  | ✅|
| 07 | if user inserts 2 pastries display 4 | Bread:0 Pastry: 2 | 4  |✅ |
| 08 | if user inserts 2 pastries and 2 loaves of bread display 14 | Bread:2 Pastry: 2 | 14  | ✅|
| 09 | if user inserts 3 loaves of bread display 10| Bread: 3 Pastry: 0  | 10 | ✅|
| 10 | if user inserts 3 pastries display 5| Bread: 0 Pastry: 3  | 5 | ✅|
| 11 | if user inserts 3 loaves of bread and 3 pastries display 15| Bread: 3 Pastry: 3  | 15 | ✅ |
| 12 | if user inserts more than 3 loaves of bread  display correct price |  Bread: 10 Pastries: 0 | 35 | ✅|
| 13 | if user inserts more than 3 pastries  display correct price |  Bread: 0 Pastries: 10 | 17 | ✅|

</details>

#### 🏁 Running Tests:
* To run MS tests you will need to navigate to the `Bakery.Tests` folder *(cd Bakery.Tests)* in the command line and then run `dotnet restore`.
* You should now see **'obj'** folders in both the `Bakery.Tests` folder and `Bakery` folder.
* At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the Bakery.Tests folder).

####  🖥️ View website:
*GitHub page is not available for this project. To view functionality you need to run `dotnet run` from **Bakery** folder and pass requested information.*

## 🛠️ *Technologies used:*
* C#9
* .NET Core v5.0
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
This project was used to practice TDD in C# with MSTest and only can be executed in a terminal.

## 🌟 *Improvement opportunities:*
* add error handling for more detailed message what went wrong
* use more abstractions

## 📬 Contact Information
#### For any questions *[email author](mailto:adeyemidany+github@gmail.com?subject=[GitHub])*



## 📘 *License and copyright:*

> ***© Daniel Adeyemi, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*