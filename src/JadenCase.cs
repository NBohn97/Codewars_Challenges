using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    
    string[] phrasearray = phrase.Split(' ');
    int i = 0;

    foreach (string str in phrasearray)
    {
        string firstletter = str[0].ToString().ToUpper();
        string end = str.Substring(1);
        phrasearray[i] = firstletter + end;
        i++;
    }
    
    string upperphrase = "";
    foreach (string upperstr in phrasearray)
    {
        upperphrase += upperstr + " ";
    }

    return upperphrase.TrimEnd();
  }
}