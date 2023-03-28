using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomjumpcount : MonoBehaviour
{
    public GameObject player;
    public TMP_InputField numberInput;
    public TMP_Text blocknumberText;
    public void Jump_Function()
    {
        int v = int.Parse(numberInput.text);
        
        if (v>=1 && v<=4)
           {
            blocknumberText.text = "block number: " + numberInput.text;
            StartCoroutine(JumpFun(v));
            StartCoroutine(BlockNumber());
           }
    }

    IEnumerator JumpFun(int v)
    {

        for (int k = 0; k < v; k++)
        {
            yield return new WaitForSeconds(0.5f);
            player.transform.Translate(-Vector3.right * 5.5f);
        }
    }

    IEnumerator BlockNumber()
    {
        yield return new WaitForSeconds(50f);
        blocknumberText.text = "block number: ";
    }
}
