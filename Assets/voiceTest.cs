using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Subsystems;
using UnityEngine;

public class voiceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the first running phrase recognition subsystem.
        var phraseRecognitionSubsystem = XRSubsystemHelpers.GetFirstRunningSubsystem<PhraseRecognitionSubsystem>();
        
        // If we found one...
        if (phraseRecognitionSubsystem != null)
        {
            // Register a phrase and its associated action with the subsystem
            phraseRecognitionSubsystem.CreateOrGetEventForPhrase("Test").AddListener(() => Debug.Log("Phrase recognized"));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
