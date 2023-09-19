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
            inst();
        }
    }

    void inst(){
        for(int i = 0, j = 0; i < 10; i++, j+=3){
            Vector3 nv = new Vector3(j,0,0);
            Instantiate(gameObject, nv, gameObject.transform.rotation);
        }
    }
}
