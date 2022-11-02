using Ispan.Utilities.Dice;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			answerlbl.Text = string.Empty;
		}
		private void dicebtn_Click(object sender, EventArgs e)
		{
			GetDice dice = new GetDice();
			int[] result = dice.GetDiceNumber();

			dice1txt.Text = result[0].ToString();
			dice2txt.Text = result[1].ToString();
			dice3txt.Text = result[2].ToString();
			dice4txt.Text = result[3].ToString();

			int[] valueArray = { 0, 0, 0, 0, 0, 0, 0, };
			int answer = 0;
			int temp = 0;

			for (int i = 0; i < result.Length; i++)
			{
				valueArray[result[i]]++; //Dice1=5.2.3.4
			}
			for (int i = 0; i < valueArray.Length; i++)
			{
				if (valueArray[i] == 4)
				{
					answer = i * 2;
					break;
				}	
				else if (valueArray[i] == 3)
				{
					temp = i;
					for(int j=0; j<valueArray.Length; j++)
					{
						if (valueArray[j] == 1)
						{
							answer = i + j;
							break;
						}
					}
				}
				else if (valueArray[i] == 2)
				{
					for (int j = 0; j < valueArray.Length; j++)
					{
						if (valueArray[j] == 1)
						{
							answer += j;
						}
						else if (valueArray[j] == 2)
						{
							if (i < j)
							{
								answer = j * 2;
							}
						}
					}
				}
			}
			if (answer == 0)
			{
				MessageBox.Show("重骰");
				answerlbl.Text = string.Empty;
				return;
			}
			answerlbl.Text = answer.ToString();
		}
	}
}
