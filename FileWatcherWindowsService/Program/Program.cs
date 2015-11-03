﻿/******************************************************************************
*    File Watcher Utilities / File Watcher Windows Service
*    Copyright (c) 2006-2013 Jussi Hiltunen
*
*    This program is free software; you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation; either version 2 of the License, or
*    (at your option) any later version.
*
*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.
*
*    You should have received a copy of the GNU General Public License
*    along with this program; if not, write to the Free Software
*    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
******************************************************************************/

using System;
using System.ServiceProcess;
using System.Security.Permissions;

[assembly: CLSCompliant(true)]

namespace FileWatcherUtilities.FileWatcherWindowsService
{
    /// <summary>
    /// Main class of the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        static void Main()
        {
            // Run service.
            ServiceBase.Run(new ServiceBase[] { new FileWatcherUtilitiesWindowsService() }); 
        }
    }
}