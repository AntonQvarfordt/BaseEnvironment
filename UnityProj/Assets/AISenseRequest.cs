using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISenseRequest : MonoBehaviour {

	public AIVision VisionComponent;

	public bool CheckIsWithinViewField(Vector3 point)
	{
		return VisionComponent.IsPointWithinViewBounds(point);
	}

}
