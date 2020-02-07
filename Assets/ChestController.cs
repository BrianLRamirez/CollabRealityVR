using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public int player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            CoinManager cm = other.gameObject.GetComponent<CoinManager>();
            string mat = other.gameObject.GetComponent<Material>().name;

            Debug.Log(mat);

            Destroy(other.gameObject);
        }
    }
}
