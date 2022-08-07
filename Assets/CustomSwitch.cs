using UnityEngine;
public class CustomSwitch : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Switch _switch;

    public void SwitchSound()
    {
        _switch.SetValue(gameObject);
    }
    
}
