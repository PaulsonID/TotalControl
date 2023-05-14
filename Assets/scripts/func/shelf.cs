using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    private InteractStatus leftDoor;
    private InteractStatus rightDoor;

    private bool isOpenLeftDoor = false;
    private bool isOpenRightDoor = false;

    private Animation _animation;

    private string animationOpenLeftDoor = "left_door|open";
    private string animationCloseLeftDoor = "left_door|close";
    private string animationOpenRightDoor = "right_door|open";
    private string animationCloseRightDoor = "right_door|close";


    private void Start()
    {
        leftDoor = transform.GetChild(0).GetComponent<InteractStatus>();
        rightDoor = transform.GetChild(1).GetComponent<InteractStatus>();

        _animation = GetComponent<Animation>();
    }

    private void Update() => MoveDoors();

    private void MoveDoors()
    {
        if (!_animation.isPlaying)
        {
            string animationDoor = ""; //dgfgfbfdghb

            if (leftDoor.GetStatusInteractive() && !isOpenLeftDoor)
            {
                animationDoor = animationOpenLeftDoor;
                isOpenLeftDoor = true;
                leftDoor.SetStatusInteractive(false);
            }
            else if (leftDoor.GetStatusInteractive() && isOpenLeftDoor)
            {
                animationDoor = animationCloseLeftDoor;
                isOpenLeftDoor = false;
                leftDoor.SetStatusInteractive(false);
            }
            if (rightDoor.GetStatusInteractive() && !isOpenRightDoor)
            {
                animationDoor = animationOpenRightDoor;
                isOpenRightDoor = true;
                rightDoor.SetStatusInteractive(false);
            }
            else if (rightDoor.GetStatusInteractive() && isOpenRightDoor)
            {
                animationDoor = animationCloseRightDoor;
                isOpenRightDoor = false;
                rightDoor.SetStatusInteractive(false);
            }

            if (animationDoor != "") PlayAnimation(animationDoor);
        }
    }

    private void PlayAnimation(string animationName) => _animation.Play(animationName);
}
