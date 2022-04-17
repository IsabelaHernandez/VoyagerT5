using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveB : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    
    

    void Start()
    {
        dialogBox.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
}
