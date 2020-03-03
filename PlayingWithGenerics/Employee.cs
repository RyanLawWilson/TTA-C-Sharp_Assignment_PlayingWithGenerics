using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingWithGenerics
{
    public class Employee<T>
    {
        public Employee()
        {
            Things = new List<T>();
        }

        public List<T> Things { get; set; }

        // Shows the list nicely.
        public void ShowList()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Things.Count; i++)
            {
                if (i % 3 == 0)
                {
                    sb.Append("\n");
                }

                sb.Append(String.Format("{0,25}  ", Things[i].ToString()));
            }

            Console.WriteLine(sb);
        }
    }
}
