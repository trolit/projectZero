using UnityEngine;

namespace Assets.Scripts.Fix
{
    public class WaterRemover : MonoBehaviour
    {
        private void Awake()
        {
            int qualityIndex = PlayerPrefs.GetInt("quality");

            // 0 => Very low quality
            // 1 => Low quality
            if (qualityIndex == 0 || qualityIndex == 1)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
