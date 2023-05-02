using System.Collections;

ArrayList names = new ArrayList() { "gaurab", "shyam","sugam","anjil"};

foreach (string name in names)
{
    Console.WriteLine(name);
} 



for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}


//string[] name = new string[1] {"gaurab"};