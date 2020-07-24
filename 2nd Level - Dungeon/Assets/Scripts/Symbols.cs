using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbols : MonoBehaviour
{

    public Material[] symbols;
    int symbolsNumber;
    MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        symbolsNumber = symbols.Length;
        Debug.Log(symbolsNumber);
        rend = GetComponent<MeshRenderer>();
        int temp = Randomize(0, symbolsNumber - 1);


        rend.material = symbols[temp];



    }

    // Update is called once per frame
   

    int Randomize(int min, int max)
    {
        int rand = Random.Range(min, max);

        return rand;
    }
}
