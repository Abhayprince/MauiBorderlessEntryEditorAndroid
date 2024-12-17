﻿using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiBorderlessEntryEditorAndroid.Controls;
public class BorderlessEditor : Editor
{
    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        SetBorderlessBackground();
    }

    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == nameof(BackgroundColor))
        {
            SetBorderlessBackground();
        }
    }

    private void SetBorderlessBackground()
    {
#if ANDROID

        if (Handler is IEditorHandler entryHandler)
        {
            if (BackgroundColor == null)
            {
                entryHandler.PlatformView.BackgroundTintList =
                            Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            }
            else
            {
                entryHandler.PlatformView.BackgroundTintList =
                            Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
            }
        }
#endif
    }
}
