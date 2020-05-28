using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorIcons
{
    public partial class Form1 : Form
    {
        DatabaseIconsDataContext DC = new DatabaseIconsDataContext();

        public Form1()
        {
            InitializeComponent();

            LoadIconList();
        }

        private void LoadIconList(Icon selectedIcon = null)
        {
            comboBoxIconList.Items.Clear();
            comboBoxIconList.Items.Add(DC.Icons.ToArray());
            if(selectedIcon != null)
            {
                comboBoxIconList.SelectedItem = selectedIcon;
            }
        }

        private void comboBoxIconList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                textBoxIconName.Text = selectedIcon.Name;
                numericUpDownIconSize.Value = selectedIcon.Size;
            }
        }

        private void textBoxIconName_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                selectedIcon.Name = textBoxIconName.Text;
                DC.SubmitChanges();
                LoadIconList(selectedIcon);
            }
        }

        private void numericUpDownIconSize_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                selectedIcon.Size = (int) numericUpDownIconSize.Value;
                DC.SubmitChanges();
                LoadIconList(selectedIcon);
            }
        }
    }
}
