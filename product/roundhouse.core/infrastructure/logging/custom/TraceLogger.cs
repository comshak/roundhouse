﻿using System.Diagnostics;

namespace roundhouse.infrastructure.logging.custom
{
    public class TraceLogger : Logger
    {
        private readonly bool debugging;

        public TraceLogger() : this(false) { }

        public TraceLogger(bool debugging)
        {
            this.debugging = debugging;
        }

        private void log_message(string message)
        {
            Trace.WriteLine(message);
        }

        public void log_a_debug_event_containing(string message, params object[] args)
        {
            if (debugging) log_message("[DEBUG]: " + string.Format(message, args));
        }

        public void log_an_info_event_containing(string message, params object[] args)
        {
            log_message("[INFO]: " + string.Format(message, args));
        }

        public void log_a_warning_event_containing(string message, params object[] args)
        {
            log_message("[WARN]: " + string.Format(message, args));
        }

        public void log_an_error_event_containing(string message, params object[] args)
        {
            log_message("[ERROR]: " + string.Format(message, args));
        }

        public void log_a_fatal_event_containing(string message, params object[] args)
        {
            log_message("[FATAL]: " + string.Format(message, args));
        }

        public object underlying_type
        {
            get { return new object(); }
        }
    }
}