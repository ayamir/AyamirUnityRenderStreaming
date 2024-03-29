﻿using System;                               //Action

namespace Unity.RenderStreaming.Editor {

class RemoveRequestInfo{
    internal string PackageName;
    internal Action OnSuccessAction;
    internal Action OnFailAction;

    internal RemoveRequestInfo(string packageName,
        Action onSuccess, Action onFail)
    {
        PackageName = packageName;
        OnSuccessAction = onSuccess;
        OnFailAction = onFail;
    }
}

} //namespace Unity.RenderStreaming.Editor
