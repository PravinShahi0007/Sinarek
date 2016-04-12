using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB
{
    static class cMigrate
    {
        internal static string Source
        {
            get { return cMigrate.source_; }
            set { cMigrate.source_ = value; }
        }
        private static string source_;

        internal static string Dest
        {
            get { return cMigrate.dest_; }
            set { cMigrate.dest_ = value; }
        }
        private static string dest_;

        internal static void migrateTable(string destTableName)
        {

        }
    }
}
