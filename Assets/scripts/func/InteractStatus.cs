using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractStatus : MonoBehaviour
{
	[SerializeField] private bool interactive = false;
	
	public bool GetStatusInteractive() => interactive;
	
	public void SetStatusInteractive(bool newStatus) => interactive = newStatus;


}
