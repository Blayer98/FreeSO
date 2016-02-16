﻿namespace FSO.IDE
{
    partial class ObjectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectWindow));
            this.objPages = new System.Windows.Forms.TabControl();
            this.DefinitionTab = new System.Windows.Forms.TabPage();
            this.DefinitionEditor = new FSO.IDE.ResourceBrowser.OBJDEditor();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IffResView = new FSO.IDE.ResourceBrowser.IFFResComponent();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.iffButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGRPEdit = new FSO.IDE.Common.InteractiveDGRPControl();
            this.ObjCombo = new System.Windows.Forms.ComboBox();
            this.SemiGlobalButton = new System.Windows.Forms.Button();
            this.ObjMultitileLabel = new System.Windows.Forms.Label();
            this.ObjDescLabel = new System.Windows.Forms.Label();
            this.ObjNameLabel = new System.Windows.Forms.Label();
            this.GlobalButton = new System.Windows.Forms.Button();
            this.SGChangeButton = new System.Windows.Forms.Button();
            this.ObjThumb = new FSO.IDE.Common.ObjThumbnailControl();
            this.objPages.SuspendLayout();
            this.DefinitionTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // objPages
            // 
            this.objPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objPages.Controls.Add(this.DefinitionTab);
            this.objPages.Controls.Add(this.tabPage2);
            this.objPages.Controls.Add(this.tabPage3);
            this.objPages.Controls.Add(this.tabPage4);
            this.objPages.Controls.Add(this.tabPage5);
            this.objPages.Location = new System.Drawing.Point(7, 68);
            this.objPages.Name = "objPages";
            this.objPages.SelectedIndex = 0;
            this.objPages.Size = new System.Drawing.Size(770, 485);
            this.objPages.TabIndex = 0;
            // 
            // DefinitionTab
            // 
            this.DefinitionTab.Controls.Add(this.DefinitionEditor);
            this.DefinitionTab.Location = new System.Drawing.Point(4, 22);
            this.DefinitionTab.Name = "DefinitionTab";
            this.DefinitionTab.Padding = new System.Windows.Forms.Padding(3);
            this.DefinitionTab.Size = new System.Drawing.Size(762, 459);
            this.DefinitionTab.TabIndex = 0;
            this.DefinitionTab.Text = "Object";
            this.DefinitionTab.UseVisualStyleBackColor = true;
            // 
            // DefinitionEditor
            // 
            this.DefinitionEditor.Location = new System.Drawing.Point(0, 0);
            this.DefinitionEditor.Name = "DefinitionEditor";
            this.DefinitionEditor.Size = new System.Drawing.Size(762, 459);
            this.DefinitionEditor.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IffResView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(762, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trees and Resources";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IffResView
            // 
            this.IffResView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IffResView.Location = new System.Drawing.Point(0, 0);
            this.IffResView.Margin = new System.Windows.Forms.Padding(0);
            this.IffResView.Name = "IffResView";
            this.IffResView.Size = new System.Drawing.Size(762, 459);
            this.IffResView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Entry Points";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.iffButton);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 459);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "File Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // iffButton
            // 
            this.iffButton.Location = new System.Drawing.Point(6, 72);
            this.iffButton.Name = "iffButton";
            this.iffButton.Size = new System.Drawing.Size(300, 29);
            this.iffButton.TabIndex = 5;
            this.iffButton.Text = "Export .iff";
            this.iffButton.UseVisualStyleBackColor = true;
            this.iffButton.Click += new System.EventHandler(this.iffButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save .piff (test)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 453);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.DGRPEdit);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(762, 459);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Appearance";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(559, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Selected Sprite";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(3, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 222);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Drawgroup";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 219);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drawgroups";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(559, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 304);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sprites";
            // 
            // DGRPEdit
            // 
            this.DGRPEdit.Location = new System.Drawing.Point(206, 6);
            this.DGRPEdit.Name = "DGRPEdit";
            this.DGRPEdit.Size = new System.Drawing.Size(350, 447);
            this.DGRPEdit.TabIndex = 0;
            // 
            // ObjCombo
            // 
            this.ObjCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjCombo.FormattingEnabled = true;
            this.ObjCombo.Location = new System.Drawing.Point(469, 12);
            this.ObjCombo.Name = "ObjCombo";
            this.ObjCombo.Size = new System.Drawing.Size(304, 21);
            this.ObjCombo.TabIndex = 2;
            this.ObjCombo.SelectedIndexChanged += new System.EventHandler(this.ObjCombo_SelectedIndexChanged);
            // 
            // SemiGlobalButton
            // 
            this.SemiGlobalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SemiGlobalButton.Location = new System.Drawing.Point(469, 37);
            this.SemiGlobalButton.Name = "SemiGlobalButton";
            this.SemiGlobalButton.Size = new System.Drawing.Size(171, 23);
            this.SemiGlobalButton.TabIndex = 3;
            this.SemiGlobalButton.Text = "Semi-Global (doorglobals)";
            this.SemiGlobalButton.UseVisualStyleBackColor = true;
            this.SemiGlobalButton.Click += new System.EventHandler(this.SemiGlobalButton_Click);
            // 
            // ObjMultitileLabel
            // 
            this.ObjMultitileLabel.Location = new System.Drawing.Point(61, 45);
            this.ObjMultitileLabel.Name = "ObjMultitileLabel";
            this.ObjMultitileLabel.Size = new System.Drawing.Size(186, 17);
            this.ObjMultitileLabel.TabIndex = 20;
            this.ObjMultitileLabel.Text = "Multitile Master Object";
            // 
            // ObjDescLabel
            // 
            this.ObjDescLabel.Location = new System.Drawing.Point(61, 30);
            this.ObjDescLabel.Name = "ObjDescLabel";
            this.ObjDescLabel.Size = new System.Drawing.Size(186, 17);
            this.ObjDescLabel.TabIndex = 19;
            this.ObjDescLabel.Text = "§2000 - Job Object";
            // 
            // ObjNameLabel
            // 
            this.ObjNameLabel.AutoEllipsis = true;
            this.ObjNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjNameLabel.Location = new System.Drawing.Point(61, 12);
            this.ObjNameLabel.Name = "ObjNameLabel";
            this.ObjNameLabel.Size = new System.Drawing.Size(288, 17);
            this.ObjNameLabel.TabIndex = 18;
            this.ObjNameLabel.Text = "Accessory Rack - Cheap";
            // 
            // GlobalButton
            // 
            this.GlobalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GlobalButton.Location = new System.Drawing.Point(698, 37);
            this.GlobalButton.Name = "GlobalButton";
            this.GlobalButton.Size = new System.Drawing.Size(75, 23);
            this.GlobalButton.TabIndex = 21;
            this.GlobalButton.Text = "Global";
            this.GlobalButton.UseVisualStyleBackColor = true;
            this.GlobalButton.Click += new System.EventHandler(this.GlobalButton_Click);
            // 
            // SGChangeButton
            // 
            this.SGChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SGChangeButton.Location = new System.Drawing.Point(640, 37);
            this.SGChangeButton.Name = "SGChangeButton";
            this.SGChangeButton.Size = new System.Drawing.Size(52, 23);
            this.SGChangeButton.TabIndex = 22;
            this.SGChangeButton.Text = "Change";
            this.SGChangeButton.UseVisualStyleBackColor = true;
            // 
            // ObjThumb
            // 
            this.ObjThumb.Location = new System.Drawing.Point(7, 12);
            this.ObjThumb.Name = "ObjThumb";
            this.ObjThumb.Size = new System.Drawing.Size(48, 48);
            this.ObjThumb.TabIndex = 23;
            // 
            // ObjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ObjThumb);
            this.Controls.Add(this.SGChangeButton);
            this.Controls.Add(this.GlobalButton);
            this.Controls.Add(this.ObjMultitileLabel);
            this.Controls.Add(this.ObjDescLabel);
            this.Controls.Add(this.ObjNameLabel);
            this.Controls.Add(this.SemiGlobalButton);
            this.Controls.Add(this.ObjCombo);
            this.Controls.Add(this.objPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ObjectWindow";
            this.Text = "Edit Object - accessoryrack";
            this.objPages.ResumeLayout(false);
            this.DefinitionTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl objPages;
        private System.Windows.Forms.TabPage DefinitionTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox ObjCombo;
        private System.Windows.Forms.Button SemiGlobalButton;
        private System.Windows.Forms.Label ObjMultitileLabel;
        private System.Windows.Forms.Label ObjDescLabel;
        private System.Windows.Forms.Label ObjNameLabel;
        private System.Windows.Forms.Button GlobalButton;
        private ResourceBrowser.IFFResComponent IffResView;
        private System.Windows.Forms.Button SGChangeButton;
        private System.Windows.Forms.Button iffButton;
        private System.Windows.Forms.Button button1;
        private Common.ObjThumbnailControl ObjThumb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private Common.InteractiveDGRPControl DGRPEdit;
        private ResourceBrowser.OBJDEditor DefinitionEditor;
    }
}