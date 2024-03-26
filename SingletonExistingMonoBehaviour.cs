using System;
using UnityEngine;

namespace Utility.Singleton
{
    public abstract class SingletonExistingMonoBehaviour<T> : MonoBehaviour where T : SingletonExistingMonoBehaviour<T>
    {
        public static T _ => _instance;
        private static T _instance;

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
            }
            else if (!Equals(this, _instance))
            {
                Destroy(gameObject);
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