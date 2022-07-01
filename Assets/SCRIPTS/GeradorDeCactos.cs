using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeCactos : MonoBehaviour
{
    public GameObject[] cactoPrefabs;
    public float delayInicial;
    public float delayEnterCactos;
    
    void Start()
    {
        InvokeRepeating("GeradorCacto", delayInicial, delayEnterCactos);
    }
    void GeradorCacto()
    {
        delayEnterCactos = Random.Range(1.5f,4f);
        var cactoPrefab = cactoPrefabs[Random.Range(1, 4)];
        if(cactoPrefab == cactoPrefabs[3]){
            Instantiate(cactoPrefab, new Vector3(transform.position.x, Random.Range(1.5f, 3f), transform.position.z), Quaternion.identity);
        }else{
            Instantiate(cactoPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
