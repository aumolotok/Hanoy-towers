using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HanoyTowers {
	class Tower {

		public Tower(int maxDick)
		{
			for (int i = maxDick; i > 0; i--)
			{
				Discs.Push(i);
			}
		}

		public Tower() { }


		public bool Push(int income)
		{
			if (income < TopValue)
			{
				Discs.Push(income);
				return true;
			}
			return false;
		}

		public bool Give(Tower acceptor)
		{
			if (acceptor.Push(Discs.Peek()))
			{
				Discs.Pop();
				return true;
			}
			return false;
		}

		private int TopValue => Discs.Peek();

		

		private Stack<int> Discs = new Stack<int>();
	}
}
