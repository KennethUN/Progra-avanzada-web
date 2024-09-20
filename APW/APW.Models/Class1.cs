namespace APW.Models;

    public class Class1
    {
        public List<int> MyProperty{ get; set; }
        public void Test()
        {
            MyProperty.Where(x => x >5).Select(x => x).ToList();
        }




    }

