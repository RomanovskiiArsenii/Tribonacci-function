# Tribonacci function
The Tribonacci function is a mathematical function that generates a sequence of numbers known as the Tribonacci sequence. It is similar to the more well-known Fibonacci sequence, but instead of starting with two initial values, the Tribonacci sequence starts with three initial values.

The Tribonacci sequence is defined by the recurrence relation:

T(n) = T(n-1) + T(n-2) + T(n-3)

where T(0), T(1), and T(2) are the three initial values of the sequence.

Here's an example of the Tribonacci sequence starting with the initial values 1, 1, and 2:

1, 1, 2, 4, 7, 13, 24, 44, 81, ...

Each subsequent number in the sequence is the sum of the three preceding numbers.

The Tribonacci function takes the initial signature array/list and the number of elements 'n' as input and returns an array of the first 'n' elements of the Tribonacci sequence, including the initial signature. The function calculates the elements of the sequence by using a loop and storing the values in an array, which is then returned as the result.
