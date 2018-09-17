// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Windows;
using System.Windows.Controls;

namespace SnipInsight.Controls.Ariadne
{
    public class AriProgressBar : ProgressBar
    {
        static AriProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AriProgressBar), new FrameworkPropertyMetadata(typeof(AriProgressBar)));
        }
    }
}
