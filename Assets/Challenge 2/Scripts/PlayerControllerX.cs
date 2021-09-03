using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawnDog = true;
    private float spawnInterval = 1.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & canSpawnDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            disableSpawn();
            Invoke("enableSpawn", spawnInterval);
        }
    }

    void disableSpawn(){
        canSpawnDog = false;
    }

    void enableSpawn(){
        canSpawnDog = true;
    }
}
