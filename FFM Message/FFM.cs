using System;

namespace FFM_Message
{
    public class FFM
    {
        private string messageIdentifier;
        private string flightIdentifier;
        private int messageSequenceNumber;

        private int dayOfOperation;
        private string monthOfOperation;
        private string timeOfScheduledDeparture;
        private string registration;
        private string aircraftType;
        private int part;
        private Boolean final;
        private string destrination;
        private string airport;
        private string container;
        private string uldCode;
        private string load;
        private string airlineAWBIdentification;
        private string awbSerialNumber;
        private string awbOrigin;
        private string awbDestination;
        private string origin;
        private string destination;
        private string shipmentDescriptionCode;
        private string pieces;
        private string weightCode;
        private string weight;
        private string manifestDescription;
        private string specialHandlingCode;
        private string goods;
        private string volumeCode;
        private string volume;

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

        public string MessageIdentifier
        {
            get
            {
                return messageIdentifier;
            }

            set
            {
                messageIdentifier = value;
            }
        }

        public string FlightIdentifier
        {
            get
            {
                return flightIdentifier;
            }

            set
            {
                flightIdentifier = value;
            }
        }

        public int DayOfOperation
        {
            get
            {
                return dayOfOperation;
            }

            set
            {
                dayOfOperation = value;
            }
        }

        public string Registration
        {
            get
            {
                return registration;
            }

            set
            {
                registration = value;
            }
        }

        public string AircraftType
        {
            get
            {
                return aircraftType;
            }

            set
            {
                aircraftType = value;
            }
        }

        public bool Final
        {
            get
            {
                return final;
            }

            set
            {
                final = value;
            }
        }

        public string Destrination
        {
            get
            {
                return destrination;
            }

            set
            {
                destrination = value;
            }
        }

        public string Airport
        {
            get
            {
                return airport;
            }

            set
            {
                airport = value;
            }
        }

        public string Container
        {
            get
            {
                return container;
            }

            set
            {
                container = value;
            }
        }

        public string UldCode
        {
            get
            {
                return uldCode;
            }

            set
            {
                uldCode = value;
            }
        }

        public string Load
        {
            get
            {
                return load;
            }

            set
            {
                load = value;
            }
        }

        public string AwbSerialNumber
        {
            get
            {
                return awbSerialNumber;
            }

            set
            {
                awbSerialNumber = value;
            }
        }

        public string Origin
        {
            get
            {
                return origin;
            }

            set
            {
                origin = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public string ShipmentDescriptionCode
        {
            get
            {
                return shipmentDescriptionCode;
            }

            set
            {
                shipmentDescriptionCode = value;
            }
        }

        public string Pieces
        {
            get
            {
                return pieces;
            }

            set
            {
                pieces = value;
            }
        }

        public string WeightCode
        {
            get
            {
                return weightCode;
            }

            set
            {
                weightCode = value;
            }
        }

        public string Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string ManifestDescription
        {
            get
            {
                return manifestDescription;
            }

            set
            {
                manifestDescription = value;
            }
        }

        public string SpecialHandlingCode
        {
            get
            {
                return specialHandlingCode;
            }

            set
            {
                specialHandlingCode = value;
            }
        }

        public string Goods
        {
            get
            {
                return goods;
            }

            set
            {
                goods = value;
            }
        }

        public string VolumeCode
        {
            get
            {
                return volumeCode;
            }

            set
            {
                volumeCode = value;
            }
        }

        public string Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public int MessageSequenceNumber
        {
            get
            {
                return messageSequenceNumber;
            }

            set
            {
                messageSequenceNumber = value;
            }
        }

        public string MonthOfOperation
        {
            get
            {
                return monthOfOperation;
            }

            set
            {
                monthOfOperation = value;
            }
        }

        public string TimeOfScheduledDeparture
        {
            get
            {
                return timeOfScheduledDeparture;
            }

            set
            {
                timeOfScheduledDeparture = value;
            }
        }

        public string AirlineAWBIdentification
        {
            get
            {
                return airlineAWBIdentification;
            }

            set
            {
                airlineAWBIdentification = value;
            }
        }

        public string AwbOrigin
        {
            get
            {
                return awbOrigin;
            }

            set
            {
                awbOrigin = value;
            }
        }

        public string AwbDestination
        {
            get
            {
                return awbDestination;
            }

            set
            {
                awbDestination = value;
            }
        }
    }
}
