using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerM : MonoBehaviour {


    public string randomOperatorM;
    public int answerM;

    public GameObject questionM;
    public GameObject option3;
    public GameObject option4;
    public GameObject option5;
    public GameObject restart;


	// Use this for initialization
	void Start () 
    {
        // Starting in 0 seconds.
        // a projectile will be launched every 5 seconds
        InvokeRepeating("GenerateQuestionM", 0.0f, 5f);

    }
	
	// Update is called once per frame
	void Update () {

    }

    public void GenerateQuestionM()
    {
        int c = Random.Range(0, 11);
        int d = Random.Range(0, 11);
        int operatorNumberM = Random.Range(0, 1);

        if(operatorNumberM == 0)
        {
            randomOperatorM = "*";
            answerM = c * d;
        }
        else
        {
            randomOperatorM = "*";
            answerM = c * d;
        }


        int optionM = Random.Range(0, 3);
        string questionTextM = c + " " + randomOperatorM + " " + d + " = ?";

        questionM.GetComponent<TextMesh>().text = questionTextM;

        int ansM = Random.Range(0, 2);

        if (optionM == 0)
        {
            option3.GetComponent<TextMesh>().text = answerM.ToString();
            option4.GetComponent<TextMesh>().text = (answerM + Random.Range(-5, 0)).ToString();
            option5.GetComponent<TextMesh>().text = (answerM + Random.Range(1, 5)).ToString();
            option3.GetComponent<OptionM>().isCorrect = true;
            option4.GetComponent<OptionM>().isCorrect = false;
            option5.GetComponent<OptionM>().isCorrect = false;
        }
        else if(optionM == 1)
        {
            option3.GetComponent<TextMesh>().text = (answerM + Random.Range(-5, 0)).ToString();
            option4.GetComponent<TextMesh>().text = answerM.ToString();
            option5.GetComponent<TextMesh>().text = (answerM + Random.Range(1, 5)).ToString();
            option3.GetComponent<OptionM>().isCorrect = false;
            option4.GetComponent<OptionM>().isCorrect = true;
            option5.GetComponent<OptionM>().isCorrect = false;
        }
        else
        {
            option3.GetComponent<TextMesh>().text = (answerM + Random.Range(-5, 0)).ToString();
            option4.GetComponent<TextMesh>().text = (answerM + Random.Range(1, 5)).ToString();
            option5.GetComponent<TextMesh>().text = answerM.ToString();
            option3.GetComponent<OptionM>().isCorrect = false;
            option4.GetComponent<OptionM>().isCorrect = false;
            option5.GetComponent<OptionM>().isCorrect = true;
        }


    }

}
