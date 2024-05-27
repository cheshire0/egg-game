using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible_behaviour : MonoBehaviour
{
    public GameObject egg;
    public GameObject counter;

    void OnTriggerEnter2D(Collider2D other)

    {
        egg.GetComponent<egg_behaviour>().collected += 1;
        int collected=egg.GetComponent<egg_behaviour>().collected;
        counter.GetComponent<collectible_counter>().UpdateText(collected);
        Destroy(gameObject);
    }
}
