using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{


	public GameObject player;
	public float attackRange;
	public Transform firePoint;
	public GameObject projectile;
	public float fireRate;
	private float nextFire;
	public bool doesnotDisengage = false; // Finds player, doesn't stop attacking.
	private bool playerFound = false;
	public Animator anim;



	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();		
		playerFound = false;
				{
						if (GetComponent<Rigidbody> ()) {
								GetComponent<Rigidbody> ().freezeRotation = true;
				anim.SetBool ("Tower Down",true);
			}

				}
		}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (player) {
			if (attackRange > Vector3.Distance (player.transform.position, transform.position)
				|| playerFound) {
				// We found the Player  We don't want to stop attacking
				if (doesnotDisengage) 
				{
					playerFound = true;
				

				}
				// Look AT Player
				transform.LookAt (player.transform);




				if (Time.time > nextFire) {
					nextFire = Time.time + fireRate;

					GameObject bullet = Instantiate (projectile, firePoint.position, firePoint.rotation) as GameObject;
				
					bullet.GetComponent<Projectile> () .CreatedBy ("Enemy03");
				}

			} else {
			
			}
		} else {
			player = GameObject.FindGameObjectWithTag ("Player");
			
		}
	}


}