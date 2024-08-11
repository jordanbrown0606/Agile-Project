using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BetterFSM
{
    public class InitState : StateBase
    {
        public override StateType GetStateType { get { return StateType.Init; } }

        public override NavMeshAgent GetAgent { get { return _myAgent.GetNavAgent; } }

        public override StateType OnStateUpdate()
        {
            if (this.GetComponent<Enemy>().Health <= 0)
            {
                return StateType.Death;
            }
            else
            {
                // Character is set up.
                // Allow it to go to actual game mode
                return StateType.Patrol;
            }
        }
    }
}