Console.WriteLine("Informe uma palavra ou texto para ser invertido:");
string text = Console.ReadLine();
string invertedText = "";
for (int i = text.Length - 1; i >= 0; i--)
{
    invertedText += text[i];
}

Console.WriteLine("A palavra ou texto invertido é: " + invertedText);
