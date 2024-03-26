using UnityEngine;

namespace Utility.Singleton
{
    public abstract class SingletonNewMonoBehaviour<T> : MonoBehaviour where T : SingletonNewMonoBehaviour<T>
    {
        public static T _ => _instance ??= new GameObject(typeof(T).Name).AddComponent<T>();
        private static T _instance;
    }
}