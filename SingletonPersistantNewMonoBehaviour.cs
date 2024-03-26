using System;

namespace Utility.Singleton
{
    public abstract class SingletonPersistantNewMonoBehaviour<T> : SingletonNewMonoBehaviour<T> where T : SingletonNewMonoBehaviour<T>
    {
        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}