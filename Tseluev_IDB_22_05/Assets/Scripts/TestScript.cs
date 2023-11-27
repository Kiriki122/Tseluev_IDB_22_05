using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //cube = GameObject.Find("SpecialCube");
            Paint();
        }
    }

    void Paint(){
        for(int i = 0; i < 10; i++){
            Vector3 nv = new Vector3(i,0,0);
            Instantiate(gameObject, nv, gameObject.transform.rotation);
        }
    }
}
