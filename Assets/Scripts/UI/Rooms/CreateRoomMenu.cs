using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] Text _roomName;

    public void OnClick_CreateRoom()
    {

        if (!PhotonNetwork.IsConnected)
            return;

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
    }
    public override void OnCreatedRoom() 
    {
       Debug.Log("Created room successfully");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room creation fallied " + message);
    }
}
