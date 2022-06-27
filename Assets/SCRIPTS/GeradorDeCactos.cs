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
        var cactoPrefab = cactoPrefabs[Random.Range(0, 3)];
        Instantiate(cactoPrefab, transform.position, Quaternion.identity);
    }
}
