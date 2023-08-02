using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
//using Random = System.Random;
public class Main : MonoBehaviour
{
    public string GetDevText1;
    public string GetDevText2;
    public string GetDevText3;
    public string GetAdvText1;
    public string GetAdvText2;
    public string GetAdvText3;
    public GameObject inputField;
    public GameObject inputField3;
    public GameObject inputField2;
    public GameObject inputField4;
    public GameObject inputField5;
    public GameObject inputField6;
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
    public int InputDevInt1;
    public int InputDevInt2;
    public int InputDevInt3;
    public int InputAdvInt4;
    public int InputAdvInt5;
    public int InputAdvInt6;

    /*Attempted use of Ienumerables, decided to just declare ints with rangdom.range within the Adv class
     * IEnumerable<int> AdvDice;
    IEnumerable<int> AdvDice1 = Enumerable.Range(1, 15);
    IEnumerable<int> AdvDice2 = Enumerable.Range(1, 12);
    IEnumerable<int> AdvDice3 = Enumerable.Range(1, 10);
    IEnumerable<int> AdvDice4 = Enumerable.Range(1, 8);
    IEnumerable<int> AdvDice5 = Enumerable.Range(1, 6);
    IEnumerable<int> AdvDice6 = Enumerable.Range(1, 4);
    */
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
        GetDevText1 = inputField.GetComponent<Text>().text;
        GetDevText2 = inputField2.GetComponent<Text>().text;
        GetDevText3 = inputField3.GetComponent<Text>().text;
    }
    public void DevInvest()
    {
        int.TryParse(GetDevText1, out InputDevInt1);
        int.TryParse(GetDevText2, out InputDevInt2);
        int.TryParse(GetDevText3, out InputDevInt3);
    }
    public void CategoryInvestmentDev()
    {
       //CEO 1
        if (InputDevInt1 == 150)
        {
            UnitPrice1 = 215;
        }
        else if (InputDevInt1 == 250)
        {
            UnitPrice1 = 275;
        }
        else if (InputDevInt1 == 400)
        {
            UnitPrice1 = 350;
        }
        else if (InputDevInt1 == 550)
        {
            UnitPrice1 = 400;
        }
        else if (InputDevInt1 == 850)
        {
            UnitPrice1 = 700;
        }
        //CEO 2
        if(InputDevInt2 == 150)
        {
            UnitPrice2 = 215;
        }
        else if (InputDevInt2 == 250)
        {
            UnitPrice2 = 275;
        }
        else if (InputDevInt2 == 400)
        {
            UnitPrice2 = 350;
        }
        else if (InputDevInt2 == 550)
        {
            UnitPrice2 = 400;
        }
        else if (InputDevInt2 == 850)
        {
            UnitPrice2 = 700;
        }
        //CEO 3
        if(InputDevInt2 == 150)
        {
            UnitPrice2 = 215;
        }
        else if (InputDevInt2 == 250)
        {
            UnitPrice1 = 275;
        }
        else if (InputDevInt2 == 400)
        {
            UnitPrice1 = 350;
        }
        else if (InputDevInt2 == 550)
        {
            UnitPrice2 = 400;
        }
        else if (InputDevInt2 == 850)
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
    public void GetAdvInput()
    {
        GetAdvText1 = inputField4.GetComponent<Text>().text;
        GetAdvText2 = inputField5.GetComponent<Text>().text;
        GetAdvText3 = inputField6.GetComponent<Text>().text;
    }
    public void GetDevInvest()
    {
        int.TryParse(GetAdvText1, out InputAdvInt4);
        int.TryParse(GetAdvText2, out InputAdvInt5);
        int.TryParse(GetAdvText3, out InputAdvInt6);
    }
    public void CategoryInvestmentAdv()
    {
        int AdvDice1 = Random.Range(1, 15);
        int AdvDice2 = Random.Range(1, 12);
        int AdvDice3 = Random.Range(1, 10);
        int AdvDice4 = Random.Range(1, 8);
        int AdvDice5 = Random.Range(1, 6);
        int AdvDice6 = Random.Range(1, 4);
        if(InputAdvInt4 == 0)
        {
            Adv = AdvDice1;
        }else if(InputAdvInt4 == 200)
        {
            Adv = AdvDice2;
        }else if(InputAdvInt4 == 300)
        {
            Adv = AdvDice3;
        }else if( InputAdvInt4 == 400)
        {
            Adv = AdvDice4;
        }else if(InputAdvInt4 == 550)
        {
            InputAdvInt4 = AdvDice5;
        }else if(InputAdvInt4 == 850)
        {
            InputAdvInt4 = AdvDice6;
        }
        if (InputAdvInt5 == 0)
        {
            Adv2 = AdvDice1;
        }
        else if (InputAdvInt5 == 200)
        {
            Adv2 = AdvDice2;
        }
        else if (InputAdvInt5 == 300)
        {
            Adv2 = AdvDice3;
        }
        else if (InputAdvInt5 == 400)
        {
            Adv2 = AdvDice4;
        }
        else if (InputAdvInt5 == 550)
        {
            Adv2 = AdvDice5;
        }
        else if (InputAdvInt5 == 850)
        {
            Adv = AdvDice6;
        }
        if (InputAdvInt6 == 0)
        {
            Adv3 = AdvDice1;
        }
        else if (InputAdvInt6 == 200)
        {
            Adv3 = AdvDice2;
        }
        else if (InputAdvInt6 == 300)
        {
            Adv3 = AdvDice3;
        }
        else if (InputAdvInt6 == 400)
        {
            Adv3 = AdvDice4;
        }
        else if (InputAdvInt6 == 550)
        {
            Adv3 = AdvDice5;
        }
        else if (InputAdvInt6 == 850)
        {
            Adv3 = AdvDice6;
        }
    }
}