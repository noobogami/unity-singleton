using UnityEngine;

namespace Utility.Singleton
{
    public class SingletonFromResources<T> : MonoBehaviour where T : SingletonFromResources<T>
    {
        private static T _instance;
        public static T _ => _instance ??= Instantiate(Resources.Load<T>("Prefabs/Singletons/Prefab_" + typeof(T).Name));
        
        protected virtual void OnDestroy()
        {
            if (Equals(this, _instance))
            {
                _instance = null;
            }
        }
    }
}