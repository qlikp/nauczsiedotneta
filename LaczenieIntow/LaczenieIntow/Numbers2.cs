using System;
using System.Collections.Generic;
using System.Linq;


namespace LaczenieIntow
{
    class Numbers2
    {


        private List<ProcessingObject> processingData = new List<ProcessingObject>() { };

        public string maxNumber, minNumber;

      
        public Numbers2 (string[] args)
        {
            
            int maxLen = args.Select(n => n.Length).OrderByDescending(n => n).First();

            foreach (var a  in args)
            {
                var modVal = a;

                for (int i = a.Length; i<maxLen; i++)
                {
                    modVal += a.ToCharArray().Last();
                }

                processingData.Add(new ProcessingObject { oryginalVal = a, modyfVal = modVal });

            }

            this.Order();
        }

        void Order()
        {
            string temp_maxVal, temp_minVal;

            temp_maxVal = string.Join("",processingData.OrderByDescending(n => n.modyfVal).Select(a => a.oryginalVal).ToArray());
            temp_minVal = string.Join("", processingData.OrderBy(n => n.modyfVal).Select(a => a.oryginalVal).ToArray());


            if (int.TryParse(temp_maxVal, out int i))
            {
                maxNumber = temp_maxVal;
            }
            else
            {
                maxNumber = "Wynik nie mieści się w typie Int";
            }

            if (int.TryParse(temp_minVal, out int j))
            {
                minNumber = temp_minVal;
            }
            else
            {
                minNumber = "Wynik nie mieści się w typie Int";
            }


        }



    }
    class ProcessingObject
    {
        public string oryginalVal { get; set; }
        public string modyfVal { get; set; }
    }
}
