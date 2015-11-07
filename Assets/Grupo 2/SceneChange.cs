using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	
	// Use this for initialization
	public void scene (string CambiarEscena)  {
		
		Application.LoadLevel (CambiarEscena);
		
	}
}

