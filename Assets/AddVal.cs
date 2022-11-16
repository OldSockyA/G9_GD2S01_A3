using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddVal : MonoBehaviour
{
    int tick = 0;
    [SerializeField] Text textCanv;
    public int changeV;
    public int changeT;
    public int startV;

    // Start is called before the first frame update
    void Start()
    {
        textCanv.text = startV.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        tick += 1;
        if (tick % changeT == 0) {
            startV += changeV;
            
            textCanv.text = startV.ToString();
        }
    }
}
