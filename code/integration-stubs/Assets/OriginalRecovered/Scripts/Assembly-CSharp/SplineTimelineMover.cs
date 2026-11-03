using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.Timeline;

[ExecuteInEditMode]
public class SplineTimelineMover : MonoBehaviour, ITimeControl
{
	[SerializeField]
	private SplineContainer _splineContainer;

	[SerializeField]
	private double _duration;

	public void SetTime(double time)
	{
	}

	public void OnControlTimeStart()
	{
	}

	public void OnControlTimeStop()
	{
	}
}
