using System;
using System.Collections.Generic;
using System.Linq;
namespace hariAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                   //Question1:

                   Console.WriteLine("Question 1");
                   int[] heights = { -4, -3, -2, -1, 4, 3, 2 };
                   int max_height = LargestAltitude(heights);
                   Console.WriteLine("Maximum altitude gained is {0}", max_height);
                   Console.WriteLine();

            
                   //Question 2:
                   Console.WriteLine("Question 2:");
                   int[] nums = { 1, 6, 5, 3 };
                   Console.WriteLine("Enter the target number:");
                   int target = Int32.Parse(Console.ReadLine());
                   int pos = SearchInsert(nums, target);
                   Console.WriteLine("Insert Position of the target is : {0}", pos);
                   Console.WriteLine("");
           

            //Question3:
            Console.WriteLine("Question 3");
           string[] words1 = { "cool", "lock", "cook" };
           List<string> commonWords = CommonChars(words1);
           Console.WriteLine("Common characters in all the strigs are:");
           for (int i = 0; i < commonWords.Count; i++)
           {
               Console.Write(commonWords[i] + "\t");
           }
           Console.WriteLine();
             
           

                       //Question 4:
                       Console.WriteLine("Question 4");
                       int[] arr1 = { 1, 2, 2, 1, 1, 3 }; // { 1, 2, 2, 1, 1, 3 };
           bool unq = UniqueOccurrences(arr1);
                       if (unq)
                           Console.WriteLine("Number of Occurences of each element are same");
                       else
                           Console.WriteLine("Number of Occurences of each element are not same");

                       Console.WriteLine();
            
            
          //Question 5:
          Console.WriteLine("Question 5");
          List<List<string>> items = new List<List<string>>();
          items.Add(new List<string>() { "phone", "blue", "pixel" });
          items.Add(new List<string>() { "computer", "silver", "lenovo" });
          items.Add(new List<string>() { "phone", "gold", "iphone" });

          string ruleKey = "type";
          string ruleValue = "phone";

          int matches = CountMatches(items, ruleKey, ruleValue);
          Console.WriteLine("Number of matches for the given rule :{0}", matches);
          Console.WriteLine();
            
            



                             //Question 6:
                             Console.WriteLine("Question 6");
                             int[] Nums = { -1, 0 }; //{ 2, 7, 11, 15 }
                      int target_sum = -1;
                             targetSum(Nums, target_sum);
                             Console.WriteLine();
           
            

                             //Question 7:

                             Console.WriteLine("Question 7:");
                             string allowed = "ab";
                             string[] words = { "ad", "bd", "aaab", "baa", "badab" };
                             int count = CountConsistentStrings(allowed, words);
                             Console.WriteLine("Number of Consistent strings are : {0}", count);

            
            
                             //Question 8:
                             Console.WriteLine("Question 8");
                             int[] num1 = { 12, 28, 46, 32, 50 };
                             int[] num2 = { 50, 12, 32, 46, 28 };
                             int[] indexes = AnagramMappings(num1, num2);
                             Console.WriteLine("Mapping of the elements are");
                             for (int i = 0; i < indexes.Length; i++)
                             {
                                 Console.Write(indexes[i] + "\t");
                             }
                             Console.WriteLine();
                             Console.WriteLine();
             
             */
                             //Question 9:
                             Console.WriteLine("Question 9");
                             int[] arr9 = { 4, -1, 2, 1 };
                             int Ms = MaximumSum(arr9);
                             Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
                             Console.WriteLine();
            
                      //Question 10:
                      Console.WriteLine("Question 10");
                             int[] arr10 = { 2, 3, 1, 2, 4, 3 };
                             int target_subarray_sum = 7;
                             int minLen = minSubArrayLen(target_subarray_sum, arr10);
                             Console.WriteLine("Minimum length subarray with given sum is {0}", minLen);
                             Console.WriteLine();
                      

        }


        /*
        Question 1:

        There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.
        You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i and i + 1  for all (0 <= i < n). Return the highest altitude of a point.
        Example 1:
        Input: gain = [-5,1,5,0,-7]
        Output: 1
        Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.

        Explanations: unsing the the input  we try to create another array called finalArray and iterate through to capture the value for finalArray and write a final condition if its grater than the maxvalue
        and we return the maxvalue

        */

        public static int LargestAltitude(int[] gain)
        {
            int[] finalArray = new int[gain.Length + 1];
            finalArray[0] = 0;
            int maxVal = 0;
            try
            {
                for (int i = 1; i < finalArray.Length; i++)
                {
                    finalArray[i] = finalArray[i - 1] + gain[i - 1];
                   // Console.WriteLine("nEW VAL : " + finalArray[i]);
                    if (finalArray[i] > maxVal)
                    {
                        maxVal = finalArray[i];
                    }
                }
               

                return maxVal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        
        Question 2:

        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search

        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2

        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1

        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4

        Explaination: using simple for loops to iterate through the indexes to capture the position of the target value if not add the value

        */

        public static int SearchInsert(int[] nums, int target)
        {
            int count = nums.Length;
            bool target_exists = false;
            try
            {
               
                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i].Equals(target))
                    {
                        target_exists = true;
                    }
                }

                if (target_exists == false)
                {
                    count = nums.Length + 1;
                }

                int[] sortedNums = new int[count];

                if (count > nums.Length)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (i < nums.Length)
                        {
                            sortedNums[i] = nums[i];
                        }
                        else
                        {
                            sortedNums[count - 1] = target;
                        }
                    }
                }
                else
                {
                    sortedNums = nums;
                }

                Array.Sort(sortedNums);
                return Array.IndexOf(sortedNums, target);
            }
            catch (Exception)
            {
                throw;


            }



        }

        /*
         
        Question 3
       
        Given an array words of strings made only from lowercase letters, return a list of all characters that show up in all strings in words (including duplicates).  For example, if a character occurs 3 times in all strings but not 4 times, you need to include that character three times in the final answer.
        You may return the answer in any order.
        Example 1:
        Input: ["bella","labell","roller"]

        b,e,l,l,a
        ["bella","label","roller"]
            array [1,2]
            [1,2,3]
        1,1,2,2
        Output: ["e","l","l"]
        Example 2:
        Input: ["cool","lock","cook"]
        Output: ["c","o"]

        Explanation : first for loop is to find the word length of the first element of the array. created a static function LetterCount to count the letters occurences the next for loop is to go through 
        the remaining elements in the array for the word check
        */



        public static List<string> CommonChars(string[] words)
        {
            try
            {

                List<string> commonwords = new List<string>();
                //write your code here.

                int count = 0;

                char[] stringToCheck = new char[] { };
                char[] wordCheck = new char[] { };


                stringToCheck = words[0].ToCharArray();

                for (int i = 0; i < stringToCheck.Length; i++)
                {
                    int lcount = 0;
                    int existCount = 1;
                    List<int> letterCount = new List<int> { };
                    lcount = LetterCount(stringToCheck[i].ToString(), stringToCheck);
                    letterCount.Add(lcount);
                    // wordCheck_list.Clear();

                    for (int j = 1; j < words.Count(); j++)
                    {
                        char[] wordCheckA = words[j].ToCharArray();



                        if (words[j].Contains(stringToCheck[i]))
                        {
                            count = LetterCount(stringToCheck[i].ToString(), wordCheckA);
                            letterCount.Add(count);
                            existCount++;
                        }
                    }
                    if (existCount == words.Count() && !commonwords.Contains(stringToCheck[i].ToString()))
                    {
                        letterCount.Sort();
                        for (int k = 0; k < letterCount[0]; k++)
                        {
                            commonwords.Add(stringToCheck[i].ToString());
                        }
                    }
                }


                return commonwords;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*
                Question 4:

                Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.

                Example 1:
                Input: arr = [1,2,2,1,1,3]
                Output: true
                Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

                Example 2:
                Input: arr = [1,2]
                Output: false

        Explanation : its a straight forward code using hashset and lists to find duplicates

                 */

        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                //write your code here.

                bool dupes = true;
                var myhash = new HashSet<int>();
                var mylist = new List<int>();
                mylist = arr.OfType<int>().ToList();
                var duplicates = mylist.Where(item => !myhash.Add(item)).Distinct().ToList();
                if (duplicates.Count >= 1)
                {

                    dupes = false;
                }

                return dupes;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        
        Question 5:

        You are given an array items, where each items[i] = [type, color, name]  describes the type, color, and name of the ith item. You are also given a rule represented by two strings, ruleKey and ruleValue.
        The ith item is said to match the rule if one of the following is true:
        •	ruleKey == "type" and ruleValue == type.
        •	ruleKey == "color" and ruleValue == color.
        •	ruleKey == "name" and ruleValue == name.

        Return the number of items that match the given rule.

        Example 1:
        Input:  items = [["phone","blue","pixel"],["computer","silver","lenovo"],["phone","gold","iphone"]],  ruleKey = "color",  ruleValue = "silver".
        Output: 1
        Explanation: There is only one item matching the given rule, which is ["computer","silver","lenovo"].

        Example 2:
        Input: items = [["phone","blue","pixel"],["computer","silver","phone"],["phone","gold","iphone"]], ruleKey = "type",  ruleValue = "phone"
        Output: 2
        Explanation: There are only two items matching the given rule, which are ["phone","blue","pixel"]  and ["phone","gold","iphone"]. 

        Note that the item ["computer","silver","phone"] does not match.

        Explaination : created datadictionary and assigned positions of each rule keys looking through the list of items to find the index of the rulekey 

         */

        public static int CountMatches(List<List<string>> items, string ruleKey, string ruleValue)
        {

            try
            {
                //write your code here.
                Dictionary<string, string> pos_dict = new Dictionary<string, string>();
               
                int position = 0;
                int type_count = 0;
                int items_count = 0;
                int name_count = 0;

                pos_dict.Add(ruleKey, ruleValue);

                if (ruleKey == "type")
                {

                    position = 0;
                }
                if (ruleKey == "color")
                {
                    position = 1;
                }
                if (ruleKey == "name")
                {
                    position = 2;
                }

                for (int i = 0; i < items.Count; i++)
                {

                    if (position == 0)
                    {

                        if (items[i][0].Contains(ruleValue))
                        {
                            type_count++;

                        }

                    }


                    if (position == 1)
                    {

                        if (items[i][1].Contains(ruleValue))
                        {
                            items_count++;

                        }

                    }

                    if (position == 3)
                    {

                        if (items[i][2].Contains(ruleValue))
                        {
                            name_count++;

                        }

                    }



                }





                return (type_count + items_count + name_count);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        
        Question 6:
        
        Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers. Length.
        You may not use the same element twice, there will be only one solution for a given array.

        Note: Solve it in O(n) and O(1) space complexity.

        Hint: Use the fact that array is sorted in ascending order and there exists only one solution.
        Typically, in these cases it’s useful to use pointers tracking the two ends of the array.

        Example 1:
        Input: numbers = [2,7,11,15], target = 9 sume = i+sie()-1=1
        Output: [1,2]
        Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        Example 2:
        Input: numbers = [2,3,4], target = 6
        Output: [1,3]

        Example 3:
        Input: numbers = [-1,0], target = -1
        Output: [1,2]

        Explaination: iterating through both sides , from left and from right to find if the target value matches the sum of the vaues inside the list 

        */

        public static void targetSum(int[] nums, int target)
        {
            try
            {
                Array.Sort(nums);
                int left = 0,
                    right = nums.Length - 1;
                while (left < right)
                {
                    if (target == (nums[left] + nums[right]))

                        
                        Console.WriteLine((left+1) +"," + (right+1));
                    
                    if ((nums[left] + nums[right]) < target)
                        left++;
                    else
                        right--;
                }
               
            }

            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 7:

        You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if every character in words[i] appears in the string allowed.
        Return the number of consistent strings in the array words.

        Note: The algorithm should have run time complexity of O(n).
        Hint: Use Dictionaries. 

        Example 1:
        Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
              12 , 14,24,112{dedupe},112{dedupe},124
        Output: 2
        Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'. string “bd” is not consistent since ‘d’ is not in string allowed.

        Example 2:
        Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
        Output: 7
        Explanation: All strings are consistent.

        Explaination : Created to data dictionaries to try to compare but unfortunatily i ran out of time hence submitting incomplete

        */

       


        public static int CountConsistentStrings(string allowed, string[] words)
        {
            try
            {

                
                
                char[] characters = allowed.ToCharArray();
                
                
                Dictionary<int, List<char>> allowedDictionary = new Dictionary<int, List<char>>();
                allowedDictionary.Add(0, characters.ToList());


                List<string> str2 = new List<string>();
                str2.Add("a");
                str2.Add("d");

                Dictionary<int, List<char>> wordsDictionary = new Dictionary<int, List<char>>();
                

                for (int i = 0; i < words.Length; i++) {

                    char[] word_split = words[i].ToCharArray();

                    wordsDictionary.Add(i, word_split.ToList());

                   
                }

                


                Console.WriteLine(wordsDictionary);

            
                //write your code here.
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        Question 8:

        You are given two integer arrays nums1 and nums2 where nums2 is an anagram of nums1. Both arrays may contain duplicates.

        Return an index mapping array mapping from nums1 to nums2 where mapping[i] = j indicates that  the ith element in nums1 appears in nums2 at index j. If there are multiple answers, return any of them.
        An array a is an anagram of array b if b is made by randomizing the order of the elements in a.

 
        Example 1:
        Input: nums1 = [12,28,46,32,50], nums2 = [50,12,32,46,28]
        Output: [1,4,3,2,0]
        
        Explanation: As mapping[0] is at 1 because the 0th element of nums1 appears at nums2[1], and mapping[1] = 4 because the 1st element of nums1 appears at nums2[4], and so on.

        */

        public static int[] AnagramMappings(int[] nums1, int[] nums2)
        {
            try
            {
                //write your code here

                
                 int[] ans = new int [nums1.Length];
                for (int i = 0; i < nums1.Length; i++) {

                    ans[i] = Array.IndexOf(nums2, nums1[i]);
                
                }
                

                return ans;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        
        Question 9:

        Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

        Note: Time Complexity should be O(n).
        Hint: Keep track of maximum sum as you move forward.
        Example 1:
        Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.
        Example 2:
        Input: nums = [1]
        Output: 1

        Explanation
         * incl keeps track of max sum till i-1 including it and excl keeps track of max sum till i-1 excluding it, i.e. incl till i-2.
          Since it has negative numbers too, we start incl withmax(0, nums[0]) and excl at 0 because no elements have been added till now.
          At each position, we maximize the incl and make excl previous incl.

        */

        public static int MaximumSum(int[] arr)
        {
            try
            {
                //write your code here.
                if (arr.Length == 0) return 0;
                int incl = Math.Max(0, arr[0]), excl = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    int temp = incl;
                    incl = Math.Max(excl + arr[i], incl);
                    excl = temp;
                }
                return incl;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 10:

        Given an array of positive integers nums and a positive integer target, return the minimal length of a contiguous subarray [nums[l], nums[l+1], ..., nums[r-1], nums[r]] of which the sum is greater than or equal to target. If there is no such subarray, return 0 instead.


        Note: Try to solve it in O(n) time.

        Hint: Try to create a window and track the sum you have in the window.

        Example 1:
        Input: target = 7, nums = [2,3,1,2,4,3]
        Output: 2
        Explanation: The subarray [4,3] has the minimal length under the problem constraint.


        Example 2:
        Input: target = 4, nums = [1,4,4]
        Output: 1

       Explainiation : Incomplete {Ran out of time}


        */

        public static int minSubArrayLen(int target_subarray_sum, int[] arr10)
        {
            try
            {
                //write your code here.
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private static int LetterCount(string letter, char[] inputString)
        {
            int count = 0;
            for (int j = 0; j < inputString.Length; j++)
            {
                if (inputString[j].ToString() == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
