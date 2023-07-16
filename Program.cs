namespace LabExam
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Book 1 Information");
            TestData td = new TestData("BASIC","Kumar Mehra");
            Console.WriteLine(" Title = "+td.Title+", Author = "+td.Author);
            Console.WriteLine("Book 2 Information");
            TestData t = new TestData("C+", "Sainath Sharma");
            Console.WriteLine(" Title = " + t.Title + ", Author = " + t.Author);
            Console.WriteLine("Above is the Book Information");
        }
    }
    public class TestData
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public TestData(string title, string author)
        {
            this.Title = title; 
            this.Author = author;
        }
    }
    
}