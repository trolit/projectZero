using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad4Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock04")
            {
                Pad4Result = true;
            }
            else
            {
                Pad4Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad4Result = false;
        }
    }
}
