using UnityEngine;

namespace Assets.Scripts.Puzzle
{
    public class Verify_3X3 : MonoBehaviour
    {
        protected static bool Pad2Result;

        protected static bool Pad3Result;

        protected static bool Pad4Result;

        protected static bool Pad5Result;

        protected static bool Pad6Result;

        protected static bool Pad7Result;

        protected static bool Pad8Result;

        protected static bool Pad9Result;

        void Update()
        {
            //Debug.Log("Pad9 => " + Pad9Result);

            if (Pad2Result && Pad3Result && Pad4Result
                && Pad5Result && Pad6Result && Pad7Result
                && Pad8Result && Pad9Result)
            {
                Debug.Log("LOL - wygrana");
                // You won

                // Turn off Update()
                enabled = false;
            }
        }
    }
}
