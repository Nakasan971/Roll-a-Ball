﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour {

    private void OnCollisionEnter(Collision hit){
        if(hit.gameObject.CompareTag("Player")){

            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(sceneIndex);

        }
    }
}
