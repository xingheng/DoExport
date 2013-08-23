using System;
using System.Collections.Generic;
using System.Collections;

namespace UTILITIES_HAN
{
    /// <summary>
    /// Collect a list of result in some processes.
    /// </summary>
    public class CollectResult
    {
        private string environment;
        public string Environment
        {
            set { environment = value; }
        }

        private string reason;
        public string Reason
        {
            set { reason = value; }
        }

        private Exception exception;
        public Exception Exception
        {
            set { exception = value; }
        }

        private ArrayList args;

        public CollectResult()
        {
            args = new ArrayList();
        }

        public void AddArgs(string key, object value)
        {
            KeyValuePair<string, object> item = new KeyValuePair<string, object>(key, value);
            args.Add(item);
        }

        public bool EmtryAllArgs()
        {
            args.Clear();
            return (args.Count == 0);
        }

        // Allow to append the new string value to member environment, but couldn't modify its value directly.
        public void AddEnvironmentNote(string newNote)
        {
            this.environment += newNote;
        }

        /// <summary>
        /// Format the collected results as a string, including exceptioin info, environment args, etc.
        /// </summary>
        /// <returns></returns>
        public string FormatResult()
        {
            string result = "";
            result += "Environment : " + (String.IsNullOrEmpty(environment) ? "Not Set." : environment);
            PublicMem.NewLine(ref result);
            result += "Reason : " + (String.IsNullOrEmpty(reason) ? "Not Set." : reason);
            PublicMem.NewLine(ref result);

            foreach (KeyValuePair<string, object> item in args)
            {
                result += item.Key + " : " + item.Value;
                PublicMem.NewLine(ref result);
            }

            result += FormatException(1);

            return result;
        }

        /// <summary>
        /// Format the exception info as a string.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public string FormatException(int level)
        {
            string result = "";
            if (exception != null)
            {
                int i = 0;
                while (i < level)
                {
                    switch (++i)
                    {
                        case 1:
                            result += "Info: " + exception.ToString();
                            break;
                        case 2:
                            result += "HResult: " + exception.HResult;
                            break;
                        case 3:
                            result += "Message: " + exception.Message;
                            break;
                        case 4:
                            result += "Source: " + exception.Source;
                            break;
                        case 5:
                            result += "StackTrace: " + exception.StackTrace;
                            break;
                        case 6:
                            result += "TargetSite: " + exception.TargetSite;
                            break;
                        case 7:
                            result += "Data: " + exception.Data.ToString();
                            break;
                        case 8:
                            result += "HelpLink: " + exception.HelpLink;
                            break;
                        default:
                            break;
                    }
                    PublicMem.NewLine(ref result);
                }
            }

            return result;
        }
    }
}
