﻿using System;
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
        internal static DataTable SendableTable { get; } = MakeSendableTable();

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
            DataTable dt = new DataTable();
            string[] columnNames = { "ID", "Crit. Min", "Warn. Min", "Status", "Warn. Max", "Crit. Max" };

            foreach (string name in columnNames)
                dt.Columns.Add(name);

            return dt;
        }

        //Créé la table des mesure pouvant être envoyées avec les colones appropriées
        private static DataTable MakeSendableTable()
        {
            DataTable dt = new DataTable();
            string[] columnNames = { "Serial", "ID", "Type" };

            foreach (string name in columnNames)
                dt.Columns.Add(name);

            return dt;
        }
    }
}
