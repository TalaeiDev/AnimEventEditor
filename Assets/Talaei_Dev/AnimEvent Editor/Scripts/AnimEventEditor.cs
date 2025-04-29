using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

public class AnimEventEditor : EditorWindow
{
    private GameObject character;
    private AnimationClip animationClip;
    private float animationTime = 0f;

    private Animator characterAnimator;

    private string eventFunctionName = "EventFunction";
    private Object eventTargetObject = null;

    [MenuItem("TalaeiDev/AnimEvent Editor")]
    public static void ShowWindow()
    {
        GetWindow<AnimEventEditor>("AnimEvent Editor");
    }

    private void OnEnable()
    {
        EditorApplication.update += OnEditorUpdate;
    }

    private void OnDisable()
    {
        EditorApplication.update -= OnEditorUpdate;
    }

    private void OnGUI()
    {
        GUILayout.Label("AnimEvent Editor", EditorStyles.boldLabel);

        GameObject newCharacter = (GameObject)EditorGUILayout.ObjectField("Character", character, typeof(GameObject), true);
        if (newCharacter != character)
        {
            character = newCharacter;
            if (character != null)
            {
                characterAnimator = character.GetComponent<Animator>();
            }
        }

        animationClip = (AnimationClip)EditorGUILayout.ObjectField("Animation Clip", animationClip, typeof(AnimationClip), false);

        if (character == null || animationClip == null)
        {
            EditorGUILayout.HelpBox("Assign a character and an animation clip to preview.", MessageType.Info);
            return;
        }

        float newTime = EditorGUILayout.Slider("Time", animationTime, 0f, animationClip.length);
        if (!Mathf.Approximately(newTime, animationTime))
        {
            animationTime = newTime;
            SampleAnimation();
        }

        EditorGUILayout.Space();
        GUILayout.Label("Add Animation Event", EditorStyles.boldLabel);

        eventFunctionName = EditorGUILayout.TextField("Function Name", eventFunctionName);
        eventTargetObject = EditorGUILayout.ObjectField("Object Parameter (optional)", eventTargetObject, typeof(Object), true);

        if (GUILayout.Button("Add Event at Current Time"))
        {
            AddAnimationEvent(animationClip, animationTime, eventFunctionName, eventTargetObject);
        }
    }

    private void OnEditorUpdate()
    {
        if (character == null || animationClip == null) return;

        SampleAnimation();
    }

    private void SampleAnimation()
    {
        if (character == null || animationClip == null) return;
        if (!AnimationMode.InAnimationMode())
            AnimationMode.StartAnimationMode();

        AnimationMode.BeginSampling();
        AnimationMode.SampleAnimationClip(character, animationClip, animationTime);
        AnimationMode.EndSampling();

        SceneView.RepaintAll();
        EditorApplication.QueuePlayerLoopUpdate();
    }

    private void AddAnimationEvent(AnimationClip clip, float time, string functionName, Object targetObj)
    {
        if (clip == null || string.IsNullOrEmpty(functionName)) return;

        var events = AnimationUtility.GetAnimationEvents(clip);

        var newEvent = new AnimationEvent
        {
            time = time,
            functionName = functionName,
            objectReferenceParameter = targetObj
        };

        var updatedEvents = new AnimationEvent[events.Length + 1];
        for (int i = 0; i < events.Length; i++)
            updatedEvents[i] = events[i];

        updatedEvents[events.Length] = newEvent;
        AnimationUtility.SetAnimationEvents(clip, updatedEvents);

        Debug.Log($"Added AnimationEvent '{functionName}' at time {time:F2}s with object: {targetObj?.name ?? "None"}");
    }
}
