# Number Analysis Program

This simple C# console application prompts the user to enter a number and performs the following analysis:  
1. Determines whether the number is less than, greater than, or equal to 10.  
2. Checks whether the number is even or odd.  

---

## How It Works

1. **Input Prompt**  
   The program asks the user to enter a number using `Console.WriteLine`.

2. **Input Handling**  
   The entered value is read as a string using `Console.ReadLine` and converted to an integer using `int.TryParse`.  
   If the input cannot be converted into an integer, the default value of `0` is used.

3. **Comparison with 10**  
   - If the number is less than 10, the program outputs:  
     `Girilen sayı 10'dan küçüktür.`  
   - If the number is greater than 10, the program outputs:  
     `Girilen sayı 10'dan büyüktür.`  
   - If the number is equal to 10, the program outputs:  
     `Girilen sayı 10'a eşittir.`

4. **Even or Odd Check**  
   - If the number is even (`number % 2 == 0`), the program outputs:  
     `Girilen sayı çifttir.`  
   - Otherwise, the program outputs:  
     `Girilen sayı tektir.`

---
