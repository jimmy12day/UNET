using UnityEngine;
using UnityEngine.Networking;


public class PlayerConnection : NetworkBehaviour
{
    [SerializeField]
    GameObject playerUnit;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer == false)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdSpawnPlayer();
        }

    }

    [Command]
    void CmdSpawnPlayer()
    {
        if (playerUnit == null)
            return;
        GameObject playerprefab = Instantiate(playerUnit);
        NetworkServer.Spawn(playerUnit);
    }
}
