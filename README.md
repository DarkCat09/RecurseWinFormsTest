# RecurseWinFormsTest
A repository with my "recurse" projects. Have fun!
## Recurse Buttons
Click on a button and it will create one more!
![Screenshot](https://i.ibb.co/3B35ZDS/1.png)
## Recurse Windows
Click on the picture and it will create a new same smaller window.
You can change mode in code: Program.cs > `static void Main()` > change the second parameter in constructor call (`new Form1(1, 0)`, change 0 to other mode).
 - 0 = program closes, when you press "Close" (red button with cross) in a small window (Width < 250).
 - 1 = use `taskkill.exe` to close the program.
 - 2 = automated creating new forms, can break your system; use `taskkill.exe` to close the program.
![Screenshot](https://i.ibb.co/F4RcCnT/2.png)
