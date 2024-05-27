using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera_movement : MonoBehaviour
{
    public Transform player;
    public Camera mainCamera;
    public Vector3 offset;

    public bool zoom = false;
    private float zoomOutFOV = 90f;  // Desired field of view to zoom out to
    public float zoomSpeed = 2f;    // Speed at which the camera zooms out

    void Update()
    {
        // Zoom out over time
        if (zoom && mainCamera.fieldOfView < zoomOutFOV)
        {
            Debug.Log("INSIDE camera fov: " + mainCamera.fieldOfView);
            mainCamera.fieldOfView += zoomSpeed * Time.deltaTime;
        }
        else if(mainCamera.fieldOfView>=zoomOutFOV) SceneManager.LoadScene(sceneName: "WinScene");
        else transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
