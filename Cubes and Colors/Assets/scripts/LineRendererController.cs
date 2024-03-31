using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
	[SerializeField] private LineRenderer _lineRenderer;
	private List<Vector3> _linePositions = new List<Vector3>();
	[SerializeField] Transform[] point;


	public void SetLineRendererPoint(Vector3 pointPosition)
	{
		_linePositions.Add(pointPosition);
		_lineRenderer.positionCount = _linePositions.Count;
		_lineRenderer.SetPositions(_linePositions.ToArray());
	}
}
