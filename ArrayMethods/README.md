# A array programming exercise - Array and Method

## Step 1
- Create a program that will allow the user to enter up to 25 numbers into an array. 
- Calculate and display the mean average of the numbers.

## Step 2
- Update your solution to the previous problem (make a copy and save as a new project) to use two methods with the following signatures in your solution:

    - The method will load user input numbers into the array and return the count of numbers entered.
 
    ``` 
    Function GetUserNumbers(Integer[ ] Numbers) As Int
    ```
    - The method will return the mean average of the numbers in the array.
    ```
    Function MeanAverageOfNumbers(Integer[ ] Numbers, Integer Count) As Integer
    ```
## Step 3
- Modify the previous program (make a copy and save as a new project) so that the program also displays the largest value, the smallest value, and the mode (if you don’t know what the mode is, look it up) of the numbers. 
- Use a modular approach in your solution. Your program should have at a minimum the following methods:
    - The method will return the index of the largest number in the array.
    ```
    Function LargestNumber(Integer[ ] Nums, Integer Count) As Integer
    ```
    - The method will return the index of the smallest number in the array.
    ```
    Function SmallestNumber(Integer[ ] Nums, Integer Count) As Integer
    ```
    - The method will return the mode of the numbers (if there is more than one, only one needs to be shown).
    ```
    Function Mode(Integer[ ] Nums, Integer Count) As Integer
    ```
