﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows.Win32
{
    internal static partial class PInvoke
    {
        public unsafe static BOOL RedrawWindow<T>(T hWnd, RECT* lprcUpdate, HRGN hrgnUpdate, REDRAW_WINDOW_FLAGS flags)
            where T : IHandle<HWND>
        {
            BOOL result = RedrawWindow(hWnd.Handle, lprcUpdate, hrgnUpdate, flags);
            GC.KeepAlive(hWnd.Wrapper);
            return result;
        }
    }
}
