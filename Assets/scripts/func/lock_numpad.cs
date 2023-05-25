using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class lock_numpad : InteractStatus
{
	public GameObject locking_device;
	public string code;
	public GameObject cursor;
	public GameObject button1;
	[SerializeField]	private string input;
	[SerializeField]	private bool opened=false; // флаг открыт ли сейф, не даёт повторно запускать ввод кода на открытом сейфе
	public GameObject text;
	
	enum opening_mode 
	{
		sliding,
		hiding,
		animation,
		rotation
	};
	[SerializeField] private opening_mode mode;

    void Update()
    {
     if (GetStatusInteractive() & !opened)  {Input_code(); Cursor.visible = true;}
	 else if (GetStatusInteractive() & opened)  {SetStatusInteractive(false); Cursor.visible = false;}
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
				opened=true;
			}
			input="";
			SetStatusInteractive(false);
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
	locking_device.SetActive(false);

	}
}
