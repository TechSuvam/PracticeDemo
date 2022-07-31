namespace PracticeDemo
{
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
}
