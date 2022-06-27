using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoChao : MonoBehaviour
{
    public float diferencaX;
    public float minX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= minX){
            transform.position = new Vector3(
                transform.position.x + diferencaX * 2,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
