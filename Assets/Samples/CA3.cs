using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CA3 : MonoBehaviour
{
    [Header("Input Fields")]
    public TMP_InputField usernameField;
    public TMP_InputField passwordField;

    [Header("Feedback")]
    public TextMeshProUGUI errorMessage;  

    [Header("Correct Login Info")]
    public string correctPassword = "1234";

    
    public void Login()
    {
        string enteredPassword = passwordField.text;

        if (enteredPassword != correctPassword)
        {
            errorMessage.gameObject.SetActive(true);
            return;
        }

        
        SceneManager.LoadScene("SampleScene");
    }

    
}
