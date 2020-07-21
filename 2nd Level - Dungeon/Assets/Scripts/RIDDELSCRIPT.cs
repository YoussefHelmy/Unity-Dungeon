using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RIDDELSCRIPT : MonoBehaviour
{
    private string ridddel1qurantine = "LWMRRQGAIU";
    private string ridddel2qurantine = "UXFGIWFIQO";
    private string ridddel3qurantine = "ULDOAFQFTU";
    //-------------------------------------------------------- RIDDEL1 ANSWER
    private string ridddel1BLOCKOFEPIDEMIC = "CSMHFRGFSFCKAEBU";
    private string ridddel2BLOCKOFEPIDEMIC = "AGLEXKICTFBHERQK";
    private string ridddel3BLOCKOFEPIDEMIC = "RMGEAKCSQDRTQBTZ";
    //----------------------------------------------------------RIDDEL2 ANSWER
    private string riddLE1NUCLEARBUMB = "MWEUIMADMCJA";
    private string riddLE2NUCLEARBUMB = "IRQACBIGRQLOL";
    private string riddLE3NUCLEARBUMB = "GQEUTOBDLPDW";
    //-----------------------------------------------------------RIDDEL3 ANSWER
    public GameObject RIDDEL1;
    public GameObject RIDDEL2;
    public GameObject RIDDEL3;
    public Text hint;
    private bool ISTRIGGER = false;
    private static int LOCKERNUMB;
    private static int RIDELTEXT;
    private static string riddelfinalaswer;
    DataKeeper dk;
    // Start is called before the first frame update
    void Start()
    {
        RIDDEL1.SetActive(false);
        RIDDEL2.SetActive(false);
        RIDDEL3.SetActive(false);
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();
    }
   
    void RIDDELSCRIPTS1()
    {
        RIDDEL1.SetActive(true);
        if (RIDELTEXT == 1)//qurantine==1 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel1qurantine; 
            hint.text = "qurantine";

        }
        else if (RIDELTEXT == 2)//"BLOCK OF EPIDEMIC" ==2 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel1BLOCKOFEPIDEMIC;
            hint.text = "BLOCK OF EPIDEMIC";


        }
        else if (RIDELTEXT == 3)// "NUCLEAR BUMB"  == YA HEGAZY TMAM
        {
            riddelfinalaswer = riddLE1NUCLEARBUMB;
            hint.text = "NUCLEAR BUMB";

        }
        else
        {
            Debug.LogError("error VALUE dude try again");
        }

        dk.SetCorrectPass(riddelfinalaswer, 1);
    }

    void RIDDELSCRIPTS2()
    {

        RIDDEL2.SetActive(true);
        if (RIDELTEXT == 1) //qurantine==1 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel2qurantine;
            hint.text = "qurantine";

        }
        else if (RIDELTEXT == 2)//"BLOCK OF EPIDEMIC" ==2 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel2BLOCKOFEPIDEMIC;
            hint.text = "BLOCK OF EPIDEMIC";

        }
        else if (RIDELTEXT == 3)// "NUCLEAR BUMB"  == 3 YA HEGAZY TMAM
        {
            riddelfinalaswer = riddLE2NUCLEARBUMB;
            hint.text = "NUCLEAR BUMB";

        }
        else
        {
            Debug.LogError("error variable dude try again");
        }
        dk.SetCorrectPass(riddelfinalaswer, 1);

    }
    void RIDDELSCRIPTS3()
    {
        RIDDEL3.SetActive(true);
        if (RIDELTEXT == 1) //qurantine==1 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel3qurantine;
            hint.text = "qurantine";
        }
        else if (RIDELTEXT == 2)//"BLOCK OF EPIDEMIC" ==2 YA HEGAZY TMAM
        {
            riddelfinalaswer = ridddel3BLOCKOFEPIDEMIC;
            hint.text = "BLOCK OF EPIDEMIC";

        }
        else if (RIDELTEXT == 3)// "NUCLEAR BUMB"  ==3 YA HEGAZY TMAM
        {
            riddelfinalaswer = riddLE3NUCLEARBUMB;
            hint.text = "NUCLEAR BUMB";

        }
        else
        {
            Debug.LogError("error variable dude try again");

        }
        dk.SetCorrectPass(riddelfinalaswer, 1);


    }
    void checkriddel()
    {
        Debug.Log(RIDELTEXT);

        if (LOCKERNUMB == 1)
        {
            RIDDELSCRIPTS1();
        }
        else if (LOCKERNUMB == 2)
        {
            RIDDELSCRIPTS2();
        }
        else 
        {
            RIDDELSCRIPTS3();
        }
    }

    public void lockernum(int locker)
    {
        LOCKERNUMB = locker;
        Debug.Log(locker);
        int rand = Random.Range(1, 4);
        Reddeltext(rand);
        checkriddel();
    }

    public void Reddeltext(int text)
    {
        RIDELTEXT = text;
    
    }

    
}
