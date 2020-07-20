using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    private string _userName = "";
    private string _password = "";

    private const string usernameInputName = "UserNameLogin";
    private const string passwordInputName = "PasswordLogin";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this._userName = GameObject.Find(usernameInputName).GetComponent<InputField>().text;
        this._password = GameObject.Find(passwordInputName).GetComponent<InputField>().text;
        
        if (!string.IsNullOrWhiteSpace(this._userName))
        {
            Debug.Log($"Login User name: {_userName}");
        }

        if (!string.IsNullOrWhiteSpace(this._password))
        {
            Debug.Log($"Login Password: {_password}");
        }
    }
}
