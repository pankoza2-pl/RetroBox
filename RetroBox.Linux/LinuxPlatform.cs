﻿using RetroBox.API.Xplat;

namespace RetroBox.Linux
{
    public sealed class LinuxPlatform : IPlatform
    {
        public IPlatFolder Folders { get; } = new LinuxFolders();

        public IPlatExecutable Executables { get; } = new LinuxExecutables();
    }
}