using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
	public interface IMenu<T> : IMenuItem<T>
	{
		IMenu<T> AddMenu(T i_Title);

		void AddItem(T i_Title, IMenuItemExecute i_Action);
	}
}
