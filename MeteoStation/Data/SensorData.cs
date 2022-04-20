using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation.Data
{
    internal class SensorData
    {
        internal class Base
        {
            internal ushort serial; //ushort = UInt16 = 16 bits non signé
            internal byte id;
            internal byte type;
            internal ushort data;
            internal DateTime moment;

            internal Base(ushort serial, byte id, byte type, ushort data, DateTime moment)
            {
                this.serial = serial;
                this.id = id;
                this.type = type;
                this.data = data;
                this.moment = moment;
            }
        }

        internal class Measure : Base
        {
            internal int LowLimit; //int = Int32 = 32 bits signé
            internal int HighLimit;
            internal int ConvertedData;
            internal uint AlarmMaxPeriod; //uint = UInt32 = 32 bits non signé
            internal int WarningMin;         //User Alarm
            internal int CriticalMin;        //User Alarm
            internal int WarningMax;         //User Alarm
            internal int CriticalMax;         //User Alarm

            internal Measure() : base(0, 0, 0, 0, DateTime.Now)
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 10;
                WarningMin = 0;
                CriticalMin = 0;
                WarningMax = 0;
                CriticalMax = 0;
            }

            //vérifie si une mesure est configurées
            internal bool IsConfigured()
            {
                return LowLimit != HighLimit;
            }

            internal bool HasAlarms()
            {
                return IsConfigured() && WarningMin != WarningMax;
            }

            internal string GetStatus()
            {
                if (!HasAlarms()) return "No alarms";

                if (AlarmMaxPeriod > 0 && (DateTime.Now - moment).TotalSeconds > AlarmMaxPeriod) return "Obselete";

                if (ConvertedData > CriticalMax || ConvertedData < CriticalMin) return "Critical";
                if (ConvertedData > WarningMax || ConvertedData < WarningMin) return "Warning";

                return "Normal";
            }
        }

        internal class Alarm : Base
        {
            internal Alarm() : base(0, 0, 0, 0, DateTime.Now)
            {

            }
        }

        internal class MeasureType
        {
            internal string Name;
            internal string Unit;

            internal MeasureType(string name, string unit)
            {
                Name = name;
                Unit = unit;
            }
        }

        //Représente la configuration d'une mesure, sans être lié à une en particulier, sert a appliqué les configs prit de fichiers
        internal class MeasureConfig
        {
            internal int LowLimit = 0; 
            internal int HighLimit = 0;
            internal uint AlarmMaxPeriod = 10; 
            internal int WarningMin = 0;         //User Alarm
            internal int CriticalMin = 0;        //User Alarm
            internal int WarningMax = 0;         //User Alarm
            internal int CriticalMax = 0;         //User Alarm

            internal MeasureConfig()
            {

            }

            internal void ApplyConfig(Measure measure)
            {
                measure.LowLimit = LowLimit;
                measure.HighLimit = HighLimit;
                measure.AlarmMaxPeriod = AlarmMaxPeriod;
                measure.WarningMin = WarningMin;
                measure.CriticalMin = CriticalMin;
                measure.WarningMax = WarningMax;
                measure.CriticalMax = CriticalMax;
            }
        }
    }
}
