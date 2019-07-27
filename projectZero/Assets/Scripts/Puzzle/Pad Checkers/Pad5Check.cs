using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad5Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock05")
            {
                Pad5Result = true;
            }
            else
            {
                Pad5Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad5Result = false;
        }
    }
}
