using System;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS 2 ANIMATIONS 

    // Warning: Animator needs to contain Walk parameter
    // of type Integer where value 0 means Idle and value
    // 1 means Walk

    [Obsolete("Redundant class after refactorization, use MoveRandomlyAdvanced instead to perform the same actions.")]
    public sealed class MoveRandomly2 : MoveRandomlyAdvanced
    {
        // Use this for initialization
        private void Start()
        {
            base.Start();
        }    
    }

    // Class is redundant after refactorization because
    // MoveRandomlyAdvanced performs everything that
    // did class MoveRandomly2 but due to its usage
    // on different minigames its still here :)
}

