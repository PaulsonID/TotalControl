using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	//if (Input.GetAxis("Mouse ScrollWheel")>0)
	//{
		gameObject.transform.eulerAngles=new Vector3 (gameObject.transform.eulerAngles.x,gameObject.transform.eulerAngles.y+(Input.GetAxis("Mouse ScrollWheel")*10),gameObject.transform.eulerAngles.z);
	//}

    }
}
