# Missing Number Finder (C# Console App)

## 📌 Description

This C# console program reads 5 integers from the user and finds the **missing number in a sequence** of consecutive numbers.

The program assumes:

* The numbers are in **ascending order**
* There is **exactly one missing number**
* The numbers form a continuous sequence (e.g., 12, 13, 15, 16, 17)

---

## 🧠 How It Works

1. The program stores user input into an integer array.
2. It saves the first number as the starting point of the sequence.
3. It loops through the array and checks whether each element matches what it should be:

   * Expected value = `start + index`
4. When a mismatch is found, that expected value is printed as the missing number.

---

## ▶️ Sample Input

```
12  
13  
15  
16  
17  
```

## ✅ Output

```
Missing number is: 14
```

---

## 🛠️ Code

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("INPUT NUMBERS");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int start = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != start + i)
            {
                Console.WriteLine("Missing number is: " + (start + i));
                break;
            }
        }
    }
}
```

---

## ⚠️ Limitations

* Only works if the array is **sorted**
* Only finds **one missing number**
* Assumes no duplicates

---

## 🚀 Possible Improvements

* Handle unsorted input
* Find multiple missing numbers
* Add input validation
* Turn this into a reusable method

---

## 👨‍💻 Author

Kh Muhammad Ali
