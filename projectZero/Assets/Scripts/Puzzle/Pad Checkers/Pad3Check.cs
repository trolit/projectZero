using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad3Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock03")
            {
                Pad3Result = true;
            }
            else
            {
                Pad3Result = false;
            }
        }
    }
}
