﻿namespace mage.Theming
{
    partial class ThemeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeEditor));
            statusStrip = new System.Windows.Forms.StatusStrip();
            button_export = new System.Windows.Forms.ToolStripDropDownButton();
            menuItem_export_current = new System.Windows.Forms.ToolStripMenuItem();
            menuItem_export_all = new System.Windows.Forms.ToolStripMenuItem();
            button_import = new System.Windows.Forms.ToolStripDropDownButton();
            menuItem_import_theme = new System.Windows.Forms.ToolStripMenuItem();
            menuItem_import_multiple = new System.Windows.Forms.ToolStripMenuItem();
            groupBox_colors = new System.Windows.Forms.GroupBox();
            panel_main = new mage.Controls.ExtendedPanel();
            panel_accent = new mage.Controls.ExtendedPanel();
            panel_secondary = new mage.Controls.ExtendedPanel();
            panel_primary = new mage.Controls.ExtendedPanel();
            panel_background = new mage.Controls.ExtendedPanel();
            panel_text = new mage.Controls.ExtendedPanel();
            flatTextBox_accent = new CustomControls.FlatTextBox();
            flatTextBox_secondary = new CustomControls.FlatTextBox();
            flatTextBox_primary = new CustomControls.FlatTextBox();
            flatTextBox_background = new CustomControls.FlatTextBox();
            flatTextBox_text = new CustomControls.FlatTextBox();
            label_accent = new System.Windows.Forms.Label();
            label_secondary_outline = new System.Windows.Forms.Label();
            label_primary_outline = new System.Windows.Forms.Label();
            label_background = new System.Windows.Forms.Label();
            label_text = new System.Windows.Forms.Label();
            btn_add = new System.Windows.Forms.Button();
            btn_remove = new System.Windows.Forms.Button();
            button_apply = new System.Windows.Forms.Button();
            flatTextBox_name = new CustomControls.FlatTextBox();
            comboBox_theme = new CustomControls.FlatComboBox();
            statusStrip.SuspendLayout();
            groupBox_colors.SuspendLayout();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_export, button_import });
            statusStrip.Location = new System.Drawing.Point(0, 294);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(362, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // button_export
            // 
            button_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            button_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItem_export_current, menuItem_export_all });
            button_export.Image = (System.Drawing.Image)resources.GetObject("button_export.Image");
            button_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_export.Name = "button_export";
            button_export.Size = new System.Drawing.Size(54, 20);
            button_export.Text = "Export";
            // 
            // menuItem_export_current
            // 
            menuItem_export_current.Name = "menuItem_export_current";
            menuItem_export_current.Size = new System.Drawing.Size(190, 22);
            menuItem_export_current.Text = "Export Current Theme";
            menuItem_export_current.Click += menuItem_export_Click;
            // 
            // menuItem_export_all
            // 
            menuItem_export_all.Name = "menuItem_export_all";
            menuItem_export_all.Size = new System.Drawing.Size(190, 22);
            menuItem_export_all.Text = "Export All Themes";
            menuItem_export_all.Click += exportAll_Click;
            // 
            // button_import
            // 
            button_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            button_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItem_import_theme, menuItem_import_multiple });
            button_import.Image = (System.Drawing.Image)resources.GetObject("button_import.Image");
            button_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_import.Name = "button_import";
            button_import.Size = new System.Drawing.Size(56, 20);
            button_import.Text = "Import";
            // 
            // menuItem_import_theme
            // 
            menuItem_import_theme.Name = "menuItem_import_theme";
            menuItem_import_theme.Size = new System.Drawing.Size(201, 22);
            menuItem_import_theme.Text = "Import Theme";
            menuItem_import_theme.Click += menuItem_import_Click;
            // 
            // menuItem_import_multiple
            // 
            menuItem_import_multiple.Name = "menuItem_import_multiple";
            menuItem_import_multiple.Size = new System.Drawing.Size(201, 22);
            menuItem_import_multiple.Text = "Import Multiple Themes";
            menuItem_import_multiple.Click += importAll_Click;
            // 
            // groupBox_colors
            // 
            groupBox_colors.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox_colors.Controls.Add(panel_main);
            groupBox_colors.Location = new System.Drawing.Point(14, 75);
            groupBox_colors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_colors.Name = "groupBox_colors";
            groupBox_colors.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_colors.Size = new System.Drawing.Size(334, 173);
            groupBox_colors.TabIndex = 2;
            groupBox_colors.TabStop = false;
            groupBox_colors.Text = "Colors";
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.Controls.Add(panel_accent);
            panel_main.Controls.Add(panel_secondary);
            panel_main.Controls.Add(panel_primary);
            panel_main.Controls.Add(panel_background);
            panel_main.Controls.Add(panel_text);
            panel_main.Controls.Add(flatTextBox_accent);
            panel_main.Controls.Add(flatTextBox_secondary);
            panel_main.Controls.Add(flatTextBox_primary);
            panel_main.Controls.Add(flatTextBox_background);
            panel_main.Controls.Add(flatTextBox_text);
            panel_main.Controls.Add(label_accent);
            panel_main.Controls.Add(label_secondary_outline);
            panel_main.Controls.Add(label_primary_outline);
            panel_main.Controls.Add(label_background);
            panel_main.Controls.Add(label_text);
            panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_main.Location = new System.Drawing.Point(4, 19);
            panel_main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_main.Name = "panel_main";
            panel_main.Size = new System.Drawing.Size(326, 151);
            panel_main.TabIndex = 0;
            panel_main.Tag = "";
            // 
            // panel_accent
            // 
            panel_accent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel_accent.Location = new System.Drawing.Point(299, 123);
            panel_accent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_accent.Name = "panel_accent";
            panel_accent.Size = new System.Drawing.Size(23, 23);
            panel_accent.TabIndex = 14;
            panel_accent.Tag = "AccentColor";
            // 
            // panel_secondary
            // 
            panel_secondary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel_secondary.Location = new System.Drawing.Point(299, 93);
            panel_secondary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_secondary.Name = "panel_secondary";
            panel_secondary.Size = new System.Drawing.Size(23, 23);
            panel_secondary.TabIndex = 13;
            panel_secondary.Tag = "SecondaryOutline";
            // 
            // panel_primary
            // 
            panel_primary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel_primary.Location = new System.Drawing.Point(299, 63);
            panel_primary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_primary.Name = "panel_primary";
            panel_primary.Size = new System.Drawing.Size(23, 23);
            panel_primary.TabIndex = 12;
            panel_primary.Tag = "PrimaryOutline";
            // 
            // panel_background
            // 
            panel_background.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel_background.Location = new System.Drawing.Point(299, 33);
            panel_background.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_background.Name = "panel_background";
            panel_background.Size = new System.Drawing.Size(23, 23);
            panel_background.TabIndex = 11;
            panel_background.Tag = "BackgroundColor";
            // 
            // panel_text
            // 
            panel_text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel_text.Location = new System.Drawing.Point(299, 3);
            panel_text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_text.Name = "panel_text";
            panel_text.Size = new System.Drawing.Size(23, 23);
            panel_text.TabIndex = 10;
            panel_text.Tag = "TextColor";
            // 
            // flatTextBox_accent
            // 
            flatTextBox_accent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_accent.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_accent.DisplayBorder = true;
            flatTextBox_accent.Location = new System.Drawing.Point(124, 123);
            flatTextBox_accent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_accent.MaxLength = 32767;
            flatTextBox_accent.Multiline = false;
            flatTextBox_accent.Name = "flatTextBox_accent";
            flatTextBox_accent.OnTextChanged = null;
            flatTextBox_accent.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_accent.ReadOnly = false;
            flatTextBox_accent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_accent.SelectionStart = 0;
            flatTextBox_accent.Size = new System.Drawing.Size(167, 23);
            flatTextBox_accent.TabIndex = 9;
            flatTextBox_accent.Tag = "panel_accent";
            flatTextBox_accent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_accent.WordWrap = true;
            flatTextBox_accent.TextChanged += ColorValueChanged;
            // 
            // flatTextBox_secondary
            // 
            flatTextBox_secondary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_secondary.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_secondary.DisplayBorder = true;
            flatTextBox_secondary.Location = new System.Drawing.Point(124, 93);
            flatTextBox_secondary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_secondary.MaxLength = 32767;
            flatTextBox_secondary.Multiline = false;
            flatTextBox_secondary.Name = "flatTextBox_secondary";
            flatTextBox_secondary.OnTextChanged = null;
            flatTextBox_secondary.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_secondary.ReadOnly = false;
            flatTextBox_secondary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_secondary.SelectionStart = 0;
            flatTextBox_secondary.Size = new System.Drawing.Size(167, 23);
            flatTextBox_secondary.TabIndex = 8;
            flatTextBox_secondary.Tag = "panel_secondary";
            flatTextBox_secondary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_secondary.WordWrap = true;
            flatTextBox_secondary.TextChanged += ColorValueChanged;
            // 
            // flatTextBox_primary
            // 
            flatTextBox_primary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_primary.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_primary.DisplayBorder = true;
            flatTextBox_primary.Location = new System.Drawing.Point(124, 63);
            flatTextBox_primary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_primary.MaxLength = 32767;
            flatTextBox_primary.Multiline = false;
            flatTextBox_primary.Name = "flatTextBox_primary";
            flatTextBox_primary.OnTextChanged = null;
            flatTextBox_primary.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_primary.ReadOnly = false;
            flatTextBox_primary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_primary.SelectionStart = 0;
            flatTextBox_primary.Size = new System.Drawing.Size(167, 23);
            flatTextBox_primary.TabIndex = 7;
            flatTextBox_primary.Tag = "panel_primary";
            flatTextBox_primary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_primary.WordWrap = true;
            flatTextBox_primary.TextChanged += ColorValueChanged;
            // 
            // flatTextBox_background
            // 
            flatTextBox_background.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_background.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_background.DisplayBorder = true;
            flatTextBox_background.Location = new System.Drawing.Point(124, 33);
            flatTextBox_background.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_background.MaxLength = 32767;
            flatTextBox_background.Multiline = false;
            flatTextBox_background.Name = "flatTextBox_background";
            flatTextBox_background.OnTextChanged = null;
            flatTextBox_background.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_background.ReadOnly = false;
            flatTextBox_background.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_background.SelectionStart = 0;
            flatTextBox_background.Size = new System.Drawing.Size(167, 23);
            flatTextBox_background.TabIndex = 6;
            flatTextBox_background.Tag = "panel_background";
            flatTextBox_background.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_background.WordWrap = true;
            flatTextBox_background.TextChanged += ColorValueChanged;
            // 
            // flatTextBox_text
            // 
            flatTextBox_text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_text.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_text.DisplayBorder = true;
            flatTextBox_text.Location = new System.Drawing.Point(124, 3);
            flatTextBox_text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_text.MaxLength = 32767;
            flatTextBox_text.Multiline = false;
            flatTextBox_text.Name = "flatTextBox_text";
            flatTextBox_text.OnTextChanged = null;
            flatTextBox_text.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_text.ReadOnly = false;
            flatTextBox_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_text.SelectionStart = 0;
            flatTextBox_text.Size = new System.Drawing.Size(167, 23);
            flatTextBox_text.TabIndex = 5;
            flatTextBox_text.Tag = "panel_text";
            flatTextBox_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_text.WordWrap = true;
            flatTextBox_text.TextChanged += ColorValueChanged;
            // 
            // label_accent
            // 
            label_accent.AutoSize = true;
            label_accent.Location = new System.Drawing.Point(4, 127);
            label_accent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_accent.Name = "label_accent";
            label_accent.Size = new System.Drawing.Size(47, 15);
            label_accent.TabIndex = 4;
            label_accent.Text = "Accent:";
            // 
            // label_secondary_outline
            // 
            label_secondary_outline.AutoSize = true;
            label_secondary_outline.Location = new System.Drawing.Point(4, 97);
            label_secondary_outline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_secondary_outline.Name = "label_secondary_outline";
            label_secondary_outline.Size = new System.Drawing.Size(107, 15);
            label_secondary_outline.TabIndex = 3;
            label_secondary_outline.Text = "Secondary Outline:";
            // 
            // label_primary_outline
            // 
            label_primary_outline.AutoSize = true;
            label_primary_outline.Location = new System.Drawing.Point(4, 67);
            label_primary_outline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_primary_outline.Name = "label_primary_outline";
            label_primary_outline.Size = new System.Drawing.Size(93, 15);
            label_primary_outline.TabIndex = 2;
            label_primary_outline.Text = "Primary Outline:";
            // 
            // label_background
            // 
            label_background.AutoSize = true;
            label_background.Location = new System.Drawing.Point(4, 37);
            label_background.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_background.Name = "label_background";
            label_background.Size = new System.Drawing.Size(74, 15);
            label_background.TabIndex = 1;
            label_background.Text = "Background:";
            // 
            // label_text
            // 
            label_text.AutoSize = true;
            label_text.Location = new System.Drawing.Point(4, 7);
            label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_text.Name = "label_text";
            label_text.Size = new System.Drawing.Size(31, 15);
            label_text.TabIndex = 0;
            label_text.Text = "Text:";
            // 
            // btn_add
            // 
            btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_add.Location = new System.Drawing.Point(201, 14);
            btn_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(70, 24);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_remove.Location = new System.Drawing.Point(278, 14);
            btn_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(70, 24);
            btn_remove.TabIndex = 4;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // button_apply
            // 
            button_apply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button_apply.Location = new System.Drawing.Point(260, 255);
            button_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_apply.Name = "button_apply";
            button_apply.Size = new System.Drawing.Size(88, 27);
            button_apply.TabIndex = 5;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // flatTextBox_name
            // 
            flatTextBox_name.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flatTextBox_name.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            flatTextBox_name.DisplayBorder = true;
            flatTextBox_name.Location = new System.Drawing.Point(14, 45);
            flatTextBox_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flatTextBox_name.MaxLength = 32767;
            flatTextBox_name.Multiline = false;
            flatTextBox_name.Name = "flatTextBox_name";
            flatTextBox_name.OnTextChanged = null;
            flatTextBox_name.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            flatTextBox_name.ReadOnly = false;
            flatTextBox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            flatTextBox_name.SelectionStart = 0;
            flatTextBox_name.Size = new System.Drawing.Size(334, 23);
            flatTextBox_name.TabIndex = 6;
            flatTextBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            flatTextBox_name.WordWrap = true;
            flatTextBox_name.TextChanged += flatTextBox_name_TextChanged;
            // 
            // comboBox_theme
            // 
            comboBox_theme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_theme.FormattingEnabled = true;
            comboBox_theme.Location = new System.Drawing.Point(14, 14);
            comboBox_theme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_theme.Name = "comboBox_theme";
            comboBox_theme.Size = new System.Drawing.Size(179, 23);
            comboBox_theme.TabIndex = 1;
            comboBox_theme.SelectedIndexChanged += comboBox_theme_SelectedIndexChanged;
            // 
            // ThemeEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 316);
            Controls.Add(flatTextBox_name);
            Controls.Add(button_apply);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(groupBox_colors);
            Controls.Add(comboBox_theme);
            Controls.Add(statusStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(378, 355);
            MinimumSize = new System.Drawing.Size(378, 355);
            Name = "ThemeEditor";
            Tag = "";
            Text = "Themes";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            groupBox_colors.ResumeLayout(false);
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private CustomControls.FlatComboBox comboBox_theme;
        private System.Windows.Forms.GroupBox groupBox_colors;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label label_secondary_outline;
        private System.Windows.Forms.Label label_primary_outline;
        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.Label label_accent;
        private CustomControls.FlatTextBox flatTextBox_accent;
        private CustomControls.FlatTextBox flatTextBox_secondary;
        private CustomControls.FlatTextBox flatTextBox_primary;
        private CustomControls.FlatTextBox flatTextBox_background;
        private CustomControls.FlatTextBox flatTextBox_text;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.Panel panel_accent;
        private System.Windows.Forms.Panel panel_secondary;
        private System.Windows.Forms.Panel panel_primary;
        private System.Windows.Forms.Panel panel_background;
        private CustomControls.FlatTextBox flatTextBox_name;
        private System.Windows.Forms.ToolStripDropDownButton button_export;
        private System.Windows.Forms.ToolStripMenuItem menuItem_export_current;
        private System.Windows.Forms.ToolStripMenuItem menuItem_export_all;
        private System.Windows.Forms.ToolStripDropDownButton button_import;
        private System.Windows.Forms.ToolStripMenuItem menuItem_import_theme;
        private System.Windows.Forms.ToolStripMenuItem menuItem_import_multiple;
    }
}