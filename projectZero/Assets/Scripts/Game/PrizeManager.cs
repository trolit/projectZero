using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class PrizeManager : MonoBehaviour
    {
        [SerializeField]
        protected List<GameObject> NotUnlockedObjects;

        [SerializeField]
        protected List<GameObject> UnlockedObjects;

        protected static int MedalsAmount;

        [SerializeField]
        protected bool IsUnderTest = false;

        private void Start()
        {
            MedalsAmount = PlayerPrefs.GetInt("medalsUnlocked");
        }

        // mode meaning
        // TRUE = activates passed objects
        // FALSE = deactivates passed objects
        protected void MarkListOfObjects(List<GameObject> objects, bool mode)
        {
            foreach (var obj in objects)
            {
                obj.SetActive(mode);
            }
        }
    }
}
