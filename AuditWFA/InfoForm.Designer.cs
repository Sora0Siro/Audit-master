namespace AuditWFA
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropList_Auditory = new System.Windows.Forms.ComboBox();
            this.AuditLabel = new System.Windows.Forms.Label();
            this.PlacesLabel = new System.Windows.Forms.Label();
            this.ProjectorLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.txt_Places = new System.Windows.Forms.TextBox();
            this.txt_Projector = new System.Windows.Forms.TextBox();
            this.txt_Condition = new System.Windows.Forms.TextBox();
            this.txt_Secure = new System.Windows.Forms.TextBox();
            this.txt_PCs = new System.Windows.Forms.TextBox();
            this.ComputersLabel = new System.Windows.Forms.Label();
            this.gB_Editing = new System.Windows.Forms.GroupBox();
            this.btt_AuditoryNew = new System.Windows.Forms.Button();
            this.btt_Delete = new System.Windows.Forms.Button();
            this.btt_Edit = new System.Windows.Forms.Button();
            this.btt_Save = new System.Windows.Forms.Button();
            this.btt_Clear = new System.Windows.Forms.Button();
            this.gB_Adding = new System.Windows.Forms.GroupBox();
            this.btt_HidePart = new System.Windows.Forms.Button();
            this.chck_Security = new System.Windows.Forms.CheckBox();
            this.chck_Condition = new System.Windows.Forms.CheckBox();
            this.chck_Projector = new System.Windows.Forms.CheckBox();
            this.txt_AuditoryAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PCsAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btt_Add = new System.Windows.Forms.Button();
            this.btt_ClearAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PlacesAdd = new System.Windows.Forms.TextBox();
            this.gB_Editing.SuspendLayout();
            this.gB_Adding.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropList_Auditory
            // 
            this.dropList_Auditory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropList_Auditory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropList_Auditory.FormattingEnabled = true;
            this.dropList_Auditory.Location = new System.Drawing.Point(213, 30);
            this.dropList_Auditory.Name = "dropList_Auditory";
            this.dropList_Auditory.Size = new System.Drawing.Size(121, 33);
            this.dropList_Auditory.TabIndex = 0;
            this.dropList_Auditory.TextChanged += new System.EventHandler(this.dropList_Auditory_TextChanged);
            // 
            // AuditLabel
            // 
            this.AuditLabel.AutoSize = true;
            this.AuditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditLabel.Location = new System.Drawing.Point(20, 33);
            this.AuditLabel.Name = "AuditLabel";
            this.AuditLabel.Size = new System.Drawing.Size(124, 25);
            this.AuditLabel.TabIndex = 1;
            this.AuditLabel.Text = "Аудитория:";
            // 
            // PlacesLabel
            // 
            this.PlacesLabel.AutoSize = true;
            this.PlacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesLabel.Location = new System.Drawing.Point(19, 89);
            this.PlacesLabel.Name = "PlacesLabel";
            this.PlacesLabel.Size = new System.Drawing.Size(67, 24);
            this.PlacesLabel.TabIndex = 2;
            this.PlacesLabel.Text = "Мест: ";
            // 
            // ProjectorLabel
            // 
            this.ProjectorLabel.AutoSize = true;
            this.ProjectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectorLabel.Location = new System.Drawing.Point(19, 153);
            this.ProjectorLabel.Name = "ProjectorLabel";
            this.ProjectorLabel.Size = new System.Drawing.Size(107, 24);
            this.ProjectorLabel.TabIndex = 3;
            this.ProjectorLabel.Text = "Проектор: ";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionLabel.Location = new System.Drawing.Point(19, 189);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(143, 24);
            this.ConditionLabel.TabIndex = 5;
            this.ConditionLabel.Text = "Кондиционер: ";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecurityLabel.Location = new System.Drawing.Point(19, 226);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(188, 24);
            this.SecurityLabel.TabIndex = 6;
            this.SecurityLabel.Text = "Охранная система: ";
            // 
            // txt_Places
            // 
            this.txt_Places.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Places.Location = new System.Drawing.Point(213, 87);
            this.txt_Places.Name = "txt_Places";
            this.txt_Places.Size = new System.Drawing.Size(177, 26);
            this.txt_Places.TabIndex = 7;
            this.txt_Places.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Places_KeyPress);
            // 
            // txt_Projector
            // 
            this.txt_Projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Projector.Location = new System.Drawing.Point(213, 151);
            this.txt_Projector.Name = "txt_Projector";
            this.txt_Projector.Size = new System.Drawing.Size(177, 26);
            this.txt_Projector.TabIndex = 8;
            this.txt_Projector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Secure_KeyPress);
            // 
            // txt_Condition
            // 
            this.txt_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Condition.Location = new System.Drawing.Point(213, 187);
            this.txt_Condition.Name = "txt_Condition";
            this.txt_Condition.Size = new System.Drawing.Size(177, 26);
            this.txt_Condition.TabIndex = 9;
            this.txt_Condition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Secure_KeyPress);
            // 
            // txt_Secure
            // 
            this.txt_Secure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Secure.Location = new System.Drawing.Point(213, 224);
            this.txt_Secure.Name = "txt_Secure";
            this.txt_Secure.Size = new System.Drawing.Size(177, 26);
            this.txt_Secure.TabIndex = 10;
            this.txt_Secure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Secure_KeyPress);
            // 
            // txt_PCs
            // 
            this.txt_PCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PCs.Location = new System.Drawing.Point(213, 119);
            this.txt_PCs.Name = "txt_PCs";
            this.txt_PCs.Size = new System.Drawing.Size(177, 26);
            this.txt_PCs.TabIndex = 16;
            this.txt_PCs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Places_KeyPress);
            // 
            // ComputersLabel
            // 
            this.ComputersLabel.AutoSize = true;
            this.ComputersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputersLabel.Location = new System.Drawing.Point(19, 121);
            this.ComputersLabel.Name = "ComputersLabel";
            this.ComputersLabel.Size = new System.Drawing.Size(141, 24);
            this.ComputersLabel.TabIndex = 15;
            this.ComputersLabel.Text = "Компьютеров:";
            // 
            // gB_Editing
            // 
            this.gB_Editing.BackColor = System.Drawing.Color.Ivory;
            this.gB_Editing.Controls.Add(this.btt_AuditoryNew);
            this.gB_Editing.Controls.Add(this.btt_Delete);
            this.gB_Editing.Controls.Add(this.btt_Edit);
            this.gB_Editing.Controls.Add(this.btt_Save);
            this.gB_Editing.Controls.Add(this.btt_Clear);
            this.gB_Editing.Controls.Add(this.AuditLabel);
            this.gB_Editing.Controls.Add(this.txt_PCs);
            this.gB_Editing.Controls.Add(this.dropList_Auditory);
            this.gB_Editing.Controls.Add(this.ComputersLabel);
            this.gB_Editing.Controls.Add(this.PlacesLabel);
            this.gB_Editing.Controls.Add(this.ProjectorLabel);
            this.gB_Editing.Controls.Add(this.ConditionLabel);
            this.gB_Editing.Controls.Add(this.SecurityLabel);
            this.gB_Editing.Controls.Add(this.txt_Secure);
            this.gB_Editing.Controls.Add(this.txt_Places);
            this.gB_Editing.Controls.Add(this.txt_Condition);
            this.gB_Editing.Controls.Add(this.txt_Projector);
            this.gB_Editing.Location = new System.Drawing.Point(12, -1);
            this.gB_Editing.Name = "gB_Editing";
            this.gB_Editing.Size = new System.Drawing.Size(406, 415);
            this.gB_Editing.TabIndex = 17;
            this.gB_Editing.TabStop = false;
            // 
            // btt_AuditoryNew
            // 
            this.btt_AuditoryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_AuditoryNew.Location = new System.Drawing.Point(232, 308);
            this.btt_AuditoryNew.Name = "btt_AuditoryNew";
            this.btt_AuditoryNew.Size = new System.Drawing.Size(139, 23);
            this.btt_AuditoryNew.TabIndex = 24;
            this.btt_AuditoryNew.Text = "Новая Аудитория";
            this.btt_AuditoryNew.UseVisualStyleBackColor = true;
            this.btt_AuditoryNew.Visible = false;
            this.btt_AuditoryNew.Click += new System.EventHandler(this.btt_Add_Click);
            // 
            // btt_Delete
            // 
            this.btt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_Delete.Location = new System.Drawing.Point(47, 356);
            this.btt_Delete.Name = "btt_Delete";
            this.btt_Delete.Size = new System.Drawing.Size(139, 23);
            this.btt_Delete.TabIndex = 25;
            this.btt_Delete.Text = "Удалить";
            this.btt_Delete.UseVisualStyleBackColor = true;
            this.btt_Delete.Visible = false;
            this.btt_Delete.Click += new System.EventHandler(this.btt_Delete_Click);
            // 
            // btt_Edit
            // 
            this.btt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_Edit.Location = new System.Drawing.Point(47, 269);
            this.btt_Edit.Name = "btt_Edit";
            this.btt_Edit.Size = new System.Drawing.Size(139, 23);
            this.btt_Edit.TabIndex = 19;
            this.btt_Edit.Text = "Редактировать";
            this.btt_Edit.UseVisualStyleBackColor = true;
            this.btt_Edit.Click += new System.EventHandler(this.btt_Edit_Click);
            // 
            // btt_Save
            // 
            this.btt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_Save.Location = new System.Drawing.Point(47, 298);
            this.btt_Save.Name = "btt_Save";
            this.btt_Save.Size = new System.Drawing.Size(139, 23);
            this.btt_Save.TabIndex = 20;
            this.btt_Save.Text = "Сохранить";
            this.btt_Save.UseVisualStyleBackColor = true;
            this.btt_Save.Visible = false;
            this.btt_Save.Click += new System.EventHandler(this.btt_OK_Click);
            // 
            // btt_Clear
            // 
            this.btt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_Clear.Location = new System.Drawing.Point(47, 327);
            this.btt_Clear.Name = "btt_Clear";
            this.btt_Clear.Size = new System.Drawing.Size(139, 23);
            this.btt_Clear.TabIndex = 22;
            this.btt_Clear.Text = "Очистить";
            this.btt_Clear.UseVisualStyleBackColor = true;
            this.btt_Clear.Visible = false;
            this.btt_Clear.Click += new System.EventHandler(this.btt_Clear_Click);
            // 
            // gB_Adding
            // 
            this.gB_Adding.BackColor = System.Drawing.Color.Ivory;
            this.gB_Adding.Controls.Add(this.btt_HidePart);
            this.gB_Adding.Controls.Add(this.chck_Security);
            this.gB_Adding.Controls.Add(this.chck_Condition);
            this.gB_Adding.Controls.Add(this.chck_Projector);
            this.gB_Adding.Controls.Add(this.txt_AuditoryAdd);
            this.gB_Adding.Controls.Add(this.label1);
            this.gB_Adding.Controls.Add(this.txt_PCsAdd);
            this.gB_Adding.Controls.Add(this.label2);
            this.gB_Adding.Controls.Add(this.label3);
            this.gB_Adding.Controls.Add(this.btt_Add);
            this.gB_Adding.Controls.Add(this.btt_ClearAdd);
            this.gB_Adding.Controls.Add(this.label4);
            this.gB_Adding.Controls.Add(this.label5);
            this.gB_Adding.Controls.Add(this.label6);
            this.gB_Adding.Controls.Add(this.txt_PlacesAdd);
            this.gB_Adding.Location = new System.Drawing.Point(433, -1);
            this.gB_Adding.Name = "gB_Adding";
            this.gB_Adding.Size = new System.Drawing.Size(359, 415);
            this.gB_Adding.TabIndex = 18;
            this.gB_Adding.TabStop = false;
            // 
            // btt_HidePart
            // 
            this.btt_HidePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_HidePart.Location = new System.Drawing.Point(239, 308);
            this.btt_HidePart.Name = "btt_HidePart";
            this.btt_HidePart.Size = new System.Drawing.Size(97, 23);
            this.btt_HidePart.TabIndex = 27;
            this.btt_HidePart.Text = "Скрыть";
            this.btt_HidePart.UseVisualStyleBackColor = true;
            this.btt_HidePart.Click += new System.EventHandler(this.btt_HidePart_Click);
            // 
            // chck_Security
            // 
            this.chck_Security.AutoSize = true;
            this.chck_Security.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chck_Security.Location = new System.Drawing.Point(262, 224);
            this.chck_Security.Name = "chck_Security";
            this.chck_Security.Size = new System.Drawing.Size(15, 14);
            this.chck_Security.TabIndex = 26;
            this.chck_Security.UseVisualStyleBackColor = true;
            // 
            // chck_Condition
            // 
            this.chck_Condition.AutoSize = true;
            this.chck_Condition.Location = new System.Drawing.Point(262, 191);
            this.chck_Condition.Name = "chck_Condition";
            this.chck_Condition.Size = new System.Drawing.Size(15, 14);
            this.chck_Condition.TabIndex = 25;
            this.chck_Condition.UseVisualStyleBackColor = true;
            // 
            // chck_Projector
            // 
            this.chck_Projector.AutoSize = true;
            this.chck_Projector.Location = new System.Drawing.Point(262, 154);
            this.chck_Projector.Name = "chck_Projector";
            this.chck_Projector.Size = new System.Drawing.Size(15, 14);
            this.chck_Projector.TabIndex = 24;
            this.chck_Projector.UseVisualStyleBackColor = true;
            // 
            // txt_AuditoryAdd
            // 
            this.txt_AuditoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_AuditoryAdd.Location = new System.Drawing.Point(224, 29);
            this.txt_AuditoryAdd.Name = "txt_AuditoryAdd";
            this.txt_AuditoryAdd.Size = new System.Drawing.Size(87, 26);
            this.txt_AuditoryAdd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аудитория:";
            // 
            // txt_PCsAdd
            // 
            this.txt_PCsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PCsAdd.Location = new System.Drawing.Point(225, 114);
            this.txt_PCsAdd.Name = "txt_PCsAdd";
            this.txt_PCsAdd.Size = new System.Drawing.Size(86, 26);
            this.txt_PCsAdd.TabIndex = 16;
            this.txt_PCsAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Places_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Компьютеров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мест: ";
            // 
            // btt_Add
            // 
            this.btt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_Add.Location = new System.Drawing.Point(35, 308);
            this.btt_Add.Name = "btt_Add";
            this.btt_Add.Size = new System.Drawing.Size(97, 23);
            this.btt_Add.TabIndex = 21;
            this.btt_Add.Text = "Добавить";
            this.btt_Add.UseVisualStyleBackColor = true;
            this.btt_Add.Visible = false;
            this.btt_Add.Click += new System.EventHandler(this.btt_Add_Click_1);
            // 
            // btt_ClearAdd
            // 
            this.btt_ClearAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_ClearAdd.Location = new System.Drawing.Point(136, 308);
            this.btt_ClearAdd.Name = "btt_ClearAdd";
            this.btt_ClearAdd.Size = new System.Drawing.Size(97, 23);
            this.btt_ClearAdd.TabIndex = 23;
            this.btt_ClearAdd.Text = "Очистить";
            this.btt_ClearAdd.UseVisualStyleBackColor = true;
            this.btt_ClearAdd.Visible = false;
            this.btt_ClearAdd.Click += new System.EventHandler(this.btt_ClearAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Проектор: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кондиционер: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Охранная система: ";
            // 
            // txt_PlacesAdd
            // 
            this.txt_PlacesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PlacesAdd.Location = new System.Drawing.Point(225, 82);
            this.txt_PlacesAdd.Name = "txt_PlacesAdd";
            this.txt_PlacesAdd.Size = new System.Drawing.Size(86, 26);
            this.txt_PlacesAdd.TabIndex = 7;
            this.txt_PlacesAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Places_KeyPress);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(804, 411);
            this.Controls.Add(this.gB_Adding);
            this.Controls.Add(this.gB_Editing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditories";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            this.gB_Editing.ResumeLayout(false);
            this.gB_Editing.PerformLayout();
            this.gB_Adding.ResumeLayout(false);
            this.gB_Adding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dropList_Auditory;
        private System.Windows.Forms.Label AuditLabel;
        private System.Windows.Forms.Label PlacesLabel;
        private System.Windows.Forms.Label ProjectorLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.TextBox txt_Places;
        private System.Windows.Forms.TextBox txt_Projector;
        private System.Windows.Forms.TextBox txt_Condition;
        private System.Windows.Forms.TextBox txt_Secure;
        private System.Windows.Forms.TextBox txt_PCs;
        private System.Windows.Forms.Label ComputersLabel;
        private System.Windows.Forms.GroupBox gB_Editing;
        private System.Windows.Forms.GroupBox gB_Adding;
        private System.Windows.Forms.TextBox txt_AuditoryAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PCsAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PlacesAdd;
        private System.Windows.Forms.Button btt_AuditoryNew;
        private System.Windows.Forms.Button btt_Delete;
        private System.Windows.Forms.Button btt_Edit;
        private System.Windows.Forms.Button btt_Save;
        private System.Windows.Forms.Button btt_Clear;
        private System.Windows.Forms.Button btt_Add;
        private System.Windows.Forms.Button btt_ClearAdd;
        private System.Windows.Forms.CheckBox chck_Security;
        private System.Windows.Forms.CheckBox chck_Condition;
        private System.Windows.Forms.CheckBox chck_Projector;
        private System.Windows.Forms.Button btt_HidePart;
    }
}