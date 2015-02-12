using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour 
{
	public PlayerHealth playerhealth;
	public GameObject Enemy;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;



	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn () 
	{
		if (playerhealth.Health <= 0f) 
		{
			return;
		}
	
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (Enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
