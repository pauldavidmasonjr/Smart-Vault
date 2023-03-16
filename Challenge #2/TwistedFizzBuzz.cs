using System.Text;
    public class TwistedFizzBuzz
    {

        int[] range;
        IDictionary<int, string> divisablesMap = new Dictionary<int, string>();

        public TwistedFizzBuzz(int[] range)
        {
            this.range = range;
        }

        public TwistedFizzBuzz(int[] range, IDictionary<int, string> diviMap)
        {
            this.range = range;
            this.divisablesMap = divisablesMap;
        }

        public void viewFizzBuzzOutput()
        {
            Console.Write("in view ouput\n");
            StringBuilder sb = new StringBuilder();
            
            if(this.divisablesMap.Count == 0)
            {
                foreach(int i in this.range)
                {
                    if(i%3 == 0)
                        sb.Append("Fizz\n");
                    if(i%5 == 0)
                        sb.Append("Buzz\n");
                    if(i%3 != 0 && i%5 != 0)
                        sb.Append(i + "\n");
                }
            }

            //output final result
            for(int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]); 
        }
    }