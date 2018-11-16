using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ZodiacStation
{
    public partial class MainWindow : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private bool ShowDrone;
        MaterialFlatButton materialFlatButton1;


        public MainWindow()
        {
            InitializeComponent();
            ShowDrone = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialFlatButton1 = new MaterialFlatButton();
            materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialFlatButton1.Depth = 0;
            materialFlatButton1.Icon = null;
            materialFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton1.Name = "materialFlatButton1";
            materialFlatButton1.Primary = false;
            materialFlatButton1.Size = new System.Drawing.Size(250, 37);
            materialFlatButton1.TabIndex = 2;
            materialFlatButton1.Text = "+";
            materialFlatButton1.UseVisualStyleBackColor = true;

            //materialFlatButton1.Location = new System.Drawing.Point(DroneList.Items[3].Position.X, DroneList.Items[3].Position.Y);

        }

        private void ShwoDronesBtn_Click(object sender, EventArgs e)
        {
            ShowDrone = !ShowDrone;
            if (ShowDrone)
            {
                this.ShwoDronesBtn.Text = "◀";
                DronePanel.Width = 278;
                DroneTable.Width = 250;
            }
            else
            {
                this.ShwoDronesBtn.Text = "▶";
                DronePanel.Width = 28;
                DroneTable.Width = 0;
            }
        }

        private void AddDrone_Click(object sender, EventArgs e)
        {

            DroneTable.RowCount++;
            //设置高度
            //DroneTable.Height = DroneTable.RowCount * 40;
            // 行高
            DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20));
            DroneTable.RowStyles[DroneTable.RowCount].Height =40;
            DroneTable.RowStyles[0].Height = 0;
            int i = DroneTable.RowCount - 1;



            TextBox outc = new TextBox();
            outc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            outc.TextAlign = HorizontalAlignment.Center;
            outc.Text = "out-" + i;
            MaterialLabel temp = new MaterialLabel();
            temp.Text = "count";
            DroneTable.Controls.Add(temp, 0, DroneTable.RowCount-1);
            DroneTable.Controls.Add(AddDrone, 0, DroneTable.RowCount);


        }

    }
}
