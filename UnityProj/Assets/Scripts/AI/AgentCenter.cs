using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AQAI
{

	public class AgentCenter : MonoBehaviour
	{
		public int Integrity;

		public float VelocityTarget = 10;

		public void AddActorOfInterest(int actorId, Transform actorPoint)
		{
			List<int> aoeKeys = new List<int>();

			foreach (KeyValuePair<int, Transform> aoi in ActorsOfInterest)
			{
				aoeKeys.Add(aoi.Key);
			}

			if (aoeKeys.Contains(actorId))
				return;

			ActorsOfInterest.Add(new KeyValuePair<int, Transform>(actorId, actorPoint));
		}

		private Vector3? ActiveDestination;
		private Vector3? LastDestination;

		private List<KeyValuePair<int, Transform>> ActorsOfInterest = new List<KeyValuePair<int, Transform>>();

		private NavMeshAgent _navAgent;

		public float GetAgentVelocity
		{
			get
			{
				return _navAgent.velocity.magnitude;
			}
		}

		public bool HasDestination
		{
			get
			{
				return ActiveDestination != null;
			}
		}

		private void Awake()
		{
			_navAgent = GetComponent<NavMeshAgent>();
			//_navAgent.velo
		}

		public void SetDestination(Vector3 destination, bool move = true)
		{
			if (HasDestination)
			{
				LastDestination = ActiveDestination;
			}

			ActiveDestination = destination;

			_navAgent.SetDestination(destination);
		}

		public void CancelDestination()
		{
			ActiveDestination = null;
		}
	}
}
