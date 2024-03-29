﻿using UnityEngine;

namespace AiLogic
{
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Attack")]
    public class AttackAction : Action
    {
        public override void Act(StateController controller)
        {
            //TODO: Make it so sprite is showing in the general direction of the player

            Attack(controller);
        }

        private void Attack(StateController controller)
        {
            if ((Time.time - controller.timeSinceLastAttack) > controller.stats.attackInterval)
            {
                controller.chaseTarget.gameObject.GetComponent<EventCbSystem.PlayerLogic>().TakeDamage(controller.CalculateDamage());
                controller.timeSinceLastAttack = Time.time;
            }
        }
    }
}