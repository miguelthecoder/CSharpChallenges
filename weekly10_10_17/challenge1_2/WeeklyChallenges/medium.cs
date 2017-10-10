using System;
namespace WeeklyChallenges
{
    public class medium
    {
        public medium()
		{
			int i = 8; //Convert.ToInt32(TextBox1.Text);
			string str = "";
			string str1 = "";

			for (int j = 0; j < i; j++)
			{
				str1 = "";
				for (int l = 0; l <= i - j; l++)
				{
					str = str + " ";
				}
				for (int m = 0; m <= (j - 1); m++)
				{
					str1 = str1 + "*";
				}
				for (int k = 0; k <= j; k++)
				{
					str = str + "*";
				}
				str = str + str1 + System.Environment.NewLine;
			}
			string strTriangle = str;
        }
    }
}
