using UnityEngine;

public class Camera : MonoBehaviour
{

    /// fonction qui permet de faire suivre la caméra au joueur
    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, -10f);
    }
}
