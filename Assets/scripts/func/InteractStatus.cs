using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractStatus : MonoBehaviour
{
	[SerializeField] private bool interactive = false;
	
	public bool GetStatus() => interactive;
	
	public void SetStatus(bool newStatus) => interactive = newStatus;
}
