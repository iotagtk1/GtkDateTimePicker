****# GtkDateTimePicker

Calendar and time picker are available

![alt text](./GtkDateTimePicker/readMe/1.png)

```cs

 MainDialog MainDialog1 = new MainDialog();

 MainDialog1.DateTimeObj = DateTime.Now;

 var r = MainDialog1.Run();

 if (r == 1) {
     Console.WriteLine(MainDialog1.DateTimeObj);
 }

```