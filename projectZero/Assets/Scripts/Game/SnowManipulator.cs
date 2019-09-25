using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class SnowManipulator : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _snowParticleSystem;

        [SerializeField]
        private float _timeUntilNewManipulation = 5f;

        [SerializeField]
        private float _minSpeed = 1f;

        [SerializeField]
        private float _maxSpeed = 3f;

        [SerializeField]
        private float _minEmissionRate = 10f;

        [SerializeField]
        private float _maxEmissionRate = 100f;

        [SerializeField]
        private bool _independentRandomization = false;

        private bool _inCoRoutine = false;

        private ParticleSystem.MainModule _mainModule;

        private ParticleSystem.EmissionModule _emissionModule;

        // Start is called before the first frame update
        void Start()
        {
            if (_snowParticleSystem == null)
            {
                Debug.Log("No snow particle assigned! Make sure that property Snow Particle System is not null");
                enabled = false;
            }

            _mainModule = _snowParticleSystem.main;

            _emissionModule = _snowParticleSystem.emission;
        }

        // Update is called once per frame
        void Update()
        {
            if (!_inCoRoutine)
                StartCoroutine(ManipulateSnow());
        }

        private IEnumerator ManipulateSnow()
        {
            yield return new WaitForSeconds(_timeUntilNewManipulation);

            if (_independentRandomization)
            {
                IndependentRandomization();
            }
            else
            {
                DependentRandomization();
            }

        }

        private float RandomizeValue(float min, float max)
        {
            return Random.Range(min, max);
        }

        private void DependentRandomization()
        {
            _mainModule.startSpeed = 
                RandomizeValue(_minSpeed, _maxSpeed);

            _emissionModule.rateOverTime = 
                RandomizeValue(_minEmissionRate, _maxEmissionRate);
        }

        private void IndependentRandomization()
        {

        }
    }
}
