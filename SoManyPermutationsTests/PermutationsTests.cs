namespace SoManyPermutationsTests
{
    public class PermutationsTests
    {
        [Fact]
        public void SinglePermutations_a_a()
        {
            var str = "a";
            var expected = new List<string> 
            { 
                "a" 
            };

            var actual = Permutations.SinglePermutations(str);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SinglePermutations_ab_ab_ba()
        {
            var str = "ab";
            var expected = new List<string>
            {
                "ab" , "ba" 
            };

            var actual = Permutations.SinglePermutations(str);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SinglePermutations_abc_abc_abc_acb_bac_bca_cab_cba()
        {
            var str = "abc";
            var expected = new List<string>
            {
                "abc","acb","bac","bca","cab","cba"
            };

            var actual = Permutations.SinglePermutations(str);

            Assert.Equal(expected, actual.OrderBy(x => x).ToList());
        }


    }
}