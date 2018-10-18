using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{


    public int answer;
    public string randomOperator;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;


    // Use this for initialization
    void Start () {
        GenerateQuestion();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void GenerateQuestion()
    {
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);

        int operatorNumber = Random.Range(0, 2);

        if(operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else
        {
            randomOperator = "-";
            answer = a - b;
        }

        int option = Random.Range(0, 2);

        string questionText = a + " " + randomOperator + " " + b + " = ?";

        question.GetComponent<TextMesh>().text = questionText;

        if(option == 0){
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;

        }
        else
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;

        }
    }


}
