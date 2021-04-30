using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFLaba8.Infrastructure;

namespace WFLaba8
{
    public partial class Form1 : Form
    {
        private TextBox _tbText;
        private IStorage _storage;
        private CheckBox _cbCrimea;
        private CheckBox _cbDonbas;

        public Form1() => this.Init();

        private void Form1_Load(object sender, EventArgs e) => this.LoadForm();

        private async void LoadForm()
        {
            var content = await _storage.UploadAsync();
            if (content is null)
                return;
            this.Location = content.Position;
            this.Size = content.Size;
            this._tbText.Text = content.TextBox;
            this._cbCrimea.Checked = content.CheckBox[0];
            this._cbDonbas.Checked = content.CheckBox[1];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => this.SaveForm();

        private void SaveForm()
        {
            var content = new Content(this.Location, this.Size, this._tbText.Text, new bool[2]
            {
                this._cbCrimea.Checked,
                this._cbDonbas.Checked
            });
            _storage.DownloadAsync(content);
        }

        private void Init()
        {
            _storage = new FileStorage();
            this._tbText = new TextBox();
            this._cbCrimea = new CheckBox();
            this._cbDonbas = new CheckBox();
            this.SuspendLayout();
            this._tbText.Location = new Point(12, 12);
            this._tbText.Name = "txtBox";
            this._tbText.Size = new Size(202, 22);
            this._tbText.TabIndex = 0;



            this._cbCrimea.AutoSize = true;
            this._cbCrimea.Location = new Point(12, 40);
            this._cbCrimea.ForeColor = Color.Blue;
            this._cbCrimea.Name = "cbCrimea";
            this._cbCrimea.Size = new Size(98, 21);
            this._cbCrimea.TabIndex = 1;
            this._cbCrimea.Text = "Крим - це Україна!";
            this._cbCrimea.UseVisualStyleBackColor = true;

            this._cbDonbas.AutoSize = true;
            this._cbDonbas.Location = new Point(12, 60);
            this._cbDonbas.ForeColor = Color.Yellow;
            this._cbDonbas.Name = "cbDonbas";
            this._cbDonbas.Size = new Size(98, 21);
            this._cbDonbas.TabIndex = 2;
            this._cbDonbas.Text = "Донбас - це Україна!";
            this._cbDonbas.UseVisualStyleBackColor = true;



            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(246, 88);
            this.Controls.Add((Control)this._cbDonbas);
            this.Controls.Add((Control)this._cbCrimea);
            this.Controls.Add((Control)this._tbText);
            this.Name = nameof(Form1);
            this.BackColor = Color.Gray;
            this.Text = nameof(Form1);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
