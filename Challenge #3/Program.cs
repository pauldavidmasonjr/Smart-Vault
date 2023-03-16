using System.Text; // include at the top
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

StringBuilder sb = new StringBuilder();

string text;
Console.Write("Enter Your range:");
text = Console.ReadLine();

// string text;
// Console.Write("Enter Your range:");
// text = Console.ReadLine();

int[]finalRange = new int[text.Length];

if(text.Contains("-"))
{
    int lastOfIndex = text.LastIndexOf("-");
    string bottomOfRange = text.Substring(0, lastOfIndex);
    string topOfRange = text.Substring(lastOfIndex + 1);
    //string[] range = text.Split('-').Batch(2);
    int maxNum = Convert.ToInt32(topOfRange);

    List<int> rangeList = new List<int>();
    for (int runs = Convert.ToInt32(bottomOfRange); runs <= maxNum; runs++)
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

