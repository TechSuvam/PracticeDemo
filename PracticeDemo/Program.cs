namespace PracticeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string singleton = Singleton.SingletonProp.GetType();
            string staticType = StaticClass.GetType();
        }
    }
}
