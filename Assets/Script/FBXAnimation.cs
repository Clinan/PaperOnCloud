using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBXAnimation : MonoBehaviour {

    private Animation animation;
    public string animationName;
    public float m_speed = 1.0f;
    void Start()
    {
        animation = GetComponent<Animation>();//动画控制器  
        animation.Play(animationName);//上来直接播放idle动画  

        foreach (AnimationState state in animation)
        {
            state.speed = m_speed;
        }

    }
    private void Update()
    {

        if (!animation.isPlaying)
        {
            animation.Play(animationName);

        }
    }
   
}
