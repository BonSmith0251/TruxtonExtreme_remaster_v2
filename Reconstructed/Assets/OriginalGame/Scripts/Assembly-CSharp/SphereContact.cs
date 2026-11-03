using UnityEngine;

public class SphereContact : MonoBehaviour
{
	[SerializeField]
	private Transform sp1t;

	[SerializeField]
	private Vector3 vel1;

	[SerializeField]
	private float r1;

	[SerializeField]
	private Transform da1;

	[SerializeField]
	private Transform da2;

	[SerializeField]
	private Transform da3;

	[Space]
	[SerializeField]
	private Transform sp2t;

	[SerializeField]
	private Vector3 vel2;

	[SerializeField]
	private float r2;

	[SerializeField]
	private Transform db1;

	[SerializeField]
	private Transform db2;

	[SerializeField]
	private Transform db3;

	[SerializeField]
	private bool oncontact;

	private void Update()
	{
	}
}
