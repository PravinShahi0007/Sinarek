using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.Runtime;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using NB;
namespace Manager
{
    public partial class sfrmManageMenu : Telerik.WinControls.UI.ShapedForm
    {
        public sfrmManageMenu()
        {
            InitializeComponent();
            Assembly a = Assembly.Load("NB");
            foreach (Type frm in a.GetTypes())
            {
                if (frm.BaseType.Name == "RadForm")
                {
                    radListControl1.Items.Add(frm.Name);
                }
            }
            radTreeView1.ExpandMode = ExpandMode.Multiple;
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sfrmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingermachDataSet.auth' table. You can move, or remove it, as needed.
            this.authTableAdapter.Fill(this.fingermachDataSet.auth);
        }

        private void sfrmMain_DragDrop(object sender, DragEventArgs e)
        {
            RadTreeNode node = (RadTreeNode)sender;            
            MessageBox.Show(node.Value.ToString() + " - " + node.Text);
        }

        private void btnMove_Click(object sender, EventArgs e)
        { 
            
            int iParent = int.Parse(radDropDownList1.SelectedValue.ToString());
            foreach (RadTreeNode node in radTreeView1.SelectedNodes)
            {  
                int iChild= int.Parse(node.Value.ToString());
                authTableAdapter.UpdateMenu(iParent, iChild);
                //MessageBox.Show(iChild.ToString() + " - " + node.Text + " - " + iParent.ToString());
            }

            RefreshMenu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.authTableAdapter.AddMenu(txtGroupName.Text, null, 0);
            RefreshMenu();
        }

        private void RefreshMenu()
        {
            this.fingermachDataSet.auth.Clear();
            this.authTableAdapter.Fill(this.fingermachDataSet.auth);
            radTreeView1.Refresh();
            radDropDownList1.Rebind();

            //radTreeView1.ExpandAll();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            foreach (RadListDataItem item in radListControl1.SelectedItems)
            {
                this.authTableAdapter.AddMenu(item.Text, item.Text, 0);
            }
            RefreshMenu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (RadTreeNode node in radTreeView1.SelectedNodes)
            {
                this.authTableAdapter.DeleteMenu(int.Parse(node.Value.ToString()));
            }
            RefreshMenu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            this.authTableAdapter.UpdateName(txtMenuName.Text, int.Parse(radTreeView1.SelectedNode.Value.ToString()));
            RefreshMenu();
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            txtMenuName.ResetText();            
            //txtMenuName.NullText = radTreeView1.SelectedNode.Text;
            try
            {
                txtMenuName.NullText = e.Node.Text;
            }
            catch (Exception ex)
            {
                txtMenuName.NullText = "";
            }
            finally
            {
            }

            if (e.Node.Index == 0)
            {
                btnUp.Enabled = false;
            }
            else
            {
                btnUp.Enabled = true;
            }
            if (e.Node.Parent != null)
            {
                if (e.Node.Index == (e.Node.Parent.GetNodeCount(false) - 1))
                {
                    btnDown.Enabled = false;
                }
                else
                {
                    btnDown.Enabled = true;
                }
            }
            else
            {
                if (e.Node.Index == (e.TreeView.Nodes.Count - 1))
                {
                    btnDown.Enabled = false;
                }
                else
                {
                    btnDown.Enabled = true;
                }
            }
        }

        private void UpdatePosition(bool bUp)
        {
            int selectedOrder = -1
                , newOrder = -1;
            string selectedNodeName = radTreeView1.SelectedNode.Name;
            RadTreeNode selectedNode;
            selectedOrder = radTreeView1.SelectedNode.Index;
            if(bUp)
            {
                newOrder = selectedOrder - 1;
            }
            else
            {
                newOrder = selectedOrder + 1;
            }

            if (radTreeView1.SelectedNodes.Count > 1)
            {
                MessageBox.Show("Select Only One Node to move", "SMS Manager - Error Notification");
            }
            else
            {
                RadTreeNodeCollection nodes = null;
                if (radTreeView1.SelectedNode.Parent == null)
                {
                    nodes = radTreeView1.Nodes;
                }
                else
                {
                    nodes = radTreeView1.SelectedNode.Parent.Nodes; 
                }
                nodes.Move(selectedOrder, newOrder);                
                foreach (RadTreeNode node in nodes)
                {
                    //update order
                    
                    authTableAdapter.UpdateOrderNum(short.Parse(node.Index.ToString())
                                                        , int.Parse(node.Value.ToString()));
                   
                }
                authTableAdapter.Fill(this.fingermachDataSet.auth); 
                //make sure selection is still on the node
                selectedNode = radTreeView1.GetNodeByName(selectedNodeName);
                radTreeView1.SelectedNode = selectedNode;
                selectedNode.Selected = true;
                if (selectedNode.Parent != null)
                {
                    radTreeView1.SelectedNode.Parent.Expand();
                }
            }

        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            UpdatePosition(true);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            UpdatePosition(false);
        }

    }
}
