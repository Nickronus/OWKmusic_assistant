using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWKmusic_assistant
{
    public partial class FormMain : Form
    {
        public int selectedNota;
        public int selectedLad;
        public int selectedCount;
        //public TableLayoutPanel panel;
        public FormMain()
        {
            InitializeComponent();
            LadTabelCreate();
            groupBox2.Font = new Font(label1.Font.FontFamily, 10f, label1.Font.Style);
            //panel = tableLayoutPanel2;
        }

        public int sequenceCount = 0;
        public int rowNumber = 0;
        public void LabelCreateColomnHead(string text, int colomn)
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            tableLayoutPanel1.Controls.Add(label, colomn, 0);
        }

        public void LabelCreateRowHead(string text, int row)
        { 
                Label label = new Label();
                label.Anchor = AnchorStyles.None;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = text;
                tableLayoutPanel1.Controls.Add(label, 0, row);
        }

        public void LabelCreateNots(int colomn, int row, int counter)
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            switch(counter)
            {
                case 1:
                    label.Text = "E";
                    break;
                case 2:
                    label.Text = "F";
                    break;
                case 3:
                    label.Text = "F#";
                    break;
                case 4:
                    label.Text = "G";
                    break;
                case 5:
                    label.Text = "G#";
                    break;
                case 6:
                    label.Text = "A";
                    break;
                case 7:
                    label.Text = "A#";
                    break;
                case 8:
                    label.Text = "H";
                    break;
                case 9:
                    label.Text = "C";
                    break;
                case 10:
                    label.Text = "C#";
                    break;
                case 11:
                    label.Text = "D";
                    break;
                case 12:
                    label.Text = "D#";
                    break;
            }
            tableLayoutPanel1.Controls.Add(label, colomn, row);
        }

        public void LadTabelCreate()
        {
            LabelCreateColomnHead("", 0);
            LabelCreateColomnHead("0", 1);
            LabelCreateColomnHead("I", 2);
            LabelCreateColomnHead("II", 3);
            LabelCreateColomnHead("III", 4);
            LabelCreateColomnHead("IV", 5);
            LabelCreateColomnHead("V", 6);
            LabelCreateColomnHead("VI", 7);
            LabelCreateColomnHead("VII", 8);
            LabelCreateColomnHead("VIII", 9);
            LabelCreateColomnHead("IX", 10);
            LabelCreateColomnHead("X", 11);
            LabelCreateColomnHead("XI", 12);
            LabelCreateColomnHead("XII", 13);
            LabelCreateColomnHead("XIII", 14);
            LabelCreateColomnHead("XIV", 15);
            LabelCreateColomnHead("XV", 16);
            LabelCreateColomnHead("XVI", 17);
            LabelCreateColomnHead("XVII", 18);
            LabelCreateColomnHead("XVIII", 19);

            LabelCreateRowHead("1", 1);
            LabelCreateRowHead("2", 2);
            LabelCreateRowHead("3", 3);
            LabelCreateRowHead("4", 4);
            LabelCreateRowHead("5", 5);
            LabelCreateRowHead("6", 6);

            int counter = 1;
            for (int i = 1; i<7; i++)
            {
                if(i == 1)
                {
                    counter = 1;
                }
                if (i == 2)
                {
                    counter = 8;
                }
                if (i == 3)
                {
                    counter = 4;
                }
                if (i == 4)
                {
                    counter = 11;
                }
                if (i == 5)
                {
                    counter = 6;
                }
                if (i == 6)
                {
                    counter = 1;
                }
                for (int g = 1; g<20; g++)
                {
                    LabelCreateNots(g, i, counter);
                    counter++;
                    if(counter == 13)
                    {
                        counter = 1;
                    }
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int WhatNumber(string number)
        {
            if(number == "")
            {
                return 0;
            }
            if (number == "1")
            {
                return 1;
            }
            if (number == "2")
            {
                return 2;
            }
            if (number == "3")
            {
                return 3;
            }
            if (number == "4")
            {
                return 4;
            }
            if (number == "5")
            {
                return 5;
            }
            if (number == "6")
            {
                return 6;
            }
            if (number == "7")
            {
                return 7;
            }
            if (number == "8")
            {
                return 8;
            }
            if (number == "9")
            {
                return 9;
            }
            if (number == "10")
            {
                return 10;
            }
            if (number == "11")
            {
                return 11;
            }
            if (number == "12")
            {
                return 12;
            }
            return 0;
        }

        public ComboBox NoteCombobox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Width = 80;
            comboBox.Items.Add("A");
            comboBox.Items.Add("A#");
            comboBox.Items.Add("H");
            comboBox.Items.Add("C");
            comboBox.Items.Add("C#");
            comboBox.Items.Add("D");
            comboBox.Items.Add("D#");
            comboBox.Items.Add("E");
            comboBox.Items.Add("F");
            comboBox.Items.Add("F#");
            comboBox.Items.Add("G");
            comboBox.Items.Add("G#");
            return comboBox;
        }

        public ComboBox LadCombobox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Width = 250;
            comboBox.Items.Add("Минорный лад");
            comboBox.Items.Add("Мажорный лад");
            comboBox.Items.Add("Блюзовый Минорный лад");
            comboBox.Items.Add("Блюзовый Мажорный лад");
            comboBox.Items.Add("Пентатоника");
            return comboBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowCount = 1;
            int number = WhatNumber(comboBox1.Text);
            tableLayoutPanel2.RowCount = number;
                for (int i = 0; i < number; i++)
                {
                    ComboBox comboBox2 = LadCombobox();
                    tableLayoutPanel2.Controls.Add(comboBox2, i, 0);
                    ComboBox comboBox1 = NoteCombobox();
                    tableLayoutPanel2.Controls.Add(comboBox1, i, 0);
                }     
            sequenceCount = number;
            rowNumber = sequenceCount-1;
        }

        public void IsNotaHaveColorMinor(int nota, int ourNota, int column, int row)
        {
            if((nota == ourNota)|| (nota+12 == ourNota) || (nota - 12 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.LightPink;
            }
            if ((nota+2 == ourNota) || (nota + 14 == ourNota) || (nota - 10 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 3 == ourNota) || (nota + 15 == ourNota) || (nota - 9 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 5 == ourNota) || (nota + 17 == ourNota) || (nota - 7 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 7 == ourNota) || (nota + 19 == ourNota) || (nota - 5 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 8 == ourNota) || (nota + 20 == ourNota) || (nota - 4 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 10 == ourNota) || (nota + 22 == ourNota) || (nota - 2 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }

        }

        public void IsNotaHaveColorMajor(int nota, int ourNota, int column, int row)
        {
            if ((nota == ourNota) || (nota + 12 == ourNota) || (nota - 12 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.LightPink;
            }
            if ((nota + 2 == ourNota) || (nota + 14 == ourNota) || (nota - 10 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 4 == ourNota) || (nota + 16 == ourNota) || (nota - 8 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 5 == ourNota) || (nota + 17 == ourNota) || (nota - 7 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 7 == ourNota) || (nota + 19 == ourNota) || (nota - 5 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 9 == ourNota) || (nota + 21 == ourNota) || (nota - 3 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 11 == ourNota) || (nota + 23 == ourNota) || (nota - 1 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }

        }

        public void IsNotaHaveColorBluzMajor(int nota, int ourNota, int column, int row)
        {
            if ((nota == ourNota) || (nota + 12 == ourNota) || (nota - 12 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.LightPink;
            }
            if ((nota + 2 == ourNota) || (nota + 14 == ourNota) || (nota - 10 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 3 == ourNota) || (nota + 15 == ourNota) || (nota - 9 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 4 == ourNota) || (nota + 16 == ourNota) || (nota - 8 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 7 == ourNota) || (nota + 19 == ourNota) || (nota - 5 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 9 == ourNota) || (nota + 21 == ourNota) || (nota - 3 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
           

        }

        public void IsNotaHaveColorBluzMinor(int nota, int ourNota, int column, int row)
        {
            if ((nota == ourNota) || (nota + 12 == ourNota) || (nota - 12 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.LightPink;
            }
            if ((nota + 3 == ourNota) || (nota + 15 == ourNota) || (nota - 9 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 5 == ourNota) || (nota + 17 == ourNota) || (nota - 7 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 6 == ourNota) || (nota + 18 == ourNota) || (nota - 6 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 7 == ourNota) || (nota + 19 == ourNota) || (nota - 5 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 10 == ourNota) || (nota + 22 == ourNota) || (nota - 2 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }


        }

        public void IsNotaHaveColorPenta(int nota, int ourNota, int column, int row)
        {
            if ((nota == ourNota) || (nota + 12 == ourNota) || (nota - 12 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.LightPink;
            }
            if ((nota + 3 == ourNota) || (nota + 15 == ourNota) || (nota - 9 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 5 == ourNota) || (nota + 17 == ourNota) || (nota - 7 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 7 == ourNota) || (nota + 19 == ourNota) || (nota - 5 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }
            if ((nota + 10 == ourNota) || (nota + 22 == ourNota) || (nota - 2 == ourNota))
            {
                tableLayoutPanel1.GetControlFromPosition(column, row).BackColor = Color.PaleTurquoise;
            }


        }

        public void ShowMinorLad(int nota)
        {
            int column = 1;
            for (int g = 1; g <20; g++)
                {
                IsNotaHaveColorMinor(nota, g, column, 1);
                IsNotaHaveColorMinor(nota, g + 7, column, 2);
                IsNotaHaveColorMinor(nota, g + 3, column, 3);
                IsNotaHaveColorMinor(nota, g - 2, column, 4);
                IsNotaHaveColorMinor(nota, g + 5, column, 5);
                IsNotaHaveColorMinor(nota, g, column, 6);
                    column++;
                }
        }

        public void ShowMajorLad(int nota)
        {
            int column = 1;
            for (int g = 1; g < 20; g++)
            {
                IsNotaHaveColorMajor(nota, g, column, 1);
                IsNotaHaveColorMajor(nota, g + 7, column, 2);
                IsNotaHaveColorMajor(nota, g + 3, column, 3);
                IsNotaHaveColorMajor(nota, g - 2, column, 4);
                IsNotaHaveColorMajor(nota, g + 5, column, 5);
                IsNotaHaveColorMajor(nota, g, column, 6);
                column++;
            }
        }

        public void ShowBluzMajorLad(int nota)
        {
            int column = 1;
            for (int g = 1; g < 20; g++)
            {
                IsNotaHaveColorBluzMajor(nota, g, column, 1);
                IsNotaHaveColorBluzMajor(nota, g + 7, column, 2);
                IsNotaHaveColorBluzMajor(nota, g + 3, column, 3);
                IsNotaHaveColorBluzMajor(nota, g - 2, column, 4);
                IsNotaHaveColorBluzMajor(nota, g + 5, column, 5);
                IsNotaHaveColorBluzMajor(nota, g, column, 6);
                column++;
            }
        }

        public void ShowBluzMinorLad(int nota)
        {
            int column = 1;
            for (int g = 1; g < 20; g++)
            {
                IsNotaHaveColorBluzMinor(nota, g, column, 1);
                IsNotaHaveColorBluzMinor(nota, g + 7, column, 2);
                IsNotaHaveColorBluzMinor(nota, g + 3, column, 3);
                IsNotaHaveColorBluzMinor(nota, g - 2, column, 4);
                IsNotaHaveColorBluzMinor(nota, g + 5, column, 5);
                IsNotaHaveColorBluzMinor(nota, g, column, 6);
                column++;
            }
        }

        public void ShowPentaLad(int nota)
        {
            int column = 1;
            for (int g = 1; g < 20; g++)
            {
                IsNotaHaveColorPenta(nota, g, column, 1);
                IsNotaHaveColorPenta(nota, g + 7, column, 2);
                IsNotaHaveColorPenta(nota, g + 3, column, 3);
                IsNotaHaveColorPenta(nota, g - 2, column, 4);
                IsNotaHaveColorPenta(nota, g + 5, column, 5);
                IsNotaHaveColorPenta(nota, g, column, 6);
                column++;
            }
        }

        public void ShowLad(int nota, int lad)
        {
            switch(lad)
            {
                case 1:
                    ShowMinorLad(nota);
                    break;
                case 2:
                    ShowMajorLad(nota);
                    break;
                case 3:
                    ShowBluzMinorLad(nota);
                    break;
                case 4:
                    ShowBluzMajorLad(nota);
                    break;
                case 5:
                    ShowPentaLad(nota);
                    break;
            }

        }
        public int WhatNota(string nota)
        {
            switch(nota)
            {
                case "A":
                    return 6;
                case "A#":
                    return 7;
                case "H":
                    return 8;
                case "C":
                    return 9;
                case "C#":
                    return 10;
                case "D":
                    return 11;
                case "D#":
                    return 12;
                case "E":
                    return 1;
                case "F":
                    return 2;
                case "F#":
                    return 3;
                case "G":
                    return 4;
                case "G#":
                    return 5;
            }
            return 0;
        }

        public int WhatLad(string lad)
        {
            switch(lad)
            {
                case "Минорный лад":
                    return 1;

                case "Мажорный лад":
                    return 2;
                case "Блюзовый Минорный лад":
                    return 3;
                case "Блюзовый Мажорный лад":
                    return 4;
                case "Пентатоника":
                    return 5;
            }
            return 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sequenceCount == 0)
            {
                MessageBox.Show("Не выбрано количество ладов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tableLayoutPanel2.GetControlFromPosition(0, rowNumber).BackColor = Color.White;
            tableLayoutPanel2.GetControlFromPosition(1, rowNumber).BackColor = Color.White;
            rowNumber++;

            if (rowNumber == sequenceCount)
            {
                rowNumber = 0;
            }
            for (int i = 1;i<7;i++)
            {
                for(int g =1; g<20; g++)
                {
                    tableLayoutPanel1.GetControlFromPosition(g, i).BackColor = Color.White;
                }
            }

            tableLayoutPanel2.GetControlFromPosition(0, rowNumber).BackColor = Color.PaleTurquoise;
            tableLayoutPanel2.GetControlFromPosition(1, rowNumber).BackColor = Color.PaleTurquoise;

            ShowLad(WhatNota(tableLayoutPanel2.GetControlFromPosition(0, rowNumber).Text),
                WhatLad(tableLayoutPanel2.GetControlFromPosition(1, rowNumber).Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sequenceCount == 0)
            {
                MessageBox.Show("Не выбрано количество ладов", "Ошибка",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tableLayoutPanel2.GetControlFromPosition(0, rowNumber).BackColor = Color.White;
            tableLayoutPanel2.GetControlFromPosition(1, rowNumber).BackColor = Color.White;
            rowNumber--;

            if (rowNumber == -1)
            {
                rowNumber = sequenceCount - 1;
            }
            tableLayoutPanel2.GetControlFromPosition(0, rowNumber).BackColor = Color.PaleTurquoise;
            tableLayoutPanel2.GetControlFromPosition(1, rowNumber).BackColor = Color.PaleTurquoise;
            for (int i = 1; i < 7; i++)
            {
                for (int g = 1; g < 20; g++)
                {
                    tableLayoutPanel1.GetControlFromPosition(g, i).BackColor = Color.White;
                }
            }

            ShowLad(WhatNota(tableLayoutPanel2.GetControlFromPosition(0, rowNumber).Text),
                WhatLad(tableLayoutPanel2.GetControlFromPosition(1, rowNumber).Text));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ГОЛУБЕВ НИКИТА СЕРГЕЕВИЧ - Разработчик\n" +
                "ТУСУР - Факультет Вычислительных Систем - Студент\n\n" +
                "ЦУКАНОВ СЕМЁН СЕРГЕЕВИЧ - Разработчик\n" +
                "ТУСУР - Факультет Вычислительных Систем - Студент\n\n" +
                "ЦУКАНОВ АЛЕКСЕЙ СЕРГЕЕВИЧ - Консультант\n\n" +
                "МАЛЬЦЕВ ВЛАДИМИР АНДРЕЕВИЧ - Консультант\n" +
                "", "Создатели",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void квартоквинтовыйКругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKKKrug.Instance.ShowForm();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo.Instance.ShowForm();
        }
    }
}
