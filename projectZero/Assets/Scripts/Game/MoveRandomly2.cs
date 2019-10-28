using System;
using UnityEngine;

namespace Assets.Scripts.Game
{
    [Obsolete("Redundant class after refactorization, use MoveRandomlyAdvanced instead to perform the same actions.")]
    public sealed class MoveRandomly2 : MoveRandomlyAdvanced
    {
        private new void Start()
        {
            base.Start();

            Debug.LogError($"Object {gameObject.name} is still using obsolete class !!!");

            Debug.Break();
        } 
    }
}

