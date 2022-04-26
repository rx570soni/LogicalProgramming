using System.Collections.Generic;
namespace CouponNo
{
	public class Program
	{
		static Random rnd = new Random();

		public static void Main(String[] arg)
		{
			HashSet<int> linkedHashSet = new HashSet<int>();
			Console.WriteLine("Enter the no of coupon you need");
			int n = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < n; i++)
			{
				linkedHashSet.Add(rnd.Next());
			}
			foreach (var couponNo in linkedHashSet)
			{
				Console.WriteLine("your coupon no is " + couponNo);
			}
		}
	}
}