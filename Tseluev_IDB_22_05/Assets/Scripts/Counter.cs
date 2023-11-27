using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public static float count = 0;

    public Text CounterObj;

    // Start is called before the first frame update
    void Start()
    {
        CounterObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CounterObj.text = count.ToString();
    }
}
