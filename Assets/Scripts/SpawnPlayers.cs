using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour{
    
    public GameObject playerPrefab;
    public Transform spawnPoint;

    private void Start(){
        SpawnPlayer();
    }

    void SpawnPlayer(){
        // Spawn Player
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);
    }
}
