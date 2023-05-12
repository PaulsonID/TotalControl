using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnWall : InteractStatus
{	public GameObject light_ob;
	public GameObject lamp;
	public Material on_lamp;
	public Material off_lamp;
	public GameObject switch_mech;
	public bool status_lamp;
    // Start is called before the first frame update
    void Start()
    {
        status_lamp=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<InteractStatus>().GetStatus()){
		gameObject.GetComponent<AudioSource>().Play(0);
		if (status_lamp){
		switch_mech.transform.eulerAngles=new Vector3(-10f,0,0);
		light_ob.GetComponent<Light>().enabled=false;
		lamp.GetComponent<Renderer>().material=off_lamp;
		status_lamp=false;
		}
		else if (!status_lamp){
		switch_mech.transform.eulerAngles=new Vector3(10f,0,0);
		light_ob.GetComponent<Light>().enabled=true;
		lamp.GetComponent<Renderer>().material=on_lamp;
		status_lamp=true;
		}
		gameObject.GetComponent<InteractStatus>().SetStatus(false);
		}
    }
}
