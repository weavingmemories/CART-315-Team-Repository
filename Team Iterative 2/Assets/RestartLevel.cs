using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// If we end the game and want the player to restart, restarting the whole game will be key.
// using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public GameObject checkpoint;
    [SerializeField] private Transform player;
    public Checkpoint checkpointScript;

    private void Start()
    {
        checkpointScript = checkpoint.GetComponent<Checkpoint>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointScript = checkpoint.GetComponent<Checkpoint>();
            //   Scene scene;
            //   scene = SceneManager.GetActiveScene();
            //   SceneManager.LoadScene(scene.name);
            Debug.Log("Colliding with death");
            player.transform.position = checkpointScript.respawnPoint.transform.position;
            Physics.SyncTransforms();

        }
    }
}
