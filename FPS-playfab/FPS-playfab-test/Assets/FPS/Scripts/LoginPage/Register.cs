using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{    
    private string _userName = "";
    private string _email = "";
    private string _password = "";

    private const string usernameInputName = "UserNameRegistration";
    private const string emailInputName = "EmailRegistration";
    private const string passwordInputName = "PasswordRegistration";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this._userName = GameObject.Find(usernameInputName).GetComponent<InputField>().text;
        this._email = GameObject.Find(emailInputName).GetComponent<InputField>().text;
        this._password = GameObject.Find(passwordInputName).GetComponent<InputField>().text;
        
        if (!string.IsNullOrWhiteSpace(this._userName))
        {
            Debug.Log($"Register User name: {_userName}");
        }

        if (!string.IsNullOrWhiteSpace(this._email))
        {
            Debug.Log($"Register Email: {_email}");
        }

        if (!string.IsNullOrWhiteSpace(this._password))
        {
            Debug.Log($"Register Password: {_password}");
        }
    }
}
