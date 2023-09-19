using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class CabinetClose : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _moveBack = 0f;
    void Start()
    {
        Vector3 temp = transform.localPosition;
        temp.z -= _moveBack;
        transform.localPosition = temp;
        Destroy(this);
    }
}
