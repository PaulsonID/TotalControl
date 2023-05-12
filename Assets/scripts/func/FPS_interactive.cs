using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_interactive : MonoBehaviour
{	

	private float rayLength = 1.0f;
	
	private Vector3 playerPosition;
	

    private void Update()
    {
		ShotRaycast();
    }
	
	private void ShotRaycast(){
		if(Input.GetKeyDown(KeyCode.E)){
			Vector3 direction = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			
			playerPosition = transform.position;
			
			Vector3 startPointRay = playerPosition + new Vector3(0.0f, 0.0f, 0.0f);
			
			if (Physics.Raycast(startPointRay, direction, out hit, rayLength)){
				
				if (hit.collider.tag=="interact"){
					InteractStatus interactStatus = hit.collider.gameObject.GetComponent<InteractStatus>();
					
					if (!interactStatus.GetStatus()) interactStatus.SetStatus(true);
				}
			}
		}
	}
}
