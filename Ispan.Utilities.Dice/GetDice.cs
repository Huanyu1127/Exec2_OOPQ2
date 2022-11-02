using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities.Dice
{
	public class GetDice
	{
		public int[] GetDiceNumber()
		{
			int[] number = new int[7];
			Random random = new Random();
			int randomNumber = random.Next(1, 7);
			for (int i = 0; i < 4; i++)
			{
				randomNumber = random.Next(1, 7);
				number[i] = randomNumber;
			}
			//1.2.3.4.5.6
			int[] result = { number[0], number[1], number[2], number[3] };
			return result;
		}
		//若僅一組二個數字重複，取不重複相加
		//若二組數字重複，取二組數字最大相加
		//四個數字重骰
		//三個數字重複，把重複二個刪掉，剩下的重複和不重複相加
	}
}
