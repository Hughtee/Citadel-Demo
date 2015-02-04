using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D Enemy){

		Destroy (Enemy.gameObject);
		}
}
