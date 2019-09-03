/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Asus
 * Tarih: 29.08.2019
 * Zaman: 12:57
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace gravity
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.shapedButton2 = new gravity.ShapedButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.shapedButton1 = new gravity.ShapedButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 25;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// shapedButton2
			// 
			this.shapedButton2.BackColor = System.Drawing.Color.Yellow;
			this.shapedButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shapedButton2.BackgroundImage")));
			this.shapedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.shapedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.shapedButton2.ForeColor = System.Drawing.Color.Yellow;
			this.shapedButton2.Location = new System.Drawing.Point(413, 193);
			this.shapedButton2.Name = "shapedButton2";
			this.shapedButton2.Size = new System.Drawing.Size(160, 167);
			this.shapedButton2.TabIndex = 1;
			this.shapedButton2.Text = "55";
			this.shapedButton2.UseVisualStyleBackColor = false;
			this.shapedButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.shapedButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.shapedButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(555, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "seçici";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(553, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "yük";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Ay",
									"Dünya"});
			this.comboBox1.Location = new System.Drawing.Point(659, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(91, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(659, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(659, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 31);
			this.button1.TabIndex = 8;
			this.button1.Text = "ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// shapedButton1
			// 
			this.shapedButton1.BackColor = System.Drawing.Color.Red;
			this.shapedButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shapedButton1.BackgroundImage")));
			this.shapedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.shapedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.shapedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.shapedButton1.Location = new System.Drawing.Point(213, 98);
			this.shapedButton1.Name = "shapedButton1";
			this.shapedButton1.Size = new System.Drawing.Size(148, 132);
			this.shapedButton1.TabIndex = 0;
			this.shapedButton1.Text = "1";
			this.shapedButton1.UseVisualStyleBackColor = false;
			this.shapedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.shapedButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.shapedButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(650, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "uzaklık";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(650, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 21);
			this.label4.TabIndex = 10;
			this.label4.Text = "uzaklık";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(650, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 21);
			this.label5.TabIndex = 11;
			this.label5.Text = "uzaklık";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(650, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 21);
			this.label6.TabIndex = 12;
			this.label6.Text = "uzaklık";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(650, 300);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(175, 21);
			this.label8.TabIndex = 15;
			this.label8.Text = "uzaklık";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(650, 332);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(175, 21);
			this.label9.TabIndex = 16;
			this.label9.Text = "uzaklık";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 425);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shapedButton2);
			this.Controls.Add(this.shapedButton1);
			this.Name = "MainForm";
			this.Text = "gravity";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private gravity.ShapedButton shapedButton2;
		private gravity.ShapedButton shapedButton1;
		private System.Windows.Forms.Timer timer1;
	}
}
