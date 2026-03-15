#region Q1
// Q1: What will this print and explain what happens?
// double d = 9.99;
// int x = (int)d;
// Console.WriteLine(x);
// print 9
//   When you cast a double to an int using (int), 
//   C# performs truncation, which means it simply "chops off" the decimal part (.99) rather than rounding it. 
//   This is an explicit cast because it results in data loss.
    #endregoin
#region Q2
//     To get the correct decimal result (2.5) with the smallest change, turn one of the numbers into a double:
// double d2 = n / 2.0; 
// In C#, int / int always results in an int. By changing 2 to 2.0, the compiler promotes the entire calculation to floating-point division, preserving the decimal.
      #endregoin
      #region Q3
//       To get an integer from user input in C#, you use int.Parse() combined with Console.ReadLine():
// int age = int.Parse(Console.ReadLine());
// Console.ReadLine() always returns data as a string.
// int.Parse() converts that string into an actual int so you can perform math or logic with it.
      #endregoin
      
    
    
