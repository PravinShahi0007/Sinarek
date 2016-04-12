using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmBotolTrans : Telerik.WinControls.UI.RadForm
    {
        public frmBotolTrans()
        {
            InitializeComponent();
            SetConditions();
        }

        private void frmBotolTrans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.producttrans' table. You can move, or remove it, as needed.
            this.producttransTableAdapter.Fill(this.sinarekDataSet.producttrans);
            //Calculate Saldo Awal and Saldo Akhir

            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("sum(quantity)");
            this.radGridView1.GroupDescriptors[0].Format = "Total : {2:#,###.00}";
            radGridView1.AutoExpandGroups = true;  
        }

        private void SetConditions()
        {
            //Keluar
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Salmon, applied to entire row", ConditionTypes.Equal, "0", "", true);
            c2.RowBackColor = Color.LightSalmon;
            radGridView1.Columns["category"].ConditionalFormattingObjectList.Add(c2); 
        }
    }
}
