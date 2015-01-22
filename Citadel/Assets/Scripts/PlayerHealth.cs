using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public float HP = 40;
	public float MaxHP=40;
	void Update()
	{
		if( HP <= 0)
		{
			Destroy(gameObject);
			Debug.Log("Player Dead");
			Application.LoadLevel("GameOver");

		}
	}

	public void TakeDamage( float damage )
	{
		HP = HP - damage;
		Debug.Log( "HitPoints : " +HP);
	}
	void OnGUI ()
	{
		GUI.color = Color.black;
		GUI.Label (new Rect( Screen.width -110,80, 2100, 40), "Health:" + (int)HP +"/"+ MaxHP);
	}
}

