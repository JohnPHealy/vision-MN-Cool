using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    public void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "Player")
         {
            manager.CoinCollect();
            StartCoroutine(DestroyCoroutine());
         }
    }

    IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
