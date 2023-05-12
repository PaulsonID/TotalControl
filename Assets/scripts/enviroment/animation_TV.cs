using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_TV : MonoBehaviour
{	public Animation anim;
	public float timer;
    // Start is called before the first frame update
    void Start()
    {	
	  //anim.AddClip( emily_tv ,"emily_tv");
      anim.Play("emily_tv");    
    }

    // Update is called once per frame
    void FixedUpdate()
    {	timer+=Time.deltaTime;
      if (!anim.isPlaying && timer<23){
		anim.Play("voice");  
	 if (timer>=23f){
		 anim.Stop();
	 }
	  }
    }
}
