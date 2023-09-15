using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSetBool : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;
    [SerializeField]
    private string _boolName;

    public void SetBool(bool boolean)
    {
        _anim.SetBool(_boolName, boolean);
    }
}
