using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSetBool : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;
    [SerializeField]
    private string _boolName;

    private bool _enabled=false;

    public void SetBool(bool boolean)
    {
        _anim.SetBool(_boolName, boolean);
    }

    public void ToggleSwitch()
    {
        _enabled = !_enabled;
        _anim.SetBool(_boolName, _enabled);

    }
}
