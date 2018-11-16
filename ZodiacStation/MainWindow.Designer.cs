﻿using MaterialSkin;
using MaterialSkin.Controls;


namespace ZodiacStation
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DronePanel = new System.Windows.Forms.Panel();
            this.DroneList_Panel2 = new System.Windows.Forms.Panel();
            this.DroneTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddDrone = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel3 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Drone_Spacer = new System.Windows.Forms.Panel();
            this.DronePanel.SuspendLayout();
            this.DroneList_Panel2.SuspendLayout();
            this.DroneTable.SuspendLayout();
            this.DroneList_Panel3.SuspendLayout();
            this.Drone_Spacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DronePanel
            // 
            this.DronePanel.BackColor = System.Drawing.Color.Transparent;
            this.DronePanel.Controls.Add(this.DroneList_Panel2);
            this.DronePanel.Controls.Add(this.Drone_Spacer);
            this.DronePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DronePanel.Location = new System.Drawing.Point(0, 0);
            this.DronePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DronePanel.Name = "DronePanel";
            this.DronePanel.Size = new System.Drawing.Size(278, 1080);
            this.DronePanel.TabIndex = 0;
            // 
            // DroneList_Panel2
            // 
            this.DroneList_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DroneList_Panel2.Controls.Add(this.DroneTable);
            this.DroneList_Panel2.Controls.Add(this.DroneList_Panel3);
            this.DroneList_Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DroneList_Panel2.Location = new System.Drawing.Point(0, 64);
            this.DroneList_Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.DroneList_Panel2.Name = "DroneList_Panel2";
            this.DroneList_Panel2.Size = new System.Drawing.Size(278, 1016);
            this.DroneList_Panel2.TabIndex = 1;
            // 
            // DroneTable
            // 
            this.DroneTable.AutoScroll = true;
            this.DroneTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DroneTable.ColumnCount = 1;
            this.DroneTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DroneTable.Controls.Add(this.AddDrone, 0, 0);
            this.DroneTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.DroneTable.ForeColor = System.Drawing.Color.Transparent;
            this.DroneTable.Location = new System.Drawing.Point(0, 0);
            this.DroneTable.Margin = new System.Windows.Forms.Padding(0);
            this.DroneTable.Name = "DroneTable";
            this.DroneTable.RowCount = 2;
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 874F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DroneTable.Size = new System.Drawing.Size(250, 80);
            this.DroneTable.TabIndex = 2;
            this.DroneTable.Paint += new System.Windows.Forms.PaintEventHandler(this.DroneTable_Paint);
            // 
            // AddDrone
            // 
            this.AddDrone.AutoSize = true;
            this.AddDrone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddDrone.BackColor = System.Drawing.Color.White;
            this.AddDrone.Depth = 0;
            this.AddDrone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDrone.Font = new System.Drawing.Font("苹方 常规", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddDrone.ForeColor = System.Drawing.Color.Transparent;
            this.AddDrone.Icon = null;
            this.AddDrone.Location = new System.Drawing.Point(0, 0);
            this.AddDrone.Margin = new System.Windows.Forms.Padding(0);
            this.AddDrone.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDrone.Name = "AddDrone";
            this.AddDrone.Primary = false;
            this.AddDrone.Size = new System.Drawing.Size(250, 40);
            this.AddDrone.TabIndex = 0;
            this.AddDrone.Text = "＋";
            this.AddDrone.UseVisualStyleBackColor = false;
            this.AddDrone.Click += new System.EventHandler(this.AddDrone_Click);
            // 
            // DroneList_Panel3
            // 
            this.DroneList_Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DroneList_Panel3.Controls.Add(this.ShwoDronesBtn);
            this.DroneList_Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.DroneList_Panel3.Location = new System.Drawing.Point(250, 0);
            this.DroneList_Panel3.Name = "DroneList_Panel3";
            this.DroneList_Panel3.Size = new System.Drawing.Size(28, 1016);
            this.DroneList_Panel3.TabIndex = 1;
            // 
            // ShwoDronesBtn
            // 
            this.ShwoDronesBtn.AutoSize = true;
            this.ShwoDronesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShwoDronesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShwoDronesBtn.Depth = 0;
            this.ShwoDronesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShwoDronesBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ShwoDronesBtn.Icon = null;
            this.ShwoDronesBtn.Location = new System.Drawing.Point(0, 0);
            this.ShwoDronesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ShwoDronesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShwoDronesBtn.Name = "ShwoDronesBtn";
            this.ShwoDronesBtn.Primary = false;
            this.ShwoDronesBtn.Size = new System.Drawing.Size(28, 1016);
            this.ShwoDronesBtn.TabIndex = 1;
            this.ShwoDronesBtn.Text = "◀";
            this.ShwoDronesBtn.UseVisualStyleBackColor = false;
            this.ShwoDronesBtn.Click += new System.EventHandler(this.ShwoDronesBtn_Click);
            // 
            // Drone_Spacer
            // 
            this.Drone_Spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drone_Spacer.Location = new System.Drawing.Point(0, 0);
            this.Drone_Spacer.Margin = new System.Windows.Forms.Padding(0);
            this.Drone_Spacer.Name = "Drone_Spacer";
            this.Drone_Spacer.Size = new System.Drawing.Size(278, 64);
            this.Drone_Spacer.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.DronePanel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zodiac Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DronePanel.ResumeLayout(false);
            this.DroneList_Panel2.ResumeLayout(false);
            this.DroneTable.ResumeLayout(false);
            this.DroneTable.PerformLayout();
            this.DroneList_Panel3.ResumeLayout(false);
            this.DroneList_Panel3.PerformLayout();
            this.Drone_Spacer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DronePanel;
        private System.Windows.Forms.Panel DroneList_Panel2;
        private System.Windows.Forms.Panel Drone_Spacer;
        private MaterialFlatButton ShwoDronesBtn;
        private System.Windows.Forms.Panel DroneList_Panel3;
        private System.Windows.Forms.TableLayoutPanel DroneTable;
        private MaterialFlatButton AddDrone;
    }
}

