using AQAI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AgentCenter))]
public class LocomotionAnimator : MonoBehaviour {
	
	public Animator LocomotionAimatorComponent;

	private AgentCenter _agentCenter;

	private void Awake()
	{
		_agentCenter = GetComponent<AgentCenter>();
	}

	private void Update()
	{
		LocomotionAimatorComponent.SetFloat("velocity", _agentCenter.GetAgentVelocity);
	}
}
