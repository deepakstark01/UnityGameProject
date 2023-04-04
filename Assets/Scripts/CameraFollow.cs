using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float speed;
    private float cPosX;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
