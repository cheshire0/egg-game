using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class nest_behaviour : MonoBehaviour
{
    public GameObject chicken;
    public GameObject egg;
    public GameObject time;
    public GameObject camera;

    void OnCollisionEnter2D(Collision2D other)

    {
        chicken.GetComponent<chicken_behaviour>().descending = true;
        egg.GetComponent<egg_behaviour>().end = true;
        time.GetComponent<TimeCounter>().stopped = true;
        camera.GetComponent<camera_movement>().zoom = true;
    }
}
