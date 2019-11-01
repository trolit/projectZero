using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class Minimap : MonoBehaviour
    {
        [SerializeField]
        private List<Transform> _characterList;

        private Transform _player;

        private void Start()
        {
            var id = PlayerPrefs.GetInt("model");

            _player = _characterList[id - 1];

            Debug.Log("Minimap set on => " + _player.gameObject.name);
        }

        private void LateUpdate()
        {
            Vector3 newPosition = _player.position;

            newPosition.y = transform.position.y;

            transform.position = newPosition;
        }
    }
}
