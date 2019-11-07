using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class NPCCollector : MonoBehaviour
    {
        public static NPCCollector instance = null;

        public List<GameObject> NpcGameObjects;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);

                Debug.LogWarning($"Since there is already one instance of NPCCollector," +
                                 $" instance on {gameObject.name} was destroyed.");
            }

            if (NpcGameObjects == null)
            {
                Debug.LogError($"No non-playable characters assigned on {gameObject.name}");
                Debug.Break();
            }
        }
    }
}
