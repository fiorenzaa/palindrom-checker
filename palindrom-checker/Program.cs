static bool IsPalindrome(string? text)
{
  if (string.IsNullOrWhiteSpace(text))
    return false;

  string reversed = "";

  for (int i = text.Length - 1; i >= 0; i--)
    reversed += text[i];

  return text == reversed;
}

Console.Write("Masukkan kata: ");
string? input = Console.ReadLine();

Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Bukan Palindrome");
