/* We are given an array asteroids of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet. */

/* Example: 
Input: asteroids = [5,10,-5]
Output: [5,10]
Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never collide. 
*/
public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        Stack<int> stack = new();
        foreach(int asteroid in asteroids)
        {
            stack.Push(asteroid);
            
            while (stack.Count > 0) 
            {
                int sum = stack.Peek() + asteroid;
                if (sum == 0) 
                {
                    stack.Pop();
                    break;                    
                }
                if (sum < 0) 
                {
                    stack.Pop();
                    if (stack.Count == 0 || stack.Peek() < 0) 
                    {
                        stack.Push(asteroid);
                        break;
                    }
                    continue;
                }
                break;
            }
        }

        return stack.Reverse().ToArray();
    }
}