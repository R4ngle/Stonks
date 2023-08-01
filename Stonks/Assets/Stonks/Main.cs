using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
//using Random = System.Random;
public class Main : MonoBehaviour
{
    public string GetText;
    public string GetText2;
    public string GetText3;
    public GameObject inputField;
    public GameObject inputField3;
    public GameObject inputField2;
    public List<string> NumbersList;
    public int PlayerScore;
    public int StartingMoney = 1000;
    public int Dev;
    public int Pro;
    public int Adv;
    public int Dev2;
    public int Pro2;
    public int Adv2;
    public int Dev3;
    public int Pro3;
    public int Adv3;
    public int UnitPrice1 = 150;
    public int UnitPrice2 = 150;
    public int UnitPrice3 = 150;
    public int InputInt1;
    public int InputInt2;
    public int InputInt3;

    IEnumerable<int> AdvDice;
    IEnumerable<int> AdvDice1 = Enumerable.Range(1, 15);
    IEnumerable<int> AdvDice2 = Enumerable.Range(1, 12);
    IEnumerable<int> AdvDice3 = Enumerable.Range(1, 10);
    IEnumerable<int> AdvDice4 = Enumerable.Range(1, 8);
    IEnumerable<int> AdvDice5 = Enumerable.Range(1, 6);
    IEnumerable<int> AdvDice6 = Enumerable.Range(1, 4);
    public List<string> Prod1 = new List<string>()
    {
        "1","2"
    };
    public List<string> Prod2 = new List<string>()
    {
        "1","2"
    };
    public List<string> Prod3 = new List<string>()
    {
        "1","2"
    };
    void Start()
    {
        int Adver = Random.Range(0, 15);

    }
    void Update()
    {
        CategoryInvestmentAdv();
    }
    public void getDevInput()
    {
        GetText = inputField.GetComponent<Text>().text;
        GetText2 = inputField2.GetComponent<Text>().text;
        GetText3 = inputField3.GetComponent<Text>().text;
    }
    public void DevInvest()
    {
        int.TryParse(GetText, out InputInt1);
        int.TryParse(GetText2, out InputInt2);
        int.TryParse(GetText3, out InputInt3);
    }
    public void CategoryInvestmentDev()
    {
       //CEO 1
        if (InputInt1 == 150)
        {
            UnitPrice1 = 215;
        }
        else if (InputInt1 == 250)
        {
            UnitPrice1 = 275;
        }
        else if (InputInt1 == 400)
        {
            UnitPrice1 = 350;
        }
        else if (InputInt1 == 550)
        {
            UnitPrice1 = 400;
        }
        else if (InputInt1 == 850)
        {
            UnitPrice1 = 700;
        }
        //CEO 2
        if(InputInt2 == 150)
        {
            UnitPrice2 = 215;
        }
        else if (InputInt2 == 250)
        {
            UnitPrice2 = 275;
        }
        else if (InputInt2 == 400)
        {
            UnitPrice2 = 350;
        }
        else if (InputInt2 == 550)
        {
            UnitPrice2 = 400;
        }
        else if (InputInt2 == 850)
        {
            UnitPrice2 = 700;
        }
        //CEO 3
        if(InputInt2 == 150)
        {
            UnitPrice2 = 215;
        }
        else if (InputInt2 == 250)
        {
            UnitPrice1 = 275;
        }
        else if (InputInt2 == 400)
        {
            UnitPrice1 = 350;
        }
        else if (InputInt2 == 550)
        {
            UnitPrice2 = 400;
        }
        else if (InputInt1 == 850)
        {
            UnitPrice2 = 700;
        }
        /* Not needed, changed rules to use preset numbers
        public void AddToList()
        {
            GetText = inputField.GetComponent<InputField>().text;
            GetText2 = inputField2.GetComponent<Text>().text;
            GetText3 = inputField3.GetComponent<Text>().text;

            NumbersList.Add(GetText);
            NumbersList.Add(GetText2);
            NumbersList.Add(GetText3);
        }*/
    }
    public void CategoryInvestmentProd()
    {
        if (Pro == 300)
        {
            Prod1.Add("3");
        }
        else if (Pro == 450)
        {
            Prod1.AddRange(new List<string> { "3", "4" });
        }else if(Pro == 700) 
        {
            Prod1.AddRange(new List<string> { "3,4,5" });
        }
        if (Pro2 == 300)
        {
            Prod2.Add("3");
        }
        else if (Pro2 == 450)
        {
            Prod2.AddRange(new List<string> { "3", "4" });
        }
        else if (Pro2 == 700)
        {
            Prod2.AddRange(new List<string> { "3,4,5" });
        }
        if (Pro3 == 300)
        {
            Prod3.Add("3");
        }
        else if (Pro3 == 450)
        {
            Prod3.AddRange(new List<string> { "3", "4" });
        }
        else if (Pro3 == 700)
        {
            Prod3.AddRange(new List<string> { "3,4,5" });
        }
    }
    public void CategoryInvestmentAdv()
    {
       /
    }
}