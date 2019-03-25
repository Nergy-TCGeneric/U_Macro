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
            this.recordMouseMacro = new System.Windows.Forms.Button();
            this.recordKeyboardMacro = new System.Windows.Forms.Button();
            this.modifySelectedMacro = new System.Windows.Forms.Button();
            this.deleteSelectedMacro = new System.Windows.Forms.Button();
            this.exportToFile = new System.Windows.Forms.Button();
            this.importFromFile = new System.Windows.Forms.Button();
            this.InsertMacroProcedure = new System.Windows.Forms.Button();
            this.recordMethodGroup = new System.Windows.Forms.GroupBox();
            this.individualMethod = new System.Windows.Forms.RadioButton();
            this.continuousMethod = new System.Windows.Forms.RadioButton();
            this.recordMethodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // procedureList
            // 
            this.procedureList.FormattingEnabled = true;
            resources.ApplyResources(this.procedureList, "procedureList");
            this.procedureList.Name = "procedureList";
            this.procedureList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // recordMouseMacro
            // 
            resources.ApplyResources(this.recordMouseMacro, "recordMouseMacro");
            this.recordMouseMacro.Name = "recordMouseMacro";
            this.recordMouseMacro.UseVisualStyleBackColor = true;
            this.recordMouseMacro.Click += new System.EventHandler(this.recordMouseMacro_Click);
            // 
            // recordKeyboardMacro
            // 
            resources.ApplyResources(this.recordKeyboardMacro, "recordKeyboardMacro");
            this.recordKeyboardMacro.Name = "recordKeyboardMacro";
            this.recordKeyboardMacro.UseVisualStyleBackColor = true;
            // 
            // modifySelectedMacro
            // 
            resources.ApplyResources(this.modifySelectedMacro, "modifySelectedMacro");
            this.modifySelectedMacro.Name = "modifySelectedMacro";
            this.modifySelectedMacro.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedMacro
            // 
            resources.ApplyResources(this.deleteSelectedMacro, "deleteSelectedMacro");
            this.deleteSelectedMacro.Name = "deleteSelectedMacro";
            this.deleteSelectedMacro.UseVisualStyleBackColor = true;
            // 
            // exportToFile
            // 
            resources.ApplyResources(this.exportToFile, "exportToFile");
            this.exportToFile.Name = "exportToFile";
            this.exportToFile.UseVisualStyleBackColor = true;
            // 
            // importFromFile
            // 
            resources.ApplyResources(this.importFromFile, "importFromFile");
            this.importFromFile.Name = "importFromFile";
            this.importFromFile.UseVisualStyleBackColor = true;
            // 
            // InsertMacroProcedure
            // 
            resources.ApplyResources(this.InsertMacroProcedure, "InsertMacroProcedure");
            this.InsertMacroProcedure.Name = "InsertMacroProcedure";
            this.InsertMacroProcedure.UseVisualStyleBackColor = true;
            // 
            // recordMethodGroup
            // 
            this.recordMethodGroup.Controls.Add(this.individualMethod);
            this.recordMethodGroup.Controls.Add(this.continuousMethod);
            resources.ApplyResources(this.recordMethodGroup, "recordMethodGroup");
            this.recordMethodGroup.Name = "recordMethodGroup";
            this.recordMethodGroup.TabStop = false;
            // 
            // individualMethod
            // 
            resources.ApplyResources(this.individualMethod, "individualMethod");
            this.individualMethod.Name = "individualMethod";
            this.individualMethod.TabStop = true;
            this.individualMethod.UseVisualStyleBackColor = true;
            // 
            // continuousMethod
            // 
            resources.ApplyResources(this.continuousMethod, "continuousMethod");
            this.continuousMethod.Name = "continuousMethod";
            this.continuousMethod.TabStop = true;
            this.continuousMethod.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recordMethodGroup);
            this.Controls.Add(this.InsertMacroProcedure);
            this.Controls.Add(this.importFromFile);
            this.Controls.Add(this.exportToFile);
            this.Controls.Add(this.deleteSelectedMacro);
            this.Controls.Add(this.modifySelectedMacro);
            this.Controls.Add(this.recordKeyboardMacro);
            this.Controls.Add(this.recordMouseMacro);
            this.Controls.Add(this.procedureList);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.recordMethodGroup.ResumeLayout(false);
            this.recordMethodGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox procedureList;
        private System.Windows.Forms.Button recordMouseMacro;
        private System.Windows.Forms.Button recordKeyboardMacro;
        private System.Windows.Forms.Button modifySelectedMacro;
        private System.Windows.Forms.Button deleteSelectedMacro;
        private System.Windows.Forms.Button exportToFile;
        private System.Windows.Forms.Button importFromFile;
        private System.Windows.Forms.Button InsertMacroProcedure;
        private System.Windows.Forms.GroupBox recordMethodGroup;
        private System.Windows.Forms.RadioButton individualMethod;
        private System.Windows.Forms.RadioButton continuousMethod;
    }
}

