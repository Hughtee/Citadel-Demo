using UnityEngine;
using System.Collections;

public class QuadrantAttack : MonoBehaviour
{
	public string TargetTag;
	//private CircleCollider2D collider; 

	float SW = 0.78539816f; // 45
	float SE = 2.35619449f; // 135
	float NE = 3.92699082f; // 225
	float NW = 5.49778714f; // 315
	float PI = 3.14159265f; // 180

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag (TargetTag)) {				

			if( isInsidePieSlice ( collider.transform.position, SW, SE ) ) {
				Debug.Log( "COLLIDED SOUTH" );
			}
			else if( isInsidePieSlice ( collider.transform.position, SE, NE ) ) {
				Debug.Log( "COLLIDED EAST" );
			}
			else if( isInsidePieSlice ( collider.transform.position, NE, NW ) ) {
				Debug.Log( "COLLIDED NORTH" );
			}
			else {
				Debug.Log( "COLLIDED WEST" );
			}
		}
	}

	bool isInsidePieSlice (Vector3 pos, float startAngle, float endAngle )
	{
		float posAngle = Mathf.Atan2( pos.y - transform.position.y, pos.x - transform.position.x );
		posAngle += PI;
		
		if (startAngle < posAngle && endAngle > posAngle) {
			return true;
		} else {
			return false;
		}
	}
}
