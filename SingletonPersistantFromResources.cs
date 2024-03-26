using System;
using UnityEngine;

namespace Utility.Singleton
{
    public class SingletonPersistantFromResources<T> : MonoBehaviour where T : SingletonPersistantFromResources<T>
    {
        private static T _instance;
        public static T _
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Instantiate(Resources.Load<T>("Prefabs/Singletons/Prefab_" + typeof(T).Name));
                    DontDestroyOnLoad(_instance);
                }
                return _instance;
            }
        }

        protected virtual void OnDestroy()
        {
            if (Equals(this, _instance))
            {
                _instance = null;
            }
        }
    }
}