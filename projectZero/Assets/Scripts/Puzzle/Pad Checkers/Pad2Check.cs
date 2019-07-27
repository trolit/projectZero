using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad2Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock02")
            {
                Pad2Result = true;
            }
            else
            {
                Pad2Result = false;
            }
        }
    }
}
