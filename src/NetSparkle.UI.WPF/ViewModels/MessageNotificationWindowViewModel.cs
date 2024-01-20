﻿using System;
using System.Collections.Generic;
using System.Text;
using NetSparkleUpdater.UI.WPF.Helpers;

namespace NetSparkleUpdater.UI.WPF.ViewModels
{
    /// <summary>
    /// A view model for showing a single message to the user
    /// </summary>
    public class MessageNotificationWindowViewModel : ChangeNotifier
    {
        private string _message;

        /// <summary>
        /// Initialize the view model with an empty string for its message
        /// </summary>
        public MessageNotificationWindowViewModel()
        {
            Message = "";
        }

        /// <summary>
        /// Initialize the view model with the given message
        /// </summary>
        /// <param name="message">the message to show the user</param>
        public MessageNotificationWindowViewModel(string message)
        {
            Message = message;
        }

        /// <summary>
        /// The message to show to the user
        /// </summary>
        public string Message
        {
            get => _message;
            set { _message = value; NotifyPropertyChanged(); }
        }
    }
}
