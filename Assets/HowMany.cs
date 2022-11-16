using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowMany : MonoBehaviour
{
    public int buildings;
    [SerializeField] Text textCanv;
    // Start is called before the first frame update
    void Start()
    {
        textCanv.text = buildings.ToString();
    }

    // Update is called once per frame
}
