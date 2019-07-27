using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad9Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock09")
            {
                Pad9Result = true;
            }
            else
            {
                Pad9Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad9Result = false;
        }
    }
}
