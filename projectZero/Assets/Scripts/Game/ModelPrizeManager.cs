using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class ModelPrizeManager : PrizeManager
    {
        [SerializeField]
        private RawImage _image;

        private void Start()
        {
            if (MedalsAmount >= MedalsRequired || IsUnderTest == true)
            {
                _image.color = new Color(255f, 255f, 255f);

                MarkListOfObjects(NotUnlockedObjects, false);

                MarkListOfObjects(UnlockedObjects, true);
            }
            else
            {
                MarkListOfObjects(NotUnlockedObjects, true);

                MarkListOfObjects(UnlockedObjects, false);
            }
        }
    }
}
