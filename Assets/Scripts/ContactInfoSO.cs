using UnityEngine;

[CreateAssetMenu(fileName = "New ContactInfo", menuName = "SaveableScriptableObject/ContactInfo")]
public class ContactInfoSO : SaveableScriptableObject<ContactData>
{
}


[System.Serializable]
public struct ContactData
{
    public string Phone;
    public string Address;
}