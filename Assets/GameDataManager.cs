using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameDataManager : MonoBehaviour {
    public static GameDataManager Instance;

    private Dictionary<int, GameObject> Players = new Dictionary<int, GameObject>();

    void Awake() {
        if ( Instance == null ) {
            Instance = this;
            DontDestroyOnLoad( gameObject );
        }
        else {
            Destroy( this );
        }
    }

    public void SetPlayer(int playerID, GameObject player) {
        if (!Players.ContainsKey(playerID)) {
            Players.Add( playerID, player );
        } else {
            Players[playerID] = player;
        }
    }

	public void AddPlayer(int playerID) {

    }

    public void RemovePlayer(int playerID ) {

    }

    public GameObject GetPlayer(int playerID) {
        return Players[playerID];
    }

    public void ResetPlayerData() {
        Players.Clear();
    }
}
