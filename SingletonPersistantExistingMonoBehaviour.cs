using UnityEngine;

namespace Utility.Singleton
{
    public abstract class SingletonPersistantExistingMonoBehaviour<T> : SingletonExistingMonoBehaviour<T> where T : SingletonExistingMonoBehaviour<T>{
        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
    }
}