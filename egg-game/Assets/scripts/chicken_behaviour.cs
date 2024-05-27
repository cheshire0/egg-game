using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chicken_behaviour : MonoBehaviour
{
    private float speed = 3f;
    public bool descending = false;
    private void Descend()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(11.75f,54f,0f),step);
    }
    private void Update()
    {
        if (descending) Descend();
    }
}
