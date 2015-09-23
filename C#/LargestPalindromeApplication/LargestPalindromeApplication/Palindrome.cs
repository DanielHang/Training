using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPalindromeApplication
{
	class Palindrome
	{
		bool isPalindrome(int num)
		{
			String test = num.ToString();
			int len = test.Length;
			for (int i = 0; i <= len / 2; i++)
			{
				if (test[i] != test[len - 1 - i])
				{
					return false;
				}
			}

			return true;
		}
		internal int getLargest(int maxNum)
		{
			int largestPal = 0;
			for (int i = maxNum; i > 1; i--) {
				for (int j = maxNum; j >= i; j--)
				{
					if (isPalindrome(i * j))
					{
						if (largestPal < i*j) {
							largestPal = i * j;
						}
					}

				}
			}
			return largestPal;
		}
	}
}
