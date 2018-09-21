using System.Collections.Generic;
using UnityEngine;

public abstract class Action : ScriptableObject
{
	public List<Decision> ActIfConditions;
	public abstract void Act(StateController controller);
	
	public bool ShouldAct
	{
		get
		{
			var returnValue = true;
			if (ActIfConditions.Count < 1)
			{
				return returnValue;
			}
			else
			{
				foreach (Decision decision in ActIfConditions)
				{
					if (decision == false)
						returnValue = false;
				}
				return returnValue;
			}
		}
	}
}