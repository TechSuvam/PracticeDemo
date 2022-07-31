namespace PracticeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            var singleton = Singleton.SingletonProp.GetType();
            var staticType= StaticClass.GetType();
        }
    }

    public sealed class Singleton
    {
        private static Singleton _singletonInstance = null;
        private Singleton()
        {

        }

        public static Singleton SingletonProp
        {
            get
            {
                if(_singletonInstance == null)
                {
                    _singletonInstance = new Singleton();
                }
                return _singletonInstance;
            }
        }

        public string GetType()
        {
            return "Singleton Class";
        }
    }

    public static class StaticClass
    {
        public static string GetType()
        {
            return "Static Class";
        }
    }
}
