
using UnityEngine;
using UnityEditor;
 
public class DeselectAll : ScriptableObject
{
    [MenuItem ("Custom/Deselect All _a")]
    static void DoDeselect()
    {
        Selection.objects = new UnityEngine.Object[0];
    }
}
