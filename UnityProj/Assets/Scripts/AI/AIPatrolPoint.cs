using UnityEditor;
using UnityEngine;

public class AIPatrolPoint : MonoBehaviour
{
	public Vector2 HoldAtPointTime = new Vector2();

	public void OnDrawGizmos()
	{
		if (Selection.activeGameObject == gameObject)
		{
			Gizmos.DrawWireCube(transform.position, new Vector3(0.25f, 0.25f, 0.5f));
			Gizmos.color = Color.red;
			var nPos = new Vector3();
			nPos = transform.localPosition;
			nPos.z += 0.25f;
			Gizmos.DrawSphere(nPos, 0.15f);
		}
	}
}
