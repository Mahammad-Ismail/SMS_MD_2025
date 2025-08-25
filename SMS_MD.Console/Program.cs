// See https://aka.ms/new-console-template for more information
using System;
using SMS_MD.Console;

Console.WriteLine("Hello, World!");
User defaultuser = new User();

defaultuser.Greet();

User customuser = new User("Ismail",25);
string greetingmsg=customuser.Greetwithreturn();
Console.WriteLine(greetingmsg);

string custommesg = customuser.Greetwithreturn("Abdul", 30);
Console.WriteLine(custommesg);
Console.ReadLine();
