# C# Quiz Game

This is a simple C# console application that asks the user three quiz questions. Based on the user's answers, the program provides feedback and checks if the user has won a prize.

## Features

- The program asks three multiple-choice questions.
- It tracks the number of correct answers.
- If the user answers 2 out of 3 questions correctly, they win a prize.
  
## Questions

1. **Which animal spits when angry?**
    - a) Lama
    - b) Camel

2. **Which planet is the closest to Earth?**
    - a) Venus
    - b) Mars

3. **What is the result of the following expression: `5 * 2 + 8 / 2 - 2`?**
    - a) 7
    - b) 12

## How to Run

1. Clone or download this repository.
2. Open the project in Visual Studio or any C# compatible IDE.
3. Run the program. It will prompt you for answers in the console.
4. Type your answers and press `Enter`.
5. The program will provide feedback on whether your answer is correct or incorrect.
6. If you answer two or more questions correctly, you will win a prize.

## Code Explanation

- The program initializes a counter to keep track of the correct answers.
- It displays a question and waits for user input.
- It checks if the user's input matches the correct answer and updates the counter accordingly.
- After all three questions, if the user answers at least two questions correctly, they win a prize.
