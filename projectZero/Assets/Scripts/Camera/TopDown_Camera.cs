﻿using UnityEngine;

namespace Assets.Scripts.Camera
{
    public class TopDown_Camera : MonoBehaviour
    {
        [SerializeField]
        private Transform _slime;

        [SerializeField]
        private Transform _robot;

        [SerializeField]
        private Transform _cactus;

        private Transform Target;

        [SerializeField]
        public float Height = 10f;

        [SerializeField]
        private float Distance = 20f;

        [SerializeField]
        private float Angle = 45f;

        [SerializeField]
        private float SmoothSpeed = 0.5f;

        private Vector3 refVelocity;  // to make camera work smooth

        // Start is called before the first frame update
        void Start()
        {
            // Load which character was picked
            int characterId = PlayerPrefs.GetInt("model");

            if (characterId == 1)
            {
                Target = _cactus;
            }
            else if (characterId == 2)
            {
                Target = _slime;
            }
            else if (characterId == 3)
            {
                Target = _robot;
            }
            else
            {
                Debug.Log("Error trying to read and set model!");
            }

            HandleCamera();
        }

        void Update()
        {
            HandleCamera();
        }

        protected virtual void HandleCamera()
        {
            if (!Target)
            {
                return;
            }

            // Build world position Vector
            Vector3 worldPosition = (Vector3.forward * -Distance) + (Vector3.up * Height);

            // Debug.DrawLine(Target.position, worldPosition, Color.red);

            // Build our rotated Vector
            Vector3 rotatedVector = Quaternion.AngleAxis(Angle, Vector3.up) * worldPosition;

            // Move our position
            Vector3 flatTargetPosition = Target.position;
            flatTargetPosition.y = 0f;

            Vector3 finalPosition = flatTargetPosition + rotatedVector;

            transform.position = Vector3.SmoothDamp
                (transform.position, finalPosition, ref refVelocity, SmoothSpeed);

            transform.rotation = Quaternion.LookRotation(-rotatedVector);
        }
    }
}
