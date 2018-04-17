using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRun : MonoBehaviour {

    private Animation animation;
    void Start()
    {
        animation = GetComponent<Animation>();//动画控制器  
        animation.Play("mixamo");//上来直接播放idle动画  
    }
    private void Update()
    {
        if (!animation.isPlaying)
        {
            animation.Play("mixamo");

        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 30, 100, 30), "mixamo"))
        {
            animation.Play("mixamo");
        }
    }
}
