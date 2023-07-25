/* An array arr a mountain if the following properties hold:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i] 
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given a mountain array arr, return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

You must solve it in O(log(arr.length)) time complexity. */

public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int ans = 0;
        int start = 0;
        int end = arr.Length-1;
        while(start <= end) {
            int mid = (start+end)/2;
            if(mid == 0) {
                start = mid + 1;
            }
            else if(mid == arr.Length - 1) {
                end = mid - 1;
            }
            else {
                if(arr[mid-1] < arr[mid] && arr[mid] > arr[mid+1]) {
                    ans = mid;
                    break;
                }
                else if(arr[mid-1] < arr[mid]) {
                    start = mid + 1;
                }
                else if(arr[mid-1] > arr[mid]) {
                    end =mid - 1;   
                }
            }
        }
        return ans;
    }
}