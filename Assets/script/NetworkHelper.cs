using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Networking;

public class NetworkHelper : MonoBehaviour
{
    public NetworkManager networkManager;

    public void StartClient()
    {
        networkManager.StartClient();
    }

    public void StartHost()
    {
        networkManager.StartHost();
    }

    public void StartServer()
    {
        networkManager.StartServer();
    }


}