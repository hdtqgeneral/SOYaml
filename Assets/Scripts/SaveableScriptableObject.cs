using UnityEngine;
using YamlDotNet.Serialization;

[CreateAssetMenu(fileName = "New SaveableScriptableObject", menuName = "SaveableScriptableObject")]
public class SaveableScriptableObject : ScriptableObject
{
    public virtual void Save()
    {
        Debug.LogError("Save method not implemented.");
    }
}

public class SaveableScriptableObject<T> : SaveableScriptableObject where T : struct
{
    public string Name;

    public T Data;

    public override void Save()
    {
        if (string.IsNullOrEmpty(Name))
        {
            Debug.LogError("Name is null or empty. Cannot save data.");
            return;
        }

        string directory = Application.streamingAssetsPath;
        if (!System.IO.Directory.Exists(directory))
        {
            System.IO.Directory.CreateDirectory(directory);
        }

        string path = $"{directory}/{Name}.yaml";
        string yaml = new SerializerBuilder().Build().Serialize(Data);

        UnityEngine.Debug.Log($"Saving data to {path}");
        UnityEngine.Debug.Log(yaml);

        System.IO.File.WriteAllText(path, yaml);
    }
}
