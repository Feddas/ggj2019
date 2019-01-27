using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TrialsTool
{
    public class HotKey : MonoBehaviour
    {
        public enum KeyAction
        {
            Exit,
            UnityEvent,
        }

        // TODO: array of keycodes. Then add "string context" and "bool IsEnabled"
        public KeyCode key = KeyCode.Escape;
        public KeyAction action = KeyAction.Exit;
        public UnityEvent onKey;

        void Start()
        {
        }

        void Update()
        {
            if (Input.GetKeyDown(key))
            {
                switch (action)
                {
                    case KeyAction.Exit:
                        Exit();
                        break;
                    case KeyAction.UnityEvent:
                        onKey.Invoke();
                        break;
                    default:
                        throw new Exception("HotKey.cs does not support " + action.ToString());
                }
            }
        }

        public void Exit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
        // Application.OpenURL(webplayerQuitURL);
#else
        Application.Quit();
#endif
        }
    }
}
