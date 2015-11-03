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
using FileWatcherUtilities.Controller.Properties;

namespace FileWatcherUtilities.Controller
{
    /// <summary>
    /// Provides data for ProcessError event.
    /// </summary>
    public class ProcessErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the ProcessErrorEventArgs class.
        /// </summary>
        /// <param name="exception">Process exception.</param>
        /// <param name="daemonName">The name of the daemon which is running the process.</param>
        /// <param name="queuedProcesses">Number of queued processes on the controller.</param>
        /// <exception cref="ArgumentNullException">exception is null.</exception>
        /// <exception cref="ArgumentNullException">daemonName is null.</exception>
        /// <exception cref="ArgumentException">queued processes value cannot be less than zero.</exception>
        public ProcessErrorEventArgs(string daemonName,
                                     Exception exception,
                                     int queuedProcesses)
        {
            if (daemonName == null)
            {
                throw new ArgumentNullException("daemonName",
                                                Resources.ArgumentNullException);
            }
            if (exception == null)
            {
                throw new ArgumentNullException("exception",
                                                Resources.ArgumentNullException);
            }
            if (queuedProcesses < 0)
            {
                throw new ArgumentException(Resources.ArgumentExceptionValueCannotBeLessThanZero,
                                            "queuedProcesses");
            }
            _daemonName = daemonName;
            _exception = exception;
            _queuedProcesses = queuedProcesses;
        }

        /// <summary>
        /// Gets the process exception.
        /// </summary>
        public Exception Exception
        {
            get
            {
                return _exception;
            }
        }

        /// <summary>
        /// Gets the name of the daemon which is running the process.
        /// </summary>
        public string DaemonName
        {
            get
            {
                return _daemonName;
            }
        }

        /// <summary>
        /// Gets the number of queued processes on the controller.
        /// </summary>
        public int QueuedProcesses
        {
            get
            {
                return _queuedProcesses;
            }
        }

        /// <summary>
        /// Contains process exception.
        /// </summary>
        private readonly Exception _exception;

        /// <summary>
        /// Contains the name of the daemon which is running the process.
        /// </summary>
        private readonly string _daemonName;

        /// <summary>
        /// Number of queued processes on the controller.
        /// </summary>
        private readonly int _queuedProcesses;
    }
}