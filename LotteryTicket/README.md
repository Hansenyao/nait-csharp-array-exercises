# A array programming exercise - Lottery Ticket

## First Step
- Create a program that will generate a lottery ticket for the user. 

- The user will enter the number of values in the pick and the range. For example, a lottery pick.

```
7 13 22 34 43 46
```

- Store the values in an array of the appropriate length and ensure that there are no duplicates (i.e. the same number must not appear twice). Don’t worry about.

## Second Step

- Update the previous solution to allow the user to choose how many picks they would like (choosing 3 picks would yield three separate lottery picks). 

- Include a method that will load an array for a pick with the random values. The method:

```
static void QuickPick(int[] pick, int range)
```
- The method should use the length of the array to determine how many values are in the pick. 

- Since arrays are passed by reference, there is no need to return anything.
