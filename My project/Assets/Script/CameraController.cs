using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("玩家物件")]
    public GameObject player;

    [Header("相對位移")]
    public Vector3 offest;
    // Start is called before the first frame update
    void Start()
    {
        offest = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
