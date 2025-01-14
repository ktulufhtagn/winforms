﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using static Interop;

namespace System.Windows.Forms.Automation;

internal abstract class UiaTextProvider2 : UiaTextProvider, UiaCore.ITextProvider2
{
    public abstract UiaCore.ITextRangeProvider? GetCaretRange(out BOOL isActive);

    public abstract UiaCore.ITextRangeProvider? RangeFromAnnotation(UiaCore.IRawElementProviderSimple annotationElement);
}
