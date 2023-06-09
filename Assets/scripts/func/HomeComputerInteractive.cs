using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HomeComputerInteractive : InteractStatus
{
    [SerializeField] private bool interacted = false;

    [SerializeField] private TMP_InputField terminalInputField;

    public GameObject text;

    public string inputValue;

    // Hello World

    // TMP_Text terminalVisualizationInput;


    private void Update()
    {
        if (GetStatusInteractive()) StartWorkToPC();

        /*
            if (GetStatusInteractive()){

                if (Input.GetKey(KeyCode.Escape)){
                    SetStatusInteractive(false);
                }

                if (Input.GetKey(KeyCode.Return)){
                input_text=text1.GetComponent<TMP_Text>().text;
                }
            }
            else if (!GetStatusInteractive()){
                canvas.GetComponent<TMP_InputField>().ActivateInputField();
                text.GetComponent<TextMesh>().text+=">>Ghostmaker:Привет \n";   
              }

              */
    }

    private void StartWorkToPC()
    {
        // Приветствие. Once

        // Режим ввода
        if (!interacted) terminalInputField.ActivateInputField();
        interacted = true;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //terminalInputField.DeactivateInputField();
            SetStatusInteractive(false);
            interacted = false;
        }
        //else if(Input.GetMouseButtonDown(1)){
        //	terminalInputField.DeactivateInputField();
        //}

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //	inputValue = terminalVisualizationInput.text;
        }
        // Режим ожидание ответа
    }
}
