using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject BaseCube;
    public GameObject CollideCube;
    public static float speed = 0.01F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CollideCube.transform.position = Vector3.MoveTowards(CollideCube.transform.position, BaseCube.transform.position, speed);
    }
}
