﻿using System;

namespace ZzukBot.Helpers.IrcDotNet
{
    // Indicates that method processes message for some protocol.
    internal class MessageProcessorAttribute : Attribute
    {
        public MessageProcessorAttribute(string commandName)
        {
            this.CommandName = commandName;
        }

        public string CommandName
        {
            get;
            private set;
        }
    }
}
