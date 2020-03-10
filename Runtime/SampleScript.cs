using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Nara.SamplePackage
{
    public static class SampleScript
    {
#if UNITY_EDITOR
        [MenuItem("Sample script/Run")]
#endif
        public static void Run()
        {
            Debug.Log("Running sample script...");
        }
    }
}