using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShot : MonoBehaviour
{
    public bool Cold = false;
    public GameObject SpawnCartridge;
    public float DelayAttack = 1.0f;

    private WeaponData _weaponData;
    private WeaponAudioProcess _weaponAudioProcess;
    
    private bool _isAttack = true;

    private void Start()
    {
        _weaponData = GetComponent<WeaponData>();
        _weaponAudioProcess = GetComponent<WeaponAudioProcess>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public bool Attack()
    {
        if (!_isAttack)
            return false;
        
        if (Cold)
        {
            Punch();
        }
        else
        {
            return Shot();
        }
        
        return true;
    }

    public bool Shot()
    {
        if (_weaponData.SpendCartridge())
        {
            Instantiate(_weaponData.CartridgePrefab, SpawnCartridge.transform.position, SpawnCartridge.transform.rotation);
            _isAttack = false;
            Invoke("OnShooting", DelayAttack);
            _weaponAudioProcess.Attack();
        }
        else
        {
            return false;
        }

        return true;
    }

    void OnShooting()
    {
        _isAttack = true;
    }

    void Punch()
    {
        Instantiate(_weaponData.CartridgePrefab, SpawnCartridge.transform.position, SpawnCartridge.transform.rotation);
        _weaponAudioProcess.Attack();
    }
}
