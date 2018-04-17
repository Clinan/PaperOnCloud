using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dance : MonoBehaviour {

    private Animation animation;
    void Start()
    {
         animation = GetComponent<Animation>();//动画控制器  
        animation.Play("dance");//上来直接播放idle动画  
    }
    private void Update()
    {
        if (!animation.isPlaying)
        {
            animation.Play("dance");

        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 30), "跳舞"))
        {
            animation.Play("dance");
        }
    }
}
