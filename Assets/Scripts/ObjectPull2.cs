using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPull2 : MonoBehaviour
{
    public bool isActivated;
    public Button boton;
    public GameObject metodo;
    public ObjectPull objectPull;
    public GameObject datos;
    // Start is called before the first frame update
    void Start()
    {
        boton.onClick.AddListener(On);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void On()
    {
        if (isActivated == false) { isActivated = true;  metodo.SetActive(true); objectPull.isActivated = false; datos.SetActive(false); }
        else { isActivated = false; metodo.SetActive(false); datos.SetActive(true); }

    }
}
