//We attempted a more advanced case of adding numbers and concatenating strings. We modified this code:
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
//We added added parentheses to clarify our intention to the compiler:
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
//This was the output:
//Bob sold 14 widgets.
