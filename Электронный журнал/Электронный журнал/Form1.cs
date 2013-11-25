using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Электронный_журнал
{
    
    public partial class Form1 : Form
    {
        int TotalAttendanceCount;
        int TotalScoreIncludeExamination;
        int IntroductoryExam;
        int TrackAndFieldExam;
        int BasketballExam;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(label5.Text, out TotalAttendanceCount);
            TotalAttendanceCount++;
            label5.Text =  TotalAttendanceCount.ToString();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            int.TryParse(label5.Text, out TotalAttendanceCount);
            TotalAttendanceCount--;
            label5.Text = TotalAttendanceCount.ToString();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            int DigitDeterminesLetter;
            int.TryParse(textBox4.Text, out IntroductoryExam);
            int.TryParse(textBox5.Text, out TrackAndFieldExam);
            int.TryParse(textBox6.Text, out BasketballExam);
            TotalScoreIncludeExamination = 2 * (TotalAttendanceCount + IntroductoryExam + TrackAndFieldExam + BasketballExam);
            label10.Text = TotalScoreIncludeExamination.ToString();
            int.TryParse(label10.Text, out DigitDeterminesLetter);
            if (DigitDeterminesLetter >= 60 && DigitDeterminesLetter < 65) { label12.Text = "E"; }
            if (DigitDeterminesLetter >= 65 && DigitDeterminesLetter < 70) { label12.Text = "D"; }
            if (DigitDeterminesLetter >= 70 && DigitDeterminesLetter < 85) { label12.Text = "C"; }
            if (DigitDeterminesLetter >= 85 && DigitDeterminesLetter < 90) { label12.Text = "B"; }
            if (DigitDeterminesLetter >= 90 ) { label12.Text = "A"; }
            if (DigitDeterminesLetter > 100) { MessageBox.Show("Былинный успех!"); }
        }

    }
}
