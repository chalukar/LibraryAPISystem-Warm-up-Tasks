using WarmupTasks.Services;

namespace WarmUpTasks.Tests
{
    public class WarmUpTaskServiceTests
    {
        private readonly WarmUpTaskService _warmUpTaskService;

        public WarmUpTaskServiceTests()
        {
            _warmUpTaskService = new WarmUpTaskService();
        }
        // 1. Check if a Book ID is a Power of Two
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(8, true)]
        [InlineData(0, false)]
        [InlineData(-2, false)]
        [InlineData(-16, false)]
        [InlineData(16, true)]
        public void IsPowerOfTwo_ShouldReturnExpected(int number, bool expected)
        {
            var result = _warmUpTaskService.IsPowerOfTwo(number);
            Assert.Equal(expected, result);
        }


        // 2. Reverse a Book Title
        [Theory]
        [InlineData("Microservice in.NET Core", "eroC TEN.ni ecivresorciM")]
        [InlineData("Moby Dick" , "kciD yboM")]
        [InlineData("ABC", "CBA")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void ReverseTitle_ShouldReverseString(string input, string expected)
        {
            var result = _warmUpTaskService.ReversBookTitle(input);
            Assert.Equal(expected, result);
        }


        //3. Generate Book Title Replicas
        [Theory]
        [InlineData("Read", 4, "ReadReadReadRead")]
        [InlineData("C", 5, "CCCCC")]
        [InlineData("Book", 0, "")]
        [InlineData(".NET", -1, "")]
        public void RepeatTitle_ShouldRepeatCorrectly(string title, int count, string expected)
        {
            var result = _warmUpTaskService.RepeatBookTitle(title, count);
            Assert.Equal(expected, result);
        }

        // 4. List Odd-Numbered Book IDs between 0 and 100
        [Fact]
        public void PrintOddNumbers_ShouldPrintAllOddNumbers()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            _warmUpTaskService.ListOddNumbersId(0, 16);

            var output = sw.ToString().Trim();

            Assert.Equal("1 3 5 7 9 11 13 15", output);
        }
    }
}
