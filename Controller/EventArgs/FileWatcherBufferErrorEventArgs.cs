/******************************************************************************
*    File Watcher Utilities / File Watcher Controller
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
using System.IO;
using FileWatcherUtilities.Controller.Properties;

namespace FileWatcherUtilities.Controller
{
    /// <summary>
    /// Provides data for FileWatcherBufferError event.
    /// </summary>
    public class FileWatcherBufferErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the FileWatcherBufferErrorEventArgs class.
        /// </summary>
        /// <param name="daemonName">Daemon name of the file watcher.</param>
        /// <param name="e">ErrorEventArgs.</param>
        /// <exception cref="ArgumentNullException">e is null.</exception>
        /// <exception cref="ArgumentNullException">daemonName is null.</exception>
        public FileWatcherBufferErrorEventArgs(string daemonName,
                                               ErrorEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e",
                                                Resources.ArgumentNullException);
            }
            if (daemonName == null)
            {
                throw new ArgumentNullException("daemonName",
                                                Resources.ArgumentNullException);
            }
            _daemonName = daemonName;
            _errorEventArgs = e;
        }

        /// <summary>
        /// Gets the daemon name.
        /// </summary>
        public string DaemonName
        {
            get
            {
                return _daemonName;
            }
        }

        /// <summary>
        /// Gets the error event args.
        /// </summary>
        public ErrorEventArgs ErrorEventArgs
        {
            get
            {
                return _errorEventArgs;
            }
        }

        /// <summary>
        /// Gets the date and time of the buffer error.
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
        }

        /// <summary>
        /// Contains daemon name.
        /// </summary>
        private readonly string _daemonName;

        /// <summary>
        /// Contains error event args.
        /// </summary>
        private readonly ErrorEventArgs _errorEventArgs;

        /// <summary>
        /// Contains the date and time of the buffer error.
        /// </summary>
        private readonly DateTime _dateTime = DateTime.Now;
    }
}