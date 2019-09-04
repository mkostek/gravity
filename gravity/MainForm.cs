/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Asus
 * Tarih: 29.08.2019
 * Zaman: 12:57
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace gravity
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		int aci=0;
		int distance;
		bool bayrak=false;
		bool suruklenmedurumu = false; //Class seviyesinde bir field(değişken) tanımlıyoruz ki,MouseDown da biz bunu true yapacağız,MouseUpta false değerini alacak ve MouseMove eventında true ise hareket edecek.
		Point ilkkonum; //Global bir değişken tanımlıyoruz ki, ilk tıkladığımız andaki konumunu çıkarmadığımızda buton mouse imlecinden daha aşağıdan hareket edecektir.
		private void Down(object sender, MouseEventArgs e)
		{
			dur();
			suruklenmedurumu = true; //işlemi burada true diyerek başlatıyoruz.
			((ShapedButton)sender).Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü vermek için
			ilkkonum = e.Location; //İlk konuma gördüğünüz gibi değerimizi atıyoruz.
			
		}
		private void Move(object sender, MouseEventArgs e)
		{
			if (suruklenmedurumu) // suruklenmedurumu==true ile aynı.
			{
				((ShapedButton)sender).Left = e.X + ((ShapedButton)sender).Left - (ilkkonum.X);
				// button.left ile soldan uzaklığını ayarlıyoruz. Yani e.X dediğimizde buton üzerinde mouseun hareket ettiği pixeli alacağız + butonun soldan uzaklığını ekliyoruz son olarakta ilk mouseın tıklandığı alanı çıkarıyoruz yoksa butonun en solunda olur mouse imleci. Alttakide aynı şekilde Y koordinati için geçerli
				((ShapedButton)sender).Top = e.Y + ((ShapedButton)sender).Top - (ilkkonum.Y);
				//chart1.Series[0].Points.Add(kuvvet());
			}
			label9.Text="mutlak uzaklık"+uzaklık(shapedButton1,shapedButton2).ToString();
			
		}
		private void Up(object sender, MouseEventArgs e)
		{
			basla();
			suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
			((ShapedButton)sender).Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			switch(comboBox1.SelectedIndex){
					case 1:
					//shapedButton2.Width=(int)(Convert.ToDouble(textBox1.Text)*1.5);
					//shapedButton2.Height=(int)(Convert.ToDouble(textBox1.Text)*1.5);
					shapedButton2.Text=textBox1.Text;
					break;
					case 0:
					//shapedButton1.Width=(int)(Convert.ToDouble(textBox1.Text)*1.5);
					//shapedButton1.Height=(int)(Convert.ToDouble(textBox1.Text)*1.5);
					shapedButton1.Text=textBox1.Text;
					break;
					default:break;
			}
			//chartBirinciDerece.Series[0].Points.Clear();
		//	chartBirinciDerece.Series[1].Points.Clear();
			
		//	chart1.Series[0].Points.Clear();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			timer1.Start();
			distance=uzaklık(shapedButton1,shapedButton2);
		}
		public int uzaklık(ShapedButton x,ShapedButton y){
			return (int)Math.Sqrt(Math.Pow(x.Location.X+(int)x.Width/2-y.Location.X-(int)y.Width/2,2)+Math.Pow(y.Location.Y+(int)y.Height/2-x.Location.Y-(int)x.Height/2,2));
			
		}
		public void dur(){
			timer1.Stop();
			
		}
		public void basla(){
			if(uzaklık(shapedButton1,shapedButton2)>(shapedButton1.Width/2+shapedButton2.Width/2))
			distance=uzaklık(shapedButton1,shapedButton2);
			timer1.Start();
			
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			label6.Text="birinci küre konumu:"+shapedButton1.Location.X+":"+shapedButton1.Location.Y;
			label8.Text="ikinci küre konumu:"+shapedButton2.Location.X+":"+shapedButton2.Location.Y;
			
			Point m,n;
			int x;
			int y;
			n=new Point();
			if(aci==360)aci=0;
			label3.Text=distance.ToString();
			
			if(Convert.ToDouble(shapedButton1.Text)>Convert.ToDouble(shapedButton2.Text)){
				if(bayrak){
					aci+=180;
					aci=aci%360;
					bayrak=false;
				}
				//n=shapedButton1.Location
				x=shapedButton1.Location.X+(int)shapedButton1.Width/2;
				y=shapedButton1.Location.Y+(int)shapedButton1.Height/2;
				m=shapedButton1.Location;
				n.X=(int)(x+distance*Math.Cos(aci*(Math.PI / 180))-shapedButton2.Width/2);
				n.Y=(int)(y+distance*Math.Sin(aci*(Math.PI / 180))-shapedButton2.Height/2);
				label4.Text="aci degeri:"+aci.ToString();
				aci++;
				shapedButton2.Location=n;
				double d=Math.Sqrt(distance)*distance/Convert.ToDouble(shapedButton1.Text);
				label5.Text="acisal frekans:"+d;
				timer1.Interval=(int)d;
			//	label6.Text=((double)(Math.Pow(distance,3)/(shapedButton1.Width*shapedButton1.Height))).ToString();
			}else if(Convert.ToDouble(shapedButton1.Text)<Convert.ToDouble(shapedButton2.Text)){
				if(!bayrak){
					aci+=180;
					aci=aci%360;
					bayrak=true;
				}
				x=shapedButton2.Location.X+(int)shapedButton2.Width/2;
				y=shapedButton2.Location.Y+(int)shapedButton2.Height/2;
				m=shapedButton2.Location;
				n.X=(int)(x+distance*Math.Cos(aci*(Math.PI / 180))-shapedButton1.Width/2);
				n.Y=(int)(y+distance*Math.Sin(aci*(Math.PI / 180))-shapedButton1.Height/2);
				label4.Text="aci degeri:"+aci.ToString();
				aci++;
				shapedButton1.Location=n;
				double d=Math.Sqrt(distance)*distance/Convert.ToDouble(shapedButton2.Text);
				label5.Text="acisal frekans:"+d.ToString();
				timer1.Interval=(int)d;
				//label6.Text=((double)(Math.Pow(distance,3)/(shapedButton2.Width*shapedButton2.Height))).ToString();
			}
			
		}
		
	}
	public class ShapedButton : Button //Buton sınıfından miras alınıyor
	{
		// Elips buton a yeni bir boyut  verildiğinde şeklini elips yapıyor
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			GraphicsPath gp = new GraphicsPath();
			// this.Size ın en boyu aynı oldugundan elips bir şekil oluşuyor
			gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
			// oluşan yeni elips şekli oluşturulan butona atanıyor
			this.Region = new Region(gp);
			// Butonun yeni şekli elips oluyor
		}
	}
}
