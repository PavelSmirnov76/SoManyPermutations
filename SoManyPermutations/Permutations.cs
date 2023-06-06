using System.Numerics;

namespace SoManyPermutations
{
    public class Permutations
    {
        public static List<string> SinglePermutations(string s)
        {
            return Permutation(s.ToCharArray(), 0, s.Length - 1, new HashSet<string>()).ToList();
        }

        static int Fact(int n)
        {
            int r = 1;
            for (int i = 2; i <= n; ++i)
            {
                r *= i;
            }
            return r;
        }

        private static HashSet<string> Permutation(char[] s, int i, int n, HashSet<string> permutations)
        {
            if (i == n)
            {
                permutations.Add(new string(s));
            }
            else
            {
                char temp;

                for (int j = i; j <= n; j++)
                {
                    temp = s[i];
                    s[i] = s[j];
                    s[j] = temp;

                    Permutation(s, i + 1, n, permutations);

                    temp = s[i];
                    s[i] = s[j];
                    s[j] = temp;
                }
            }

            return permutations;
        }
    }
}