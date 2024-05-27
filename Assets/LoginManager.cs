using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour

{
    string rightPassword = "dan123";
    public InputField inputfield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void checkLogIn(string password, string input)
    {
        if (input == password)
        {
            Debug.Log("Acceso concedido");
        } 
        else
        {
            Debug.Log("Acceso denegado");
        }
    
    }
    public void ButtonClick()
    {
        checkLogIn(rightPassword, inputfield.text);
    }
}
