using UnityEngine;

namespace Assets.Scripts.Puzzle.Pad_Checkers
{
    public class Pad6Check : Verify_3X3
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock06")
            {
                Pad6Result = true;
            }
            else
            {
                Pad6Result = false;
            }
        }
    }
}
