namespace Utility.Singleton
{
    public abstract class SingletonSimple<T> where T : class, new()
    {
        public static T _ => _instance ??= new T();
        private static T _instance;
    }
}