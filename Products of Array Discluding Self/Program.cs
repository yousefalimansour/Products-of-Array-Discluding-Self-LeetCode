namespace Products_of_Array_Discluding_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
          int[] ex=ProductExceptSelf(nums);
           string x= string.Join(',', ex);
            Console.WriteLine(x);
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int pre = 1;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = pre;
                pre *= nums[i];       
            }
            pre = 1;
            for (int i = (result.Length - 1); i >= 0; i--)
            {
                result[i] *= pre;
                pre *= nums[i];
            }

            return result;

        }
    }
}