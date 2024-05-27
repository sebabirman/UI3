using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loginmanager : MonoBehaviour
{
    public InputField Inputpassword;
    public string password = "9090" ;
    // Start is called before the first frame update
    public void chequearcontraseña()
    {
        if (Inputpassword.text == password)
        {
            Debug.Log("acces granted");
        }
       
            else
        {
            Debug.Log("Acces denied");
        }

    }
    
}
