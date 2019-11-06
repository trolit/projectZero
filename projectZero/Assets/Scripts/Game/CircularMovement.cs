using UnityEngine;

namespace Assets.Scripts.Game
{
    // Big thanks to Stuart Spence for idea

    public class CircularMovement : MonoBehaviour
    {
        private float _timeCounter = 0f;

        [SerializeField]
        private float _speed;

        [SerializeField]
        private float _radius;

        [SerializeField]
        private float _timeAdder = 0f;

        private void Start()
        {
            _timeCounter += _timeAdder;
        }

        private void Update()
        {
            _timeCounter += Time.deltaTime * _speed;

            var x = Mathf.Cos(_timeCounter) * _radius;
            var y = Mathf.Sin(_timeCounter) * _radius;

            gameObject.transform.localPosition = new Vector3(x, y, 0);
        }
    }
}
