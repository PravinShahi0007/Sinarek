namespace NB
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptBotolKotor.
    /// </summary>
    public partial class rptBotolKotor : Telerik.Reporting.Report
    {
        public rptBotolKotor()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public static int CalculateDIV(int Data)
        {
            int  div = 0
                , rem = 0;
            div = Math.DivRem(Data, 16, out rem);
            return div;
        }
        public static int CalculateREM(int Data)
        {
            int div = 0 
                , rem = 0;
            div = Math.DivRem(Data, 16, out rem);
            return rem;
        }
    }
}