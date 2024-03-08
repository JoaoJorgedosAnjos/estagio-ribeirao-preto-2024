Console.WriteLine("Informe um número para verificar se ele pertence à sequência de Fibonacci: ");
int number = int.Parse(Console.ReadLine());

if (IsFibonacci(number))
{
    Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {number} não pertence à sequência de Fibonacci.");
}
static bool IsFibonacci(int number)
{
    int firstNumber = 0;
    int secondNumber = 1;

    while (secondNumber < number)
    {
        int nextNumber = firstNumber;
        firstNumber = secondNumber;
        secondNumber = nextNumber + secondNumber;
    }

    return secondNumber == number;
}