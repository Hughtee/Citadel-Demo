using UnityEngine;
using System.Collections;

public class PointOfNoReturn : MonoBehaviour 
{
	//private NewMovemet newMovement ;

	void Awake()
		{
		//newMovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<NewMovemet>();
		}
	void OnTriggerExit2D(Collider2D other)
		{
			if (other.gameObject.tag == "Player") 
				{
				collider2D.isTrigger = false;
				Debug.Log("the point of no retunr");
				}
		}

}
