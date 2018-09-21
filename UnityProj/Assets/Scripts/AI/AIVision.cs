using System.Collections.Generic;
using UnityEngine;

public class AIVision : MonoBehaviour
{
	public List<Transform> VisionBounds = new List<Transform>();

	public bool IsPointWithinViewBounds (Vector3 point)
	{
		return CalculateBounds().Contains(point);
	}

	private Bounds CalculateBounds()
	{
		var matrix = Matrix4x4.identity;
		var points = new List<Vector3>();

		foreach (Transform marker in VisionBounds)
		{
			points.Add(marker.position);
		}

		var returnValue = GeometryUtility.CalculateBounds(points.ToArray(), matrix);
		return returnValue;
	}
}
