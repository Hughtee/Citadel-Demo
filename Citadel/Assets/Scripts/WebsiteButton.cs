using UnityEngine;
using System.Collections;

public class WebsiteButton : MonoBehaviour {

public void loadWebsite (string WebsiteToLoad)

	{
		Application.OpenURL("http://www.hughtrombley.com");
		}
}
