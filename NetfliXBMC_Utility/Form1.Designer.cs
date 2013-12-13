namespace NetfliXBMC_Utility
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyClose = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxKeyConfigure = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxKeyDoubleClick = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxKeyClick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKeyDownRight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKeyDownLeft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKeyUpRight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKeyUpLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKeyRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKeyDown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKeyLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKeyUp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKeyVolumeDown = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxKeySeekBackward = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxKeySeekForward = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxKeyVolumeUp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxKeyPlayPause = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Navigate via Up/Down and map your keys   |   Press Enter to clear mapping or to s" +
    "ave/cancel";
            // 
            // textBoxKeyClose
            // 
            this.textBoxKeyClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyClose.Location = new System.Drawing.Point(344, 277);
            this.textBoxKeyClose.Name = "textBoxKeyClose";
            this.textBoxKeyClose.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyClose.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(309, 29);
            this.label23.TabIndex = 111;
            this.label23.Text = "Close Browser (ALT+F4):";
            // 
            // textBoxKeyConfigure
            // 
            this.textBoxKeyConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyConfigure.Location = new System.Drawing.Point(344, 318);
            this.textBoxKeyConfigure.Name = "textBoxKeyConfigure";
            this.textBoxKeyConfigure.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyConfigure.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(286, 29);
            this.label15.TabIndex = 110;
            this.label15.Text = "Configure KeyMapping:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(578, 515);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 35);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button_PreviewKeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(416, 515);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 35);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button_PreviewKeyDown);
            // 
            // textBoxKeyDoubleClick
            // 
            this.textBoxKeyDoubleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyDoubleClick.Location = new System.Drawing.Point(883, 441);
            this.textBoxKeyDoubleClick.Name = "textBoxKeyDoubleClick";
            this.textBoxKeyDoubleClick.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyDoubleClick.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(632, 444);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(247, 29);
            this.label22.TabIndex = 131;
            this.label22.Text = "Mouse DoubleClick:";
            // 
            // textBoxKeyClick
            // 
            this.textBoxKeyClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyClick.Location = new System.Drawing.Point(883, 400);
            this.textBoxKeyClick.Name = "textBoxKeyClick";
            this.textBoxKeyClick.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyClick.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 130;
            this.label9.Text = "Mouse Click:";
            // 
            // textBoxKeyDownRight
            // 
            this.textBoxKeyDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyDownRight.Location = new System.Drawing.Point(883, 359);
            this.textBoxKeyDownRight.Name = "textBoxKeyDownRight";
            this.textBoxKeyDownRight.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyDownRight.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 29);
            this.label8.TabIndex = 129;
            this.label8.Text = "Mouse DownRight:";
            // 
            // textBoxKeyDownLeft
            // 
            this.textBoxKeyDownLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyDownLeft.Location = new System.Drawing.Point(883, 318);
            this.textBoxKeyDownLeft.Name = "textBoxKeyDownLeft";
            this.textBoxKeyDownLeft.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyDownLeft.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 29);
            this.label7.TabIndex = 128;
            this.label7.Text = "Mouse DownLeft:";
            // 
            // textBoxKeyUpRight
            // 
            this.textBoxKeyUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyUpRight.Location = new System.Drawing.Point(883, 277);
            this.textBoxKeyUpRight.Name = "textBoxKeyUpRight";
            this.textBoxKeyUpRight.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyUpRight.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 127;
            this.label6.Text = "Mouse UpRight:";
            // 
            // textBoxKeyUpLeft
            // 
            this.textBoxKeyUpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyUpLeft.Location = new System.Drawing.Point(883, 236);
            this.textBoxKeyUpLeft.Name = "textBoxKeyUpLeft";
            this.textBoxKeyUpLeft.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyUpLeft.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 126;
            this.label5.Text = "Mouse UpLeft:";
            // 
            // textBoxKeyRight
            // 
            this.textBoxKeyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyRight.Location = new System.Drawing.Point(883, 195);
            this.textBoxKeyRight.Name = "textBoxKeyRight";
            this.textBoxKeyRight.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyRight.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 125;
            this.label4.Text = "Mouse Right:";
            // 
            // textBoxKeyDown
            // 
            this.textBoxKeyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyDown.Location = new System.Drawing.Point(883, 113);
            this.textBoxKeyDown.Name = "textBoxKeyDown";
            this.textBoxKeyDown.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyDown.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 124;
            this.label2.Text = "Mouse Down:";
            // 
            // textBoxKeyLeft
            // 
            this.textBoxKeyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyLeft.Location = new System.Drawing.Point(883, 154);
            this.textBoxKeyLeft.Name = "textBoxKeyLeft";
            this.textBoxKeyLeft.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyLeft.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 123;
            this.label3.Text = "Mouse Up:";
            // 
            // textBoxKeyUp
            // 
            this.textBoxKeyUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyUp.Location = new System.Drawing.Point(883, 72);
            this.textBoxKeyUp.Name = "textBoxKeyUp";
            this.textBoxKeyUp.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyUp.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 29);
            this.label10.TabIndex = 122;
            this.label10.Text = "Mouse Left:";
            // 
            // textBoxKeyVolumeDown
            // 
            this.textBoxKeyVolumeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyVolumeDown.Location = new System.Drawing.Point(344, 236);
            this.textBoxKeyVolumeDown.Name = "textBoxKeyVolumeDown";
            this.textBoxKeyVolumeDown.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyVolumeDown.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 29);
            this.label11.TabIndex = 133;
            this.label11.Text = "Volume Down (Down):";
            // 
            // textBoxKeySeekBackward
            // 
            this.textBoxKeySeekBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeySeekBackward.Location = new System.Drawing.Point(344, 113);
            this.textBoxKeySeekBackward.Name = "textBoxKeySeekBackward";
            this.textBoxKeySeekBackward.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeySeekBackward.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 29);
            this.label12.TabIndex = 139;
            this.label12.Text = "Seek Backward (Left):";
            // 
            // textBoxKeySeekForward
            // 
            this.textBoxKeySeekForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeySeekForward.Location = new System.Drawing.Point(344, 154);
            this.textBoxKeySeekForward.Name = "textBoxKeySeekForward";
            this.textBoxKeySeekForward.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeySeekForward.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(270, 29);
            this.label13.TabIndex = 137;
            this.label13.Text = "Seek Forward (Right):";
            // 
            // textBoxKeyVolumeUp
            // 
            this.textBoxKeyVolumeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyVolumeUp.Location = new System.Drawing.Point(344, 195);
            this.textBoxKeyVolumeUp.Name = "textBoxKeyVolumeUp";
            this.textBoxKeyVolumeUp.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyVolumeUp.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 29);
            this.label14.TabIndex = 136;
            this.label14.Text = "Volume Up (Up):";
            // 
            // textBoxKeyPlayPause
            // 
            this.textBoxKeyPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyPlayPause.Location = new System.Drawing.Point(344, 72);
            this.textBoxKeyPlayPause.Name = "textBoxKeyPlayPause";
            this.textBoxKeyPlayPause.Size = new System.Drawing.Size(243, 35);
            this.textBoxKeyPlayPause.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 29);
            this.label16.TabIndex = 141;
            this.label16.Text = "Play/Pause (Space/Enter):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.textBoxKeyPlayPause);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxKeySeekBackward);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxKeySeekForward);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxKeyVolumeUp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxKeyVolumeDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxKeyDoubleClick);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxKeyClick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxKeyDownRight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKeyDownLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKeyUpRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKeyUpLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKeyRight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKeyDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKeyLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKeyUp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxKeyClose);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBoxKeyConfigure);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyClose;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxKeyConfigure;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxKeyDoubleClick;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxKeyClick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxKeyDownRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKeyDownLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKeyUpRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeyUpLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKeyRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKeyLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKeyUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKeyVolumeDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxKeySeekBackward;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxKeySeekForward;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxKeyVolumeUp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxKeyPlayPause;
        private System.Windows.Forms.Label label16;
    }
}

