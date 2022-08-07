using UnityEngine;
public class CustomSwitch : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Switch _switch;
    [SerializeField] private GameObject Player;
    public void SwitchSound()
    {
        _switch.SetValue(Player);
    }
    
}
