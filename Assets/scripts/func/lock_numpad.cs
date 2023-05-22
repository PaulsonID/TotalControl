using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class lock_numpad : InteractStatus
{
	public GameObject locking_device;
	public string code;
	[SerializeField]	private string input;
	public GameObject text;
    // Start is called before the first frame update
	enum opening_mode 
	{
		sliding,
		hiding,
		animation,
		rotation
	};
	[SerializeField] private opening_mode mode;
    // Update is called once per frame
    void Update()
    {
     if (GetStatusInteractive())  Input_code();
    }
	void Input_code () 
	{	if (input.Length<code.Length){
		if (Input.GetKeyDown(KeyCode.Alpha1))
			{
			input+="1";
			}
		if (Input.GetKeyDown(KeyCode.Alpha2))
			{
			input+="2";
			}
		if (Input.GetKeyDown(KeyCode.Alpha3))
			{
			input+="3";
			}
		if (Input.GetKeyDown(KeyCode.Alpha4))
			{
			input+="4";
			}
		if (Input.GetKeyDown(KeyCode.Alpha5))
			{
			input+="5";
			}
		if (Input.GetKeyDown(KeyCode.Alpha6))
			{
			input+="6";
			}
		if (Input.GetKeyDown(KeyCode.Alpha7))
			{
			input+="7";
			}
		if (Input.GetKeyDown(KeyCode.Alpha8))
			{
			input+="8";
			}
		if (Input.GetKeyDown(KeyCode.Alpha9))
			{
			input+="9";
			}
		if (Input.GetKeyDown(KeyCode.Alpha0))
			{
			input+="0";
			}
	}
	else if (input.Length==code.Length){
		if(input==code){
			if (mode==opening_mode.hiding){
				Hiding();
			}
		}
		if (input!=code){input="";}
	}
		if (Input.GetKeyDown(KeyCode.Escape))
			{
			input="";
			
			SetStatusInteractive(false);
			}
		text.GetComponent<TMP_Text>().text=input;
	}
	void WrongAnim(){
		
	}
	void Hiding(){
		
	}
}
