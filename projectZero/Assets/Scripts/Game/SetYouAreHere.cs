using System;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class SetYouAreHere : MonoBehaviour
    {
        public static SetYouAreHere instance = null;

        [SerializeField]
        private GameObject _youAreHereGameObject;

        [NonSerialized]
        public GameObject Character;

        private Transform _characterTransform;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);

                Debug.LogWarning($"Since there is already one instance of SetYouAreHere," +
                                 $" instance on {gameObject.name} was destroyed.");
            }
        }

        public void UpdateCharacterLocation()
        {
            _characterTransform = Character.transform;

            _youAreHereGameObject.transform.localPosition = 
                new Vector3(_characterTransform.position.x + 470,
                    _youAreHereGameObject.transform.position.y,
                    _characterTransform.position.z + 350);
        }
    }
}
