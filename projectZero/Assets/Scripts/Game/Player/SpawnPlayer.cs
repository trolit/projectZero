using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class SpawnPlayer : MonoBehaviour
    {
        public GameObject Cactus;

        public GameObject Robot;

        public GameObject Slime;

        public PlayerFollow Camera;

        void Start()
        {
            var pickedModel = PlayerPrefs.GetInt("model");

            if (pickedModel == 1) // Cactus
            {
                Cactus.SetActive(true);

                MovementScript movement = Cactus.AddComponent<MovementScript>();
                movement.Speed = 40f;

                // Instantiate at desired position and rotation(z).
                Instantiate(Cactus, new Vector3(-300, 255, -3278), Quaternion.identity);

                Camera.PlayerTransform = Cactus.transform;
            }
            else if (pickedModel == 2) // Slime
            {
                Slime.SetActive(true);

                MovementScript movement = Slime.AddComponent<MovementScript>();
                movement.Speed = 70f;

                Instantiate(Slime, new Vector3(-300, 255, -3278), Quaternion.identity);

                Camera.PlayerTransform = Slime.transform;
            }
            else if (pickedModel == 3) // Robot
            {
                Robot.SetActive(true);

                MovementScript movement = Robot.AddComponent<MovementScript>();
                movement.Speed = 40f;

                Instantiate(Robot, new Vector3(-300, 255, -3278), Quaternion.identity);

                Camera.PlayerTransform = Robot.transform;
            }
        }
    }
}
