using System.Text; // include at the top
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

StringBuilder sb = new StringBuilder();

string text;
Console.Write("Enter Your range:");
//int[] array=new int[];
text = Console.ReadLine();

int[]finalRange = new int[text.Length];

if(text.Contains("-"))
{
    string[] range = text.Split('-');
    int maxNum = Convert.ToInt32(range[1]);

    List<int> rangeList = new List<int>();
    for (int runs = Convert.ToInt32(range[0]); runs <= maxNum; runs++)
    {
        rangeList.Add(runs);
    }

    // You can convert it back to an array if you would like to
    finalRange = rangeList.ToArray();

    TwistedFizzBuzz ex1 = new TwistedFizzBuzz(finalRange);
    ex1.viewFizzBuzzOutput();
}else{
    string removecommastring = text.Replace(",", " ");

    finalRange = Array.ConvertAll(removecommastring.Trim().Split(' '),Convert.ToInt32);

    TwistedFizzBuzz ex1 = new TwistedFizzBuzz(finalRange);
    ex1.viewFizzBuzzOutput();
}

