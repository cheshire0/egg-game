using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class egg_behaviour : MonoBehaviour
{
    private float moveSpeed = 10f;
    public bool end = false;
    public int collected = 0;
    private Rigidbody2D rigidB;

    private void Start()
    {
        rigidB = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if(transform.position.y < -20) SceneManager.LoadScene(sceneName: "DeathScene");
        if (!end)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

            }

            else if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.P))
            {
                transform.position = new Vector3(11.75f, 60f, 1f);
            }
        }
        else
        {
            rigidB.velocity = Vector3.zero;
            if (PlayerPrefs.HasKey("hiCollected"))
            {
                if (collected > PlayerPrefs.GetInt("hiCollected"))
                {
                    PlayerPrefs.SetInt("hiCollected", collected);
                    PlayerPrefs.Save();
                }
            }
            else
            {
                 PlayerPrefs.SetInt("hiCollected", collected);
                 PlayerPrefs.Save();
            }
        }
    }
}
