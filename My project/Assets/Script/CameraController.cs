using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("���a����")]
    public GameObject player;

    [Header("�۹�첾")]
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
