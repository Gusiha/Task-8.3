using System.Diagnostics;
using System.Text.RegularExpressions;
using Task_8._3;

User user = new("Timur", 19, "RTX_3080ti", "buythebycycle@rambler.ru");
Reciever file = new($@"C:\Users\{Environment.MachineName}\MyTest.txt");

Messenger<User,Reciever> messenger = new(user,file);
messenger.SendMessage();





