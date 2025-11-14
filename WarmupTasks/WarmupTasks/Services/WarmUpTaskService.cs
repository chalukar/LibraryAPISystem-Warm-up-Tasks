

namespace WarmupTasks.Services
{
    public class WarmUpTaskService
    {
        // 1. Check if a Book ID is a power of 2
        public bool IsPowerOfTwo(int id)
        {

            if (id <= 0) return false;
            return (id & (id - 1)) == 0;
        }

        // 2. Reverse a Book Title
        // (Example: "Moby Dick" → "kciD yboM")
        public string ReversBookTitle(string bookTitle) { 
            if(string.IsNullOrEmpty(bookTitle))
            {
                return bookTitle;
            }
            else
            {
                char[] bktl = bookTitle.ToCharArray();
                Array.Reverse(bktl);
                return new string(bktl);
            }
        }

        //3. Generate Book Title Replicas
        // (Example: ("Read", 4) → "ReadReadReadRead")
        public string RepeatBookTitle(string bookTitle,int count)
        {
            if (count <= 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Concat(Enumerable.Repeat(bookTitle, count));
            }
        }

        // 4. List Odd-Numbered Book IDs between 0 and 100
        public void ListOddNumbersId(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
