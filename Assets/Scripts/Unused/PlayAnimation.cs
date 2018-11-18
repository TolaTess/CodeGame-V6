using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    string ClipIndexToName(int index)
    {
        AnimationClip clip = GetClipByIndex(index);
        if (clip == null)
            return null;
        return clip.name;
    }

    AnimationClip GetClipByIndex(int index)
    {
        string[] ClipNames = { "StepForward", "StepBackward", "ShortThrow", "LongThrow", "BackwardThrow", "SoftThrow", "Bull", "Hurt" };
        Animation animation = GetComponent<Animation>();
        return animation[ClipNames[index]].clip;
    }
}