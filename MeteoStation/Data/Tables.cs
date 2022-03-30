using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MeteoStation.Data
{
    internal class Tables
    {
        internal static DataTable MeasureTable { get; } = MakeMeasureTable();
        internal static DataTable AlarmTable { get; } = MakeAlarmTable();

        //Créé la table des mesures avec les colones appropriées
        private static DataTable MakeMeasureTable()
        {
            DataTable dt = new DataTable();
            string[] columnNames = { "ID", "Config", "Type", "Data", "Last update", "Alarm" };

            foreach (string name in columnNames)
                dt.Columns.Add(name);

            return dt;
        }

        //Créé la table des alarmes avec les colones appropriées
        private static DataTable MakeAlarmTable()
        {
            return null;
        }
    }
}
