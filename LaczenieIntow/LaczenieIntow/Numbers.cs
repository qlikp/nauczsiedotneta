using System;
using System.Collections.Generic;
using System.Linq;


namespace LaczenieIntow
{
    class Numbers
    {
        List<string> numberList = new List<string>();
        public int maxInt;
        public int minInt;
        public string errorText = "";
        public Numbers(string[] args)
        {

            if (args.Length > 0)
            {
                foreach (var a in args)
                {
                    if (int.TryParse(a, out int outputVal))
                    {
                        numberList.Add(a);

                    }

                }
            }

            this.OrderingTool();

        }

        private void OrderingTool()
        {
            string maxN_str = "";
            string minN_str = "";

            foreach (var a in numberList.OrderByDescending(n => n))
            {
                maxN_str += a;

            }

            foreach (var a in numberList.OrderBy(n => n))
            {
                minN_str += a;

            }

            try
            {

                maxInt = Int32.Parse(maxN_str);
                minInt = Int32.Parse(minN_str);
            }
            catch (FormatException)
            {
                errorText = "There is no 'Int' on input";
            }
            catch (OverflowException)
            {
                errorText = "Output number is too big to be an 'Int' type";
            }


        }


    }
}
