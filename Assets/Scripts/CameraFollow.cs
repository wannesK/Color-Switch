using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void LateUpdate()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        if (player.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }
    }
}
