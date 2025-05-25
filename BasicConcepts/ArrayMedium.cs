public class ArrayMedium{

    public static int[] TwoSum(int[] arr, int n, int target){
        //This approach can be used if we want to return indexes of the element and we want to use HashMap. 
        Dictionary<int,int> HashMap = new Dictionary<int, int>();
        for(int i=0;i<n;i++){
            int more=target-arr[i];
            if(HashMap.ContainsKey(more))
            {
                return[HashMap[more],i];
            }
            HashMap.Add(arr[i],i);
            //HashMap[arr[i]]=i;
       }
       return[-1,-1];
    }//Time Complexity:O(N) Space Complexity:O(N)

    public static void TwoSumGreedyApproach(int[] arr, int n, int target){
        //This approach can be used when index is not be maintained, as sorting will change indexes.
        //Greedy Approach.
        int left=0;
        int right=n-1;
        Array.Sort(arr);
        while(left<right){
            int sum = arr[left]+arr[right];
            if(sum==target){
                Console.WriteLine($"Two Sum Elements are: {arr[left]} {arr[right]}");
                break;
            }
            if(sum<target) left++;
            if(sum>target) right--;
        }
    }//Time Complexity:O(N+Nlogn) Space Complexity:O(1)

    public static void SortAnArrayof012(int[] arr, int n){
        //Dutch National Flag Algorithm or Three Pointer Algorithm
        int low=0;
        int mid=0;
        int high=n-1;
        while(mid<=high){
            if(arr[mid]==0){
                (arr[mid],arr[low])=(arr[low],arr[mid]); //swap mid with low;
                low++;
                mid++;
            }
            else if(arr[mid]==1){
                mid++;
            }
            else if(arr[mid]==2){
                (arr[mid],arr[high])=(arr[high],arr[mid]); //swap mid with high
                high--;
            }
        }
    }//Time Complexity: O(N) Space Complexity: O(1)


    public static void MajorityElement(int[] arr, int n){
        //uses Moore's voting algorithm.
        int cnt=0;
        int element=0;
        for(int i=0;i<n;i++){
            if(cnt==0){
                element=arr[i];
                cnt++;
            }
            else if(arr[i]==element){
                cnt++;
            }
            else{
                cnt--;
            }
        }

        int cnt2=0;
        for(int i=0;i<n;i++){
            if(element==arr[i]){
                cnt2++;
            }
        }
        if(cnt2>n/2){
            Console.WriteLine($"Element greater than majority is {element}");
        }
        else{
            Console.WriteLine("No Majority Element found");
        }
    }//Time Complexity: O(N)+O(N) Space Complexity:O(1)
    public static void Main(String[] args){
        // Console.WriteLine("Enter Target");
        // int target=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter Array Size");
        // int size=Convert.ToInt32(Console.ReadLine());
        // int[] arr= new int[size];
        // Console.WriteLine("Enter Array Inputs");
        // for(int i=0;i<size;i++){
        //     arr[i]=Convert.ToInt32(Console.ReadLine());
        // }
        // TwoSumGreedyApproach(arr,size,target);
        // int[] index=TwoSum(arr,size,target);
        // Console.WriteLine("Indexes of Two Sum Elements are: ");
        // for(int i=0; i<index.Length; i++){
        //     Console.Write(index[i]);
        // }
        // Console.ReadLine();

        // Console.WriteLine("Enter Array Size");
        // int n=Convert.ToInt32(Console.ReadLine());
        // int[] arr1= new int[n];
        // Console.WriteLine("Enter Array Inputs with 0's 1's and 2's: ");
        // for(int i=0;i<n;i++){
        //     arr1[i]=Convert.ToInt32(Console.ReadLine());
        // }
        // SortAnArrayof012(arr1,n);
        // Console.WriteLine("Sorted Array: ");
        // for(int i=0; i<arr1.Length; i++){
        //      Console.Write(arr1[i]);
        // }
        // Console.ReadLine();

        Console.WriteLine("Enter Array Size");
        int num=Convert.ToInt32(Console.ReadLine());
        int[] arr2= new int[num];
        Console.WriteLine("Enter Array Elements with majority ");
        for(int i=0;i<num;i++){
            arr2[i]=Convert.ToInt32(Console.ReadLine());
        }
        MajorityElement(arr2,num);//element which is greater than num/2
    }

}