using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomShape : MonoBehaviour
{
    public List<Material> mats = new List<Material>();
    public GameObject coin;
    
    void Start()
    {
        Spawn();
    }
    
    public void Spawn()
    {
        GameObject obj = Instantiate(coin);
        obj.GetComponent<MeshRenderer>().material = mats[Random.Range(0, mats.Count)];
        obj.GetComponent<CoinManager>().spawner = this;
    }
}
