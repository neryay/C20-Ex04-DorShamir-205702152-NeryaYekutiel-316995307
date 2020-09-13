using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class CountSpacesAction : IMenuItemExecute
	{
		private static int s_NumberOfSpaces = 0;

		public void ExecuteItem()
		{
            string sentence;

            Console.WriteLine("Please enter a sentence:");
            sentence = Console.ReadLine();
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    s_NumberOfSpaces++;
                }
            }

            Console.WriteLine(
@"This sentence contains {0} spaces.
Press any key to step back.",
                s_NumberOfSpaces);
            s_NumberOfSpaces = 0;
            Console.ReadKey();
        }
	}
}
