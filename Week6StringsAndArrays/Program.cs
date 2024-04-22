string hello = "hello, world! siin me oleme!";

int stringLength = hello.Length;

// string trimmedString = hello.Trim(); // Console.WriteLine peab minema TrimmedString, kui kasutada
hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

firstLetter = hello[0];
Console.WriteLine(firstLetter);





//int wordCounter = 0;

//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

// Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words "); //Tühikud, komad, tähemärgid jne. lähevad ka arvesse

// [ length - 1 ]

