using UnityEngine;

public class WeaponData : MonoBehaviour
{
    public GameObject CartridgePrefab;
    public int CountCartridge = 0;

    public bool SpendCartridge()
    {
        if (CountCartridge <= 0)
        {
            return false;
        }

        CountCartridge--;

        return true;
    }
}
