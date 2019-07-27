using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad7Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock07")
            {
                Pad7Result = true;
            }
            else
            {
                Pad7Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad7Result = false;
        }
    }
}
