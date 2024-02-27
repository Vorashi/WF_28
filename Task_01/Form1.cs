using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemLoading_Click(object sender, EventArgs e)
        {
            int index = TabCont.SelectedIndex;
            switch (index)
            {
                case 0:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxJanuary.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxJanuary.Items.Add(line);
                        }
                    }
                    break;
                case 1:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxFebruary.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxFebruary.Items.Add(line);
                        }
                    }
                    break;
                case 2:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxMarch.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxMarch.Items.Add(line);
                        }
                    }
                    break;
                case 3:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxApril.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxApril.Items.Add(line);
                        }
                    }
                    break;
                case 4:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxMay.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxMay.Items.Add(line);
                        }
                    }
                    break;
                case 5:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxJune.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxJune.Items.Add(line);
                        }
                    }
                    break;
                case 6:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxJuly.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxJuly.Items.Add(line);
                        }
                    }
                    break;
                case 7:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxAugust.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxAugust.Items.Add(line);
                        }
                    }
                    break;
                case 8:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxSeptember.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxSeptember.Items.Add(line);
                        }
                    }
                    break;
                case 9:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxOctober.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxOctober.Items.Add(line);
                        }
                    }
                    break;
                case 10:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxNovember.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxNovember.Items.Add(line);
                        }
                    }
                    break;
                case 11:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LboxDecember.Items.Clear();
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            LboxDecember.Items.Add(line);
                        }
                    }
                break;
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            int index = TabCont.SelectedIndex;
                switch (index) 
                {
                    case 0:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxJanuary.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 1:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxFebruary.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 2:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxMarch.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 3:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxApril.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 4:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxMay.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 5:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxJune.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 6:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxJuly.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 7:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxAugust.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 8:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath)) 
                        {
                            foreach (var item in LboxSeptember.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 9:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxOctober.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 10:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxNovember.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                    case 11:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            foreach (var item in LboxDecember.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                    }
                    break;
                }
            MessageBox.Show("Сохранение завершено!");
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            string input = TbxInput.Text;
            int index = TabCont.SelectedIndex;
            switch (index) 
            {
                case 0:
                    LboxJanuary.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 1:
                    LboxFebruary.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 2:
                    LboxMarch.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 3:
                    LboxApril.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 4:
                    LboxMay.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 5:
                    LboxJune.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 6:
                    LboxJuly.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 7:
                    LboxAugust.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 8:
                    LboxSeptember.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 9:
                    LboxOctober.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 10:
                    LboxNovember.Items.Add(input);
                    TbxInput.Text = "";
                break;
                case 11:
                    LboxDecember.Items.Add(input);
                    TbxInput.Text = "";
                break;
            }
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            int index = TabCont.SelectedIndex;
            switch (index)
            {
                case 0:
                    LboxJanuary.Items.Remove(LboxJanuary.SelectedItem);
                break;
                case 1:
                    LboxFebruary.Items.Remove(LboxFebruary.SelectedItem);
                break;
                case 2:
                    LboxMarch.Items.Remove(LboxMarch.SelectedItem);
                break;
                case 3:
                    LboxApril.Items.Remove(LboxApril.SelectedItem);
                break;
                case 4:
                    LboxMay.Items.Remove(LboxMay.SelectedItems);
                break;
                case 5:
                    LboxJune.Items.Remove(LboxJune.SelectedItem);
                break;
                case 6:
                    LboxJuly.Items.Remove(LboxJuly.SelectedItem);
                break;
                case 7:
                    LboxAugust.Items.Remove(LboxAugust.SelectedItem);
                break;
                case 8:
                    LboxSeptember.Items.Remove(LboxSeptember.SelectedItem);
                break;
                case 9:
                    LboxOctober.Items.Remove(LboxOctober.SelectedItem);
                break;
                case 10:
                    LboxNovember.Items.Remove(LboxNovember.SelectedItem);
                break;
                case 11:
                    LboxDecember.Items.Remove(LboxDecember.SelectedItem);
                break;
            }
        }

        private void MenuItemChange_Click(object sender, EventArgs e)
        {
            string input = TbxInput.Text;
            int index = TabCont.SelectedIndex;
            int selectIndexTrue = -1;
            switch (index)
            {
                case 0:
                    selectIndexTrue = LboxJanuary.SelectedIndex;
                    LboxJanuary.Items[selectIndexTrue] = TbxInput.Text;
                    LboxJanuary.ClearSelected();
                break;
                case 1:
                    selectIndexTrue = LboxFebruary.SelectedIndex;
                    LboxFebruary.Items[selectIndexTrue] = TbxInput.Text;
                    LboxFebruary.ClearSelected();
                break;
                case 2:
                    selectIndexTrue = LboxMarch.SelectedIndex;
                    LboxMarch.Items[selectIndexTrue] = TbxInput.Text;
                    LboxMarch.ClearSelected();
                break;
                case 3:
                    selectIndexTrue = LboxApril.SelectedIndex;
                    LboxApril.Items[selectIndexTrue] = TbxInput.Text;
                    LboxApril.ClearSelected();
                break;
                case 4:
                    selectIndexTrue = LboxMay.SelectedIndex;
                    LboxMay.Items[selectIndexTrue] = TbxInput.Text;
                    LboxMay.ClearSelected();
                break;
                case 5:
                    selectIndexTrue = LboxJune.SelectedIndex;
                    LboxJune.Items[selectIndexTrue] = TbxInput.Text;
                    LboxJune.ClearSelected();
                break;
                case 6:
                    selectIndexTrue = LboxJuly.SelectedIndex;
                    LboxJuly.Items[selectIndexTrue] = TbxInput.Text;
                    LboxJuly.ClearSelected();
                break;
                case 7:
                    selectIndexTrue = LboxAugust.SelectedIndex;
                    LboxAugust.Items[selectIndexTrue] = TbxInput.Text;
                    LboxAugust.ClearSelected();
                break;
                case 8:
                    selectIndexTrue = LboxSeptember.SelectedIndex;
                    LboxSeptember.Items[selectIndexTrue] = TbxInput.Text;
                    LboxSeptember.ClearSelected();
                break;
                case 9:
                    selectIndexTrue = LboxOctober.SelectedIndex;
                    LboxOctober.Items[selectIndexTrue] = TbxInput.Text;
                    LboxOctober.ClearSelected();      
                break;
                case 10:
                    selectIndexTrue = LboxNovember.SelectedIndex;
                    LboxNovember.Items[selectIndexTrue] = TbxInput.Text;
                    LboxNovember.ClearSelected();
                break;
                case 11:
                    selectIndexTrue = LboxDecember.SelectedIndex;
                    LboxDecember.Items[selectIndexTrue] = TbxInput.Text;
                    LboxDecember.ClearSelected();
                break;
            }
        }
    }
}
