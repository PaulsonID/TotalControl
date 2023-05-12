using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_GUI : MonoBehaviour
{	public Texture cursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnGUI(){
		GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/256f, Screen.height/2-Screen.height/120, Screen.width/128f,Screen.height/60),cursor );
	}
	
}
