using UnityEngine;

public class LigthRoomController : InteractStatus
{

    [SerializeField] private bool stateLamp = true;

    [SerializeField] private LampRoom lampRoom;

    private SwitchLight switcher;

    private AudioSource _audioSource;


    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        switcher = transform.GetChild(1).GetComponent<SwitchLight>();
    }

    private void Update() => SwitchLight();

    private void SwitchLight()
    {
        if (GetStatusInteractive())
        {
            _audioSource.Play(0);

            stateLamp = !stateLamp;

            switcher.RotateSwitch(stateLamp);
            lampRoom.SetActiveLight(stateLamp);
            SetStatusInteractive(false);
        }
    }
}
