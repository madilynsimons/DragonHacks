using UnityEngine;
using Oculus.Avatar;
using Oculus.Platform;
using Oculus.Platform.Models;
using System.Collections;

public class PlatformManager : MonoBehaviour
{
    void Awake()
    {
        Oculus.Platform.Core.Initialize();
        Oculus.Platform.Users.GetLoggedInUser().OnComplete(GetLoggedInUserCallback);
        Oculus.Platform.Request.RunCallbacks(); //avoids race condition with OvrAvatar.cs Start().
    }

    private void GetLoggedInUserCallback(Message<User> message)
    {
        if (!message.IsError)
        {
            OvrAvatar[] avatars = FindObjectsOfType(typeof(OvrAvatar)) as OvrAvatar[];
            foreach (OvrAvatar avatar in avatars)
            {
                avatar.oculusUserID = message.Data.ID;
            }
        }
    }
}