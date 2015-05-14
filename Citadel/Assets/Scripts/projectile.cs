using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public Transform Player;
	public float damage;
	public float fireRate;
	private string creator;
	public float speed;
	public float lifetime = 5.0f;
	
	
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = transform.right * speed;
		
		Destroy (this.gameObject, lifetime );
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D( Collider2D other) 
	{
		if (other.tag == "Player" && creator == "Enemy03") {
			Debug.Log ("Hit Player");
			Destroy(gameObject);
			
		} 
		if (other.tag == "Wall" && creator == "Enemy03") {
			Debug.Log ("Hit Wall");
			Destroy(gameObject);
			
		} 
		
		
	}
	
	
	public void CreatedBy (string tag) {
		creator = tag;
	}
	
	public float FireRate () {
		
		return fireRate;
		
	}
}