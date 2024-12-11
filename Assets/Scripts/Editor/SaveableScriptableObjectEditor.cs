using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(SaveableScriptableObject), true)]
public class SaveableScriptableObjectEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        // Create a default inspector
        var defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
        root.Add(defaultInspector);

        // Create a save button
        var saveButton = new Button(() => Save((SaveableScriptableObject)target))
        {
            text = "Save"
        };
        root.Add(saveButton);

        // Create a load button
        var loadButton = new Button(() => Load((SaveableScriptableObject)target))
        {
            text = "Load"
        };
        root.Add(loadButton);

        return root;
    }

    private void Save(SaveableScriptableObject scriptableObject)
    {
        // Implement your save logic here
        scriptableObject.Save();
    }

    private void Load(SaveableScriptableObject scriptableObject)
    {
        // Implement your load logic here
        scriptableObject.Load();
    }
}
