﻿using RetroBox.API.Update;

namespace RetroBox.Manager.Models
{
    internal record DownloadTask(Release Release, string Target);
}