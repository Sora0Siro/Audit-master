using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AuditWFA
{
    public partial class InfoForm : Form
    {
        private bool buttonsEnabled = false;
        private bool allFieldsFilled = true;
        private string AuditoriesPath;

        Dictionary<string, List<string>> auditoriesDC;
        public InfoForm(Dictionary<string, List<string>> auditoriesDC,string AuditoriesPath)
        {
            InitializeComponent();

            this.auditoriesDC = auditoriesDC;
            this.AuditoriesPath = AuditoriesPath;

            setAuditories();
            hideButtons();
            showAddButtons();
            setDefaultRedactButtonPosition();

            ToolTip t = new ToolTip();
            t.SetToolTip(txt_AuditoryAdd, "ОЦ, оц, лаб, ауд");
        }

        //events
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btt_Add_Click(object sender, EventArgs e)
        {
            gB_Adding.Visible = true;
            btt_Add.Visible = true;
            btt_ClearAdd.Visible = true;
            setExtendedWindowSize();
        }

        private void btt_Edit_Click(object sender, EventArgs e)
        {
            if (buttonsEnabled)
            {
                btt_Edit.Text = "Редактировать";
                hideButtons();
                setDefaultRedactButtonPosition();
            }
            else if (!buttonsEnabled)
            {
                btt_Edit.Text = "Завершить";
                showButtons();
                setExtendRedactButtonPosition();
            }
        }

        private void btt_OK_Click(object sender, EventArgs e)
        {
            if (checkForFilledFields())
            {
                auditoriesDC[dropList_Auditory.Text].Clear();

                auditoriesDC[dropList_Auditory.Text].Add(txt_Places.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_PCs.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Projector.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Condition.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Secure.Text);

                saveEditedAuditories();

                MessageBox.Show("Данные аудитории были сохранены");
            }
            else
            {
                MessageBox.Show("Некоторые поля незаполнены");
            }
        }

        private void dropList_Auditory_TextChanged(object sender, EventArgs e)
        {
            if (dropList_Auditory.Text != "" && dropList_Auditory.Text != " ")
            {
                clearFields();
                setFields();
            }
        }

        private void btt_Add_Click_1(object sender, EventArgs e)
        {
            if (checkAddingFields())
            {
                if (auditoriesDC.ContainsKey(txt_AuditoryAdd.Text))
                {
                    MessageBox.Show("Данная аудитория уже существует");
                }
                else if (!auditoriesDC.ContainsKey(txt_AuditoryAdd.Text))
                {
                    List<string> tmp = new List<string>();

                    tmp.Add(txt_PlacesAdd.Text);
                    tmp.Add(txt_PCsAdd.Text);
                    if (chck_Projector.Checked) tmp.Add("есть");
                    else tmp.Add("отсутствует");
                    if (chck_Condition.Checked) tmp.Add("есть");
                    else tmp.Add("отсутствует");
                    if (chck_Security.Checked) tmp.Add("есть");
                    else tmp.Add("отсутствует");

                    auditoriesDC.Add(txt_AuditoryAdd.Text, tmp);
                    clearAddingFields();
                    MessageBox.Show("Аудитория была успешно добавлена");
                    clearDropListAuditories();
                    setAuditories();
                    saveEditedAuditories();
                }
            }
        }

        private void btt_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btt_ClearAdd_Click(object sender, EventArgs e)
        {
            clearAddingFields();
        }

        private void btt_Delete_Click(object sender, EventArgs e)
        {
            //delete selected auditory
            if (checkForFilledFields())
            {
                auditoriesDC.Remove(dropList_Auditory.Text);
                saveEditedAuditories();
                clearDropListAuditories();
                setAuditories();
                clearFields();
                clearAudDropList();
                MessageBox.Show("Удаление было успешно");
            }
        }

        //methods
        private void readOnly(bool state)
        {
            txt_Places.ReadOnly = !state;
            txt_PCs.ReadOnly = !state;
            txt_Projector.ReadOnly = !state;
            txt_Condition.ReadOnly = !state;
            txt_Secure.ReadOnly = !state;
        }

        private void saveEditedAuditories()
        {
            List<string> conts = new List<string>();

            foreach(KeyValuePair<string,List<string>> dc in auditoriesDC)
            {
                //аудитории из списка
                conts.Add(dc.Key);

                foreach(string s in dc.Value)
                {
                    //все параметры аудитории
                    conts.Add(s);
                }
                conts.Add(" ");
            }

            string[] contents = conts.Select(i => i.ToString()).ToArray();

            File.WriteAllLines(AuditoriesPath, contents, Encoding.Unicode);
        }

        //hide
        private void hideAdding()
        {
            gB_Adding.Visible = false;
        }

        public void hideButtons()
        {
            btt_Save.Visible = btt_Clear.Visible = btt_Delete.Visible = false;
            buttonsEnabled = false;
            readOnly(buttonsEnabled);

            //some(buttonsEnabled);
        }

        //show
        private void showAddButtons()
        {
            btt_AuditoryNew.Visible = true;
            hideAdding();
            setDefaultWindowSize();
        }

        public void showButtons()
        {
            btt_Save.Visible = btt_Clear.Visible = btt_Delete.Visible = true;
            buttonsEnabled = true;
            readOnly(buttonsEnabled);

            //some(buttonsEnabled);
        }

        private void showGBAdding(bool state)
        {
            if (!state) gB_Adding.Visible = false;
            else if (state) hideAdding();
        }

        //check
        private bool checkForFilledFields()
        {
            if (dropList_Auditory.Text != "" && dropList_Auditory.Text != " " && txt_Places.Text != "" && txt_Places.Text != " " && txt_PCs.Text != "" && txt_PCs.Text != " " && txt_Projector.Text != "" && txt_Projector.Text != " " && txt_Condition.Text != "" && txt_Condition.Text != " " && txt_Secure.Text != "" && txt_Secure.Text != " ")
            {
                allFieldsFilled = true;
            }
            else
            {
                allFieldsFilled = false;
            }
            return allFieldsFilled;
        }

        private bool checkAddingFields()
        {
            if(txt_AuditoryAdd.Text.Contains("ОЦ") || txt_AuditoryAdd.Text.Contains("оц") || txt_AuditoryAdd.Text.Contains("ауд") || txt_AuditoryAdd.Text.Contains("АУД") || txt_AuditoryAdd.Text.Contains("№"))
            {
                bool state = true;
                if (txt_AuditoryAdd.Text != "" && txt_AuditoryAdd.Text != " " && txt_PlacesAdd.Text != "" && txt_PlacesAdd.Text != " " && txt_PCsAdd.Text != "" && txt_PCsAdd.Text != " ")
                {
                    return state;
                }
                else
                {
                    MessageBox.Show("Некоторые поля незаполнены");
                    return !state;
                }
            }
            else if(txt_AuditoryAdd.Text == null || txt_AuditoryAdd.Text ==" ")
            {
                MessageBox.Show("Введите название аудитории");
                return false;
            }
            else
            {
                MessageBox.Show("Неподходящее название для аудитории");
                return false;
            }
        }

        //sets
        private void setDefaultWindowSize()
        {
            this.Width = 445;
        }

        private void setExtendedWindowSize()
        {
            this.Width = 820;
        }

        private void setFields()
        {
            txt_Places.Text = auditoriesDC[dropList_Auditory.Text][0];
            txt_PCs.Text = auditoriesDC[dropList_Auditory.Text][1];
            txt_Projector.Text = auditoriesDC[dropList_Auditory.Text][2];
            txt_Condition.Text = auditoriesDC[dropList_Auditory.Text][3];
            txt_Secure.Text = auditoriesDC[dropList_Auditory.Text][4];
        }

        private void setAuditories()
        {
            foreach (KeyValuePair<string, List<string>> dc in auditoriesDC)
            {
                dropList_Auditory.Items.Add(dc.Key);
            }
        }

        private void setDefaultRedactButtonPosition()
        {
            btt_Edit.Location = new Point(47, 308);
        }

        private void setExtendRedactButtonPosition()
        {
            btt_Edit.Location = new Point(47, 268);
        }

        //clear
        private void clearAddingFields()
        {
            txt_AuditoryAdd.Text = "";
            txt_PlacesAdd.Text = "";
            txt_PCsAdd.Text = "";
            chck_Projector.Checked = false;
            chck_Condition.Checked = false;
            chck_Security.Checked = false;
        }

        private void clearFields()
        {
            txt_Places.Text = "";
            txt_PCs.Text = "";
            txt_Projector.Text = "";
            txt_Condition.Text = "";
            txt_Secure.Text = "";
        }

        private void clearAudDropList()
        {
            dropList_Auditory.Text = "";
        }

        private void clearDropListAuditories()
        {
            dropList_Auditory.Items.Clear();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btt_HidePart_Click(object sender, EventArgs e)
        {
            setDefaultWindowSize();
            gB_Adding.Visible = false;
        }

        private void txt_Places_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_Secure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}