// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 1.
string inputS = Console.ReadLine();
char[] reverse = inputS.ToCharArray();

for (int i= reverse.Length-1;i>=0;i--)
{
    Console.Write(reverse[i]);
}



// 2.
using System;

string inputS = Console.ReadLine();
char[] separators = new char[] {'.',',',':',';','=','(',')','&','[',']','\"','\'','\\','/','!','?',' '};
string[] sentence = inputS.Split(separators);

int flag=0, wordIdx= 1;
Array.Reverse(sentence);

Console.WriteLine();
for (int i=0; i< inputS.Length;i++)
{
    if (separators.Contains(inputS[i]))
    {
        if (inputS[i]==' ')
        {
            if (flag==0)
            {
                while (sentence[wordIdx] == "")
                {
                    wordIdx++;

                }
                Console.Write(sentence[wordIdx]);
                wordIdx++;
                flag++;
            }
            else if (wordIdx < sentence.Length)
            {
                while (sentence[wordIdx] == "")
                {
                    wordIdx++;

                }
                Console.Write(" "+sentence[wordIdx]);
                wordIdx++;
            }
        }else if (wordIdx<sentence.Length)
        {
            while (sentence[wordIdx] == "")
            {
                wordIdx++;

            }
            Console.Write(" "+sentence[wordIdx]+inputS[i]);
            wordIdx++;
        }else
        {
            Console.Write(inputS[i]);
        }

    }
}



// 3.
string inputS = Console.ReadLine();
char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
string[] sentence = inputS.Split(separators);
string revSentence;

List<String> res = new List<String>();

for (int i =0; i<sentence.Length;i++)
{
    if (sentence[i]!="")
    {
        char[] tmp = sentence[i].ToCharArray();
        Array.Reverse(tmp);
        revSentence = new string(tmp);

        if (revSentence == sentence[i])
        {
            res.Add(sentence[i]);
        }
    }
}

res.Sort();
foreach (var i in res) Console.Write(i+", ");



// 4.
string inputS = Console.ReadLine();
string[] separators = new string[] { "://","/" };
string[] url = inputS.Split(separators,System.StringSplitOptions.RemoveEmptyEntries);
string protocol="", server="", resource="";


if (url.Length==3)
{
    protocol = url[0];
    server = url[1];
    resource = url[2];
}else if (url.Length == 2)
{
    if (inputS.Contains(separators[0]))
    {
        protocol = url[0];
        server = url[1];
    }
    else
    {
        server = url[0];
        resource = url[1];
    }
}
else
{
    server = url[0];
}

Console.WriteLine("[protocol] = \"" + protocol + "\"");
Console.WriteLine("[server] = \"" + server + "\"");
Console.WriteLine("[resource] = \"" + resource + "\"");

