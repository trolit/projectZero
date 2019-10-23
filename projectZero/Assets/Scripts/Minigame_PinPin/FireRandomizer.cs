using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class FireRandomizer : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _fireParticleSystem;

        private void Start()
        {
            var mainModule = _fireParticleSystem.main;

            var min = new Color32(RandomizeValue(), RandomizeValue(), RandomizeValue(), 255);
            var max = new Color32(RandomizeValue(), RandomizeValue(), RandomizeValue(), 255);

            mainModule.startColor = new ParticleSystem.MinMaxGradient(min, max);
        }

        private static byte RandomizeValue()
        {
            return (byte) Random.Range(0f, 255f);
        }
    }
}
