# Fizz Buzz problem

FizzBuzz is a simple programming exercise that involves printing numbers from 1 to a specified number (often 100). However, there's a twist: 

- If the number is divisible by 3, print "Fizz" instead of the number. 
- If the number is divisible by 5, print "Buzz" instead of the number. 
- If the number is divisible by both 3 and 5, print "FizzBuzz" instead of the number.

**Approach:**
1. Divide the input by 15 first to catch all the numbers that are divisible by 3 and 5.

The solution is split into a main project and a test project.

There are multiple test cases that are then refactored into a reusable test with an input and expected output.

# String Reverse problem
The task involves taking a given string as input and reversing the order of its characters. For example, if the input string is "hello," the output should be "olleh."

**Approach:**
1. **Iterate Backward:**
    - We iterate through the input string from the last character to the first.
2. **Append Characters:**
    - In each iteration, we append the current character to a new string or a `StringBuilder` object.
3. **Return the Reversed String:**
    - Once we've processed all characters, we return the newly constructed reversed string.

# Vowel Count
A vowel counter is a common programming exercise that involves creating a program to count the number of vowels (a, e, i, o, u) in a given string. This is often used as a beginner-friendly task to introduce concepts like:

- **String manipulation:** Working with strings, their characters, and their lengths.
- **Looping:** Iterating over each character in the string.
- **Conditional statements:** Checking if a character is a vowel.
- **Variable declaration and assignment:** Storing the vowel count.

**Approach:**
There are three approaches taken in this solution; checking if the char is in an array using the contains method (slowest approach), Linq and checking if the char is in a hashset using the contains method. 

# Array sorting
An array of integers needs to be sorted from smallest to largest. 

**Approach:**
1. Option one is to use bubble sort which swaps adjacent values until the value has made its way along the array. 

# Pig Latin
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

**Examples:**
- "Pig latin is cool" // igPay atinlay siay oolcay
- "Hello world !" // elloHay orldway !