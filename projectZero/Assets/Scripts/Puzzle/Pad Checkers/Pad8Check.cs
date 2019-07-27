using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad8Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock08")
            {
                Pad8Result = true;
            }
            else
            {
                Pad8Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad8Result = false;
        }
    }
}
