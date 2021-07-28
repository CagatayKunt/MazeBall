using UnityEngine;

namespace GameFolders.Scripts
{
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T Instance { get; private set; }
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = (T)this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }
            OnAwake();
        }

        protected virtual void OnAwake()
        {
            
        }
    }
}
