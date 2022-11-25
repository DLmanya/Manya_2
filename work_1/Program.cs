int GetExponentiation(int NumberA, int NumberB)
{
  int result = 1;
  for(int i = 1; i <= NumberB; i++)
  {
    result = result * NumberA;
  }
  return result;
}
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Exponentiation = GetExponentiation(NumberA, NumberB);
Console.WriteLine("Ответ: " + Exponentiation);
