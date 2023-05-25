using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class HomeComputerInteractive : InteractStatus
{
    [SerializeField] private bool interacted = false;

    [SerializeField] private TMP_InputField terminalInputField;

	public GameObject cursor;
    public GameObject text;
	public string outputValue;
    public string inputValue;
	public bool greeting;
	public Dictionary< string, string> greetings = new Dictionary<string, string>() // словарь хранящий все ответы на реплики игрока 
	{
		["hello"] = "сам хуйло, положи рубероид на место. \n шутка.Привет",
		["привет"]="ну привет, мудила",
		["здорова"]="ну привет, мудила",
		["здарова"]="ну привет, мудила",
		["приветствую"]="и тебе не хворать",
		["здравствуй"]="ну здравствуй,здравствуй",
	};
	public string [] repeat_greetings ={"здоровались уже","ешё раз десять скажи","у тебя склероз ?","похоже это уже деменция"};
	


    // Hello World

    // TMP_Text terminalVisualizationInput;
	private void Start() {
		//list.Add("hello", "Ну привет, мудила");
	}

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

        else if (Input.GetKeyUp(KeyCode.Return) & terminalInputField.text!="")
        {
		string pattern=@"\s+";
        inputValue=terminalInputField.text;
		inputValue=inputValue.ToLower();
		//inputValue=Regex.Replace(inputValue, @"[^\s]", "x");
		//Regex regex = new Regex(pattern);
		//inputValue=regex.Replace(terminalInputField.text,inputValue);
		text.GetComponent<TMP_Text>().text+="\n" + terminalInputField.text;
		Answer(inputValue);
		
		//	inputValue = terminalVisualizationInput.text;
        }
        // Режим ожидание ответа
    }
	private void Answer(string question) // функция получает обработанную регулярными выражениями из поля ввода и при наличии соответствия в словаре выводит ответ на экран
	{	
		terminalInputField.text="";	
		if (greetings.ContainsKey(question) ){ 
			if (greeting){text.GetComponent<TMP_Text>().text+="\n" + repeat_greetings[Random.Range(0, repeat_greetings.Length) ];}
			if (!greeting)text.GetComponent<TMP_Text>().text+="\n" + greetings[question];	greeting=true;
			
			SetStatusInteractive(true);
		}
	}

}
