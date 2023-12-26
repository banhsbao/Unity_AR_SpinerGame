using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks{
    // Start is called before the first frame update
    [Header("Login UI")]
    public InputField playerNameInputField;
    #region UNITY Methods
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    #region UI Callback Methods
    public void onEnterGameButtonClicked(){
        string playerName = playerNameInputField.text;
        if(!string.IsNullOrEmpty(playerName)){
            if(!PhotonNetwork.IsConnected){
                PhotonNetwork.LocalPlayer.NickName = playerName;
                PhotonNetwork.ConnectUsingSettings();
            }
        }else{
            Debug.Log("Player name is invalid or empty");
        }
    }
    #endregion
    #region PHOTON Callback Methods
    public override void OnConnected(){
        Debug.Log("We connected to internet");
    }
    public override void OnConnectedToMaster(){
        Debug.Log(PhotonNetwork.LocalPlayer.NickName + "is connect to Photon Server");
    }
    #endregion
}
