using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            OnTriggerDisable();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            OnTriggerEnable();
        }
    }

        private void OnTriggerDisable()
    {
        // Скрыть текущий объект
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }

        private void OnTriggerEnable()
    {
        // Показать текущий объект
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;   
    }
}


