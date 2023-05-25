using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_interactive : MonoBehaviour
{	

	private float rayLength = 1.0f;
	private Vector3 playerPosition;
	public bool intrigger;
	

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
					
					if (!interactStatus.GetStatusInteractive()) interactStatus.SetStatusInteractive(true);
				}
		}}
			if (intrigger){
				Vector3 direction = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			
			playerPosition = transform.position;
			Vector3 startPointRay = playerPosition + new Vector3(0.0f, 0.0f, 0.0f);
			if (Physics.Raycast(startPointRay, direction, out hit, 3)){
				
				if (hit.collider.tag=="interact")
				{
				if (!GetComponent<FPS_GUI>().switch_cursor) GetComponent<FPS_GUI>().switch_cursor=true;
				hit.collider.gameObject.GetComponent<lock_numpad>().cursor.transform.position=hit.point;				
				}
				if (hit.collider.tag!="interact" && GetComponent<FPS_GUI>().switch_cursor) GetComponent<FPS_GUI>().switch_cursor=false;
				if (hit.collider.tag=="WS_UI")
				{
				hit.collider.gameObject.GetComponent<worldSpaceButton>().test=true;
				hit.collider.gameObject.GetComponent<worldSpaceButton>().Click();
					
				
				}
			
			}
			}
		
	}
	void OnTriggerEnter(Collider col){
	if (col.tag=="cursor_interact" & !intrigger){
	intrigger=true;	
	}}
	void InteractCursor(GameObject terminal){
		
		Vector3 direction = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			
			playerPosition = transform.position;
			
			Vector3 startPointRay = playerPosition + new Vector3(0.0f, 0.0f, 0.0f);
			if (Physics.Raycast(startPointRay, direction, out hit, rayLength)){
				
				if (hit.collider.tag=="interact")
				{
			
				hit.collider.gameObject.GetComponent<lock_numpad>().cursor.transform.position=hit.point;				
				}
			}
	}
	void OnTriggerExit(Collider col){
	//if (col.tag=="cursor_interact" & intrigger){
	intrigger=false;	
	Debug.Log("BOOM");
	}//}
}
