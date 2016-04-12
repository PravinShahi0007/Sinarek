using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB
{
    static class cValidation
    {
        #region COMMON

        #endregion
        #region DATETIME
        internal static bool ValidDate(string DateString)
        {
            bool bValid = false;
            try
            {
                bValid = ValidDate(DateString, "01-01-2000", "01-01-2100");
            }
            catch (Exception ex)
            {

            }
            return bValid;
        }
        internal static bool ValidDate(string DateString, DateTime MinDate, DateTime MaxDate)
        {
            bool bValid = false;
            try
            {
                DateTime dtVal = DateTime.Parse(DateString);
                bValid = ValidDate(dtVal, MinDate, MaxDate);
            }
            catch (Exception ex)
            {

            }
            return bValid;
        }
        internal static bool ValidDate(string DateString,string MinDate,string MaxDate)
        {
            bool bValid = false;
            try
            {
                DateTime dtVal = DateTime.Parse(DateString);
                DateTime dtMin = DateTime.Parse(MinDate);
                DateTime dtMax = DateTime.Parse(MaxDate);
                bValid = ValidDate(dtVal, dtMin, dtMax);
            }
            catch (Exception ex)
            {
            }
            return bValid;
        }
        internal static bool ValidDate(DateTime DateString, DateTime MinDate, DateTime MaxDate)
        {
            bool bValid = false;
            if ((DateString >= MinDate) && (DateString <= MaxDate))
            {
                bValid = true;
            }
            return bValid;
        }
        #endregion

        #region INTEGER
        #endregion

        #region STRING
        #endregion
    }
}
