// Your Name
// CIS 261
// Lab 2: Iterative and Recursive Functionality

static long IterativeFactorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}


