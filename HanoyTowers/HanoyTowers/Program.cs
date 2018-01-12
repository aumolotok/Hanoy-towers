using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoyTowers {
	class Program {
		static void Main(string[] args) {
			Tower tower1 = new Tower(5);
			Tower tower2 = new Tower();

			tower1.Give(tower2);
			tower1.Give(tower2);
		}
	}
}
