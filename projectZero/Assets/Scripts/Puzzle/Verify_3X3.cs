using UnityEngine;

namespace Assets.Scripts.Puzzle
{
    public class Verify_3X3 : MonoBehaviour
    {
        protected bool Pad2Result;

        protected bool Pad3Result;

        protected bool Pad4Result;

        protected bool Pad5Result;

        protected bool Pad6Result;

        protected bool Pad7Result;

        protected bool Pad8Result;

        protected bool Pad9Result;

        void Start()
        {
            Pad2Result = false;
            Pad3Result = false;
            Pad4Result = false;
            Pad5Result = false;
            Pad6Result = false;
            Pad7Result = false;
            Pad8Result = false;
            Pad9Result = false;
        }

        void FixedUpdate()
        {
            if (Pad2Result && Pad3Result && Pad4Result
                && Pad5Result && Pad6Result && Pad7Result
                && Pad8Result && Pad9Result)
            {
                // You won
            }
        }
    }
}
