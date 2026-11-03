using UnityEngine;
// Unity's non-Legacy clips require an Animator on their sampling root in a standalone player.
// Preserve the recovered clip/bindings and explicit sampled time; add only the required host.
public static class Round1AnimationSampling
{
    public static void Sample(AnimationClip clip,GameObject root,float time)
    {
        if(!clip||!root)return;
        if(!clip.legacy&&!root.TryGetComponent<Animator>(out var animator))
        {
            animator=root.AddComponent<Animator>();
            animator.applyRootMotion=false;
            animator.cullingMode=AnimatorCullingMode.AlwaysAnimate;
        }
        clip.SampleAnimation(root,time);
    }
}
