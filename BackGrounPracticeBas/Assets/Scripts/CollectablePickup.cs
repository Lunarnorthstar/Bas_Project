using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectablePickup : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    [SerializeField] private bool Hotbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            toActivate.SetActive(true);
            if (Hotbar == true)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Hotbar == false)
            {
                toActivate.SetActive(false);
            }
        }
    }
}
