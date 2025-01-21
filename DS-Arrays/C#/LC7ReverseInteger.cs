public class Solution {
    public int Reverse(int x) {
            int rev = 0;
            int digits = 0;

            while (x != 0)
            {
                x = Math.DivRem(x, 10, out int rem);
                if(digits++ == 9)
                {
                    int max = int.MaxValue / 10;
                    if (rev > max || (rev == max && rem > 7)) return 0;
                    int min = int.MinValue / 10;
                    if (rev < min || (rev == min && rem < -8)) return 0;
                }

                rev = rev * 10 + rem;
            }
            return rev;
    }
}