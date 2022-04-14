using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input text to encryption!");
      string message = (Console.ReadLine()).ToLower();
      char[] secretMessage = message.ToCharArray();
      string encryptedString = String.Join("",Encrypt(secretMessage, 3));
      Console.WriteLine(encryptedString);
      
      Console.WriteLine("Input text to decryption!");
      string cryptedMessage = (Console.ReadLine()).ToLower();
      char[] encryptedMessage = cryptedMessage.ToCharArray();
      string secretString = String.Join("",Decrypt(encryptedMessage, 3));
      Console.WriteLine(secretString);

    }

    static char[] Encrypt(char[] secretMessage, int iter)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char[] encryptedMessage = new char[secretMessage.Length];
      for(int i = 0 ; i < secretMessage.Length ; i++)
      {
        if(Char.IsLetter(secretMessage[i]))
          {
            int encryptedCharIndex = (Array.IndexOf(alphabet,secretMessage[i]) + iter) % alphabet.Length;
          char encryptedChar = alphabet[encryptedCharIndex];
          encryptedMessage[i] = encryptedChar;
          }
        else
        {
          encryptedMessage[i] = secretMessage[i];
        }
      }
      return encryptedMessage; 
    }

    static char[] Decrypt(char[] encryptedMessage, int iter)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char[] secretMessage = new char[encryptedMessage.Length];
      for(int i = 0 ; i < encryptedMessage.Length ; i++)
      {
        if(Char.IsLetter(encryptedMessage[i]))
          {
            int secretCharIndex = (Array.IndexOf(alphabet,encryptedMessage[i]) - iter + alphabet.Length) % alphabet.Length;
          char secretChar = alphabet[secretCharIndex];
          secretMessage[i] = secretChar;
          }
        else
        {
          secretMessage[i] = encryptedMessage[i];
        }
      }
      return secretMessage; 
    }

  }
}