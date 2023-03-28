using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice1;
    public GameObject Choice2;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        TextBox.GetComponent<TextMeshProUGUI>().text = "You got it!! that's the correct answer.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        TextBox.GetComponent<TextMeshProUGUI>().text = "Oops... , that's the wrong answer!!";
        ChoiceMade = 2;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice1.SetActive(false);
            Choice2.SetActive(false);
        }
    }

}