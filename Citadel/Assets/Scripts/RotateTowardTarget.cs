using UnityEngine;
using System.Collections;

// THIS WILL ROTATE THIS OBJECT ALONG THE POSITIVE X AXIS!

public class RotateTowardTarget : MonoBehaviour
{
	public Transform target;

	private Vector3 targetDirection;
	private float targetAngle;
	private Quaternion targetRotation;

	// Use this for initialization
	void Start ()
	{
		if (!target) {
			GameObject p = GameObject.FindGameObjectWithTag("Player");
			target = p.transform;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		targetDirection = target.position - transform.position;
		targetAngle = Mathf.Atan2 (targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (targetAngle, Vector3.forward);
	} 
}
