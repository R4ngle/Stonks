using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrimaryCode : MonoBehaviour
{
    public string GetText;
    public string GetText2;
    public string GetText3;
    public int random;
    public GameObject inputField;
    public GameObject inputField3;
    public GameObject inputField2;
    public List<string> Numbers;
    public int PlayerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void AddToList()
{
    GetText = inputField.GetComponent<InputField>().text;
    GetText2 = inputField2.GetComponent<Text>().text;
    GetText3 = inputField3.GetComponent<Text>().text;
    
    Numbers.Add(GetText);
    Numbers.Add(GetText2);
    Numbers.Add(GetText3);
}
}