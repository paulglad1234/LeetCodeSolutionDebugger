namespace Tasks
{
    public class SquaresOfASortedArray : ITask
    {
        public string Description => "Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.";

        public object Solve(params object[] parameters)
        {
            var nums = (int[])parameters[0];
            var res = new int[nums.Length];
            var i = 0;
            var j = nums.Length - 1;
            var a = nums[i] * nums[i];
            var b = nums[j] * nums[j];
            var index = j;
            while (i <= j)
            {
                while (a <= b)
                {
                    res[index] = b;
                    index--; j--;
                    b = nums[j] * nums[j];
                }
                while (b < a)
                {
                    res[index] = a;
                    index--; i++;
                    a = nums[i] * nums[i];
                }
            }
            return res;
        }
    }
}
