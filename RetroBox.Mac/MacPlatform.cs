﻿using System;
using RetroBox.API.Xplat;

namespace RetroBox.Mac
{
    public sealed class MacPlatform : IPlatform
    {
        public IPlatFolder Folders { get; } = new MacFolders();

        public IPlatExecutable Executables => throw new InvalidOperationException();
    }
}