namespace UMacro
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.procedureList = new System.Windows.Forms.ListBox();
            this.recordMacro = new System.Windows.Forms.Button();
            this.modifySelectedMacro = new System.Windows.Forms.Button();
            this.deleteSelectedMacro = new System.Windows.Forms.Button();
            this.exportToFile = new System.Windows.Forms.Button();
            this.importFromFile = new System.Windows.Forms.Button();
            this.InsertMacroProcedure = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseRecordInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keyboardRecordInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // procedureList
            // 
            this.procedureList.FormattingEnabled = true;
            resources.ApplyResources(this.procedureList, "procedureList");
            this.procedureList.Name = "procedureList";
            this.procedureList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // recordMacro
            // 
            resources.ApplyResources(this.recordMacro, "recordMacro");
            this.recordMacro.Name = "recordMacro";
            this.recordMacro.UseVisualStyleBackColor = true;
            this.recordMacro.Click += new System.EventHandler(this.recordMacro_Click);
            // 
            // modifySelectedMacro
            // 
            resources.ApplyResources(this.modifySelectedMacro, "modifySelectedMacro");
            this.modifySelectedMacro.Name = "modifySelectedMacro";
            this.modifySelectedMacro.UseVisualStyleBackColor = true;
            this.modifySelectedMacro.Click += new System.EventHandler(this.modifySelectedMacro_Click);
            // 
            // deleteSelectedMacro
            // 
            resources.ApplyResources(this.deleteSelectedMacro, "deleteSelectedMacro");
            this.deleteSelectedMacro.Name = "deleteSelectedMacro";
            this.deleteSelectedMacro.UseVisualStyleBackColor = true;
            this.deleteSelectedMacro.Click += new System.EventHandler(this.deleteSelectedMacro_Click);
            // 
            // exportToFile
            // 
            resources.ApplyResources(this.exportToFile, "exportToFile");
            this.exportToFile.Name = "exportToFile";
            this.exportToFile.UseVisualStyleBackColor = true;
            this.exportToFile.Click += new System.EventHandler(this.exportToFile_Click);
            // 
            // importFromFile
            // 
            resources.ApplyResources(this.importFromFile, "importFromFile");
            this.importFromFile.Name = "importFromFile";
            this.importFromFile.UseVisualStyleBackColor = true;
            this.importFromFile.Click += new System.EventHandler(this.importFromFile_Click);
            // 
            // InsertMacroProcedure
            // 
            resources.ApplyResources(this.InsertMacroProcedure, "InsertMacroProcedure");
            this.InsertMacroProcedure.Name = "InsertMacroProcedure";
            this.InsertMacroProcedure.UseVisualStyleBackColor = true;
            this.InsertMacroProcedure.Click += new System.EventHandler(this.InsertMacroProcedure_Click);
            // 
            // playBtn
            // 
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // playInterval
            // 
            resources.ApplyResources(this.playInterval, "playInterval");
            this.playInterval.Name = "playInterval";
            this.playInterval.TextChanged += new System.EventHandler(this.playInterval_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // mouseRecordInterval
            // 
            resources.ApplyResources(this.mouseRecordInterval, "mouseRecordInterval");
            this.mouseRecordInterval.Name = "mouseRecordInterval";
            this.mouseRecordInterval.TextChanged += new System.EventHandler(this.mouseRecordInterval_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // keyboardRecordInterval
            // 
            resources.ApplyResources(this.keyboardRecordInterval, "keyboardRecordInterval");
            this.keyboardRecordInterval.Name = "keyboardRecordInterval";
            this.keyboardRecordInterval.TextChanged += new System.EventHandler(this.keyboardRecordInterval_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyboardRecordInterval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mouseRecordInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.InsertMacroProcedure);
            this.Controls.Add(this.importFromFile);
            this.Controls.Add(this.exportToFile);
            this.Controls.Add(this.deleteSelectedMacro);
            this.Controls.Add(this.modifySelectedMacro);
            this.Controls.Add(this.recordMacro);
            this.Controls.Add(this.procedureList);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox procedureList;
        private System.Windows.Forms.Button recordMacro;
        private System.Windows.Forms.Button modifySelectedMacro;
        private System.Windows.Forms.Button deleteSelectedMacro;
        private System.Windows.Forms.Button exportToFile;
        private System.Windows.Forms.Button importFromFile;
        private System.Windows.Forms.Button InsertMacroProcedure;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mouseRecordInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyboardRecordInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

