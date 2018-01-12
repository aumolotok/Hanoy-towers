using System.Collections.Generic;

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

		private int GetTopValue()
		{
			if (Discs.Count == 0)
			{
				return 0;
			}
			return Discs.Peek();
		}

		public int TopValue => GetTopValue();

		private Stack<int> Discs = new Stack<int>();
	}
}
