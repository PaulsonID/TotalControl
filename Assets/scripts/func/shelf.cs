using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelf : MonoBehaviour
{	public GameObject leftDoor;
	public GameObject rightDoor;
	public bool left_st;
	public bool right_st;
	public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (!anim.isPlaying){
    if (leftDoor.GetComponent<InteractStatus>().GetStatus() && !left_st )
	{
		 anim.Play("left_door|open");
		 left_st=true;
		 leftDoor.GetComponent<InteractStatus>().SetStatus(false);
	}
	else if (leftDoor.GetComponent<InteractStatus>().GetStatus() && left_st)
	{
		 anim.Play("left_door|close");
		 left_st=false;
		 leftDoor.GetComponent<InteractStatus>().SetStatus(false);
	}	
	if (rightDoor.GetComponent<InteractStatus>().GetStatus() && !right_st )
	{
		 anim.Play("right_door|open");
		 right_st=true;
		 rightDoor.GetComponent<InteractStatus>().SetStatus(false);
	}
	else if (rightDoor.GetComponent<InteractStatus>().GetStatus() && right_st)
	{
		 anim.Play("right_door|close");
		 right_st=false;
		 rightDoor.GetComponent<InteractStatus>().SetStatus(false);
	}		
    }}
}
