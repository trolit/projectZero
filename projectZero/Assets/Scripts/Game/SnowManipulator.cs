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

        // Starting speed
        [Header("Speed range")]

        [SerializeField]
        private float _minSpeed = 1f;

        [SerializeField]
        private float _maxSpeed = 3f;

        [Header("Emission range")]

        // Emission rate
        [SerializeField]
        private float _minEmissionRate = 10f;

        [SerializeField]
        private float _maxEmissionRate = 100f;

        [SerializeField]
        [Tooltip("Set this on true if you want independent randomization for particle parameters.")]
        private bool _independentRandomization = false;

        private bool _inCoRoutine = false;

        // Holds reference to ParticleSystem Main Module 
        private ParticleSystem.MainModule _mainModule;

        // Holds reference to ParticleSystem Emission Module
        private ParticleSystem.EmissionModule _emissionModule;

        // Start is called before the first frame update
        private void Start()
        {
            if (_snowParticleSystem == null)
            {
                Debug.LogError("No particle assigned! Make sure that property Snow Particle System is not null");
                
                // Break editor play mode
                Debug.Break();
            }

            _mainModule = _snowParticleSystem.main;

            _emissionModule = _snowParticleSystem.emission;
        }

        // Update is called once per frame
        private void Update()
        {
            if (!_inCoRoutine)
                StartCoroutine(ManipulateSnow());
        }

        // Handles particle system manipulation
        private IEnumerator ManipulateSnow()
        {
            _inCoRoutine = true;

            yield return new WaitForSeconds(_timeUntilNewManipulation);

            if (_independentRandomization)
            {
                IndependentRandomization();
            }
            else
            {
                DependentRandomization();
            }

            _inCoRoutine = false;
        }

        private float RandomizeValue(float min, float max)
        {
            var result = Random.Range(min, max);

            return result;
        }

        private bool Randomizable()
        {
            // Returns 0 or 1 
            var result = Random.Range(0, 2);
            
            return result == 1;
        }

        // Handles dependent randomization which means
        // that every property gets randomized
        private void DependentRandomization()
        {
            _mainModule.startSpeed = 
                RandomizeValue(_minSpeed, _maxSpeed);

            _emissionModule.rateOverTime = 
                RandomizeValue(_minEmissionRate, _maxEmissionRate);
        }

        // Handles independent randomization which means
        // that  property gets randomized but ONLY WHEN
        // Randomizable() returned true
        private void IndependentRandomization()
        {
            if (Randomizable())
            {
                _mainModule.startSpeed =
                    RandomizeValue(_minSpeed, _maxSpeed);
            }

            if (Randomizable())
            {
                _emissionModule.rateOverTime =
                    RandomizeValue(_minEmissionRate, _maxEmissionRate);
            }
        }
    }
}
