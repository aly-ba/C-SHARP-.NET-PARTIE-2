using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AquosCommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        public string Command { get; private set;  }
        public string Parameter { get; private set; }

        private AquosCommand(string command, string parameters = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentException("command");
            }

            command = command.Trim();

            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            Command = command;
            Parameter = parameters.PadRight(ParamMaxLength);


        }

        public AquosCommand(string command, int value) : this(command, Convert.ToString(value))
        {
            
        }

        //public AquosCommand(string command, PowerSetting setting)
        //    : this(command, (int)setting)
        //{

        //}


        /// <summary>
        /// Factory Method 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AquosCommand Volume(int value)
        {
            return new AquosCommand("VOLM", Convert.ToString(value));
        }

        public static AquosCommand Power(PowerSetting setting)
        {
            return new AquosCommand("POWR", Convert.ToString((int) setting));
        }


        public  override string ToString()
            {
                return string.Format("{0} {1}", Command, Parameter);

            }
        
        
    }
}
