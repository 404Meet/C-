public class Blind75Array
{
    public static int[] TwoSum(int[] arr, int size, int target)
    {
        //This approach can be used if we want to return indexes of the element and we want to use HashMap. 
        Dictionary<int, int> HashMap = new Dictionary<int, int>();
        //HashMap will contain key as elements and Value as Indexes [element,index].
        for (int i = 0; i < size; i++)
        {
            int more = target-arr[i];
            if (HashMap.ContainsKey(more))
            {
                return [HashMap[more], i];
            }
            else HashMap.Add(arr[i], i);
            //HashMap[arr[i]] = i;
        }
        return [-1, -1];
    }//Time Complexity:O(N) Space Complexity:O(N)

    public static void TwoSumGreedyApproach(int[] arr, int size, int target)
    {
        //This approach can be used when index is not be maintained, as sorting will change indexes.
        //Greedy Approach.
        //Two Pointers will be used.
        Array.Sort(arr);
        int left = 0;
        int right = size - 1;
        while (left < right)
        {
            int sum = arr[left] + arr[right];
            if (sum == target)
            {
                Console.WriteLine($"Two Elements are {arr[left]} and {arr[right]}");
                break;
            }
            if (sum < target) left++;
            if (sum > target) right--;
        }
    }//Time Complexity:O(N+Nlogn) Space Complexity:O(1)

    public static void MaximumSubArray(int[] arr)
    {//Using Kadane's Algorithm
        int max = int.MinValue;
        int sum = 0;
        int IStart = -1;
        int IEnd = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (sum == 0)
            {
                IStart = i;
            }
            sum = sum + arr[i];
            if (sum > max)
            {
                max = sum;
                IEnd = i;
            }
            //max=Math.Max(max,sum);
            if (sum < 0)
            {
                sum = 0;
            }
        }
        Console.WriteLine("Maximum Subarray is: " + max);
        Console.WriteLine("Max Subarray Index : " + IStart + " to " + IEnd); 
    }//Time Complexity:O(N) Space Complexity:O(1)
    public static void Main(String[] args)
    {

        Console.WriteLine("Enter the size of Array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter Array Inputs:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the target to be searched:");
        int target = Convert.ToInt32(Console.ReadLine());
        TwoSumGreedyApproach(arr, size, target);
        int[] index = TwoSum(arr, size, target);
        Console.WriteLine($"Two Indexes are {index[0]} , {index[1]}");
        Console.WriteLine("Two Indexes are {0},{1}", index[0], index[1]);
        //2,6,4,7,9 target:11
        MaximumSubArray(arr);
    }
}