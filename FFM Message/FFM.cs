using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFM_Message
{
    public class FFM
    {
        private string messageIdentifier;
        private string flightIdentifier;

        private int dayOfOperation;
        private string registration;
        private string aircraftType;
        private int part;
        private Boolean final;


        public int Part
        {
            get
            {
                return part;
            }

            set
            {
                part = value;
            }
        }
    }
}
