﻿using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Scan")]
public class ScanDecision : Decision
{

    public override bool Decide(StateController controller)
    {
		bool noEnemyInSight = Scan(controller);
		return noEnemyInSight;
    }

	private bool Scan(StateController controller)
	{
		controller.navMeshAgent.isStopped = true;
		controller.transform.Rotate(0, 100 * Time.deltaTime, 0);
		return controller.CheckIfCountDownElapsed(10);
	}

}