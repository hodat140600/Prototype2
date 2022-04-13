﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0.0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer >= 0.5f)
        {
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            if (timer >= 0.2f) timer = 0.0f;
        }
    }
}
