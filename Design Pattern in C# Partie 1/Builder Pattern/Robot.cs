using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Builder_Pattern
{
    public partial class Robot : UserControl
    {
        ///<summary>
        ///
        /// 
        ///
        /// </summary>
        public Dictionary<Peripheral, string>  Peripherals = new Dictionary<Peripheral, string>

        ///<summary>
        ///the core method uses to create different representations
        ///</summary>
        ///
        public void Create()
        {
            //Create new Computer
            _computer = new Bitmap(Images.Computer);
            foreach( Peripheral peripheral in Peripherals.Keys)
            {
                if (peripheral == Peripheral.Processor)
                    AssembleCPU(Peripherals[peripherals]);

                 if (peripheral == Peripheral.Monitor)
                    AssembleMonitor(Peripherals[peripheral]);

                 if (peripheral == Peripheral.Speakers)
                    AssembleSpeakers(Peripherals[peripherals]);

            }
        }

        AddToStore();

    }
}
