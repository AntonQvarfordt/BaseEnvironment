using UnityEngine;
using UnityEngine.AI;

namespace AQAI
{

	[RequireComponent(typeof(NavMeshAgent))]
	public class AgentDebugMoveToPointer : MonoBehaviour
	{
		AgentGeneric m_Agent;
		RaycastHit m_HitInfo = new RaycastHit();

		void Start()
		{
			m_Agent = GetComponent<AgentGeneric>();
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
			{
				var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
					m_Agent.SetDestination(m_HitInfo.point);
			}
		}
	}
}
