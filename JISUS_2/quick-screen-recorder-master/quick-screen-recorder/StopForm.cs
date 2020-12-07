using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace quick_screen_recorder
{
	public partial class StopForm : Form
	{
		private DateTime startTime;
		private SpeechRecognitionEngine escolta = new SpeechRecognitionEngine();
		public StopForm(DateTime startTime, bool darkMode, string videoStr, string audioStr)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.startTime = startTime;

			InitializeComponent();

			mainTimer.Start();

			videoLabel.Text = string.Format(videoLabel.Text, videoStr);
			audioLabel.Text = string.Format(audioLabel.Text, audioStr);

			if (audioStr == "None")
			{
				muteCheckBox.Enabled = false;
			}

			if (darkMode)
			{
				this.ForeColor = Color.White;
				this.BackColor = ThemeManager.DarkBackColor;

				stopButton.BackColor = ThemeManager.DarkSecondColor;
				stopButton.Image = Properties.Resources.white_stop;

				muteCheckBox.SetDarkMode(true);
			}

			optionsGroup.SetDarkMode(darkMode);
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			DateTime tickTime = DateTime.Now;
			TimeSpan result = tickTime - startTime;
			timeLabel.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", result.Minutes, result.Seconds, result.Milliseconds);
			this.Text = string.Format("{0:D2}:{1:D2} - Nexus Clips", result.Minutes, result.Seconds);
		}

		private void recButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StopForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			mainTimer.Stop();
			(Owner as MainForm).StopRec();
			(Owner as MainForm).Show();

			HotkeyManager.UnregisterHotKey(this.Handle, 0);
			HotkeyManager.UnregisterHotKey(this.Handle, 1);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				HotkeyManager.KeyModifier modifier = (HotkeyManager.KeyModifier)((int)m.LParam & 0xFFFF);

				if (modifier == HotkeyManager.KeyModifier.Alt)
				{
					if (key == Keys.R)
					{
						this.Close();
					}
					else if (key == Keys.M)
					{
						muteCheckBox.Checked = !muteCheckBox.Checked;
					}
				}
			}
		}

		private void StopForm_Load(object sender, EventArgs e)
		{
			HotkeyManager.RegisterHotKey(this.Handle, 0, (int)HotkeyManager.KeyModifier.Alt, Keys.R.GetHashCode());
			HotkeyManager.RegisterHotKey(this.Handle, 1, (int)HotkeyManager.KeyModifier.Alt, Keys.M.GetHashCode());
			try
			{
				escolta.SetInputToDefaultAudioDevice();
				escolta.LoadGrammar(new DictationGrammar());
				escolta.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Lector);
				escolta.RecognizeAsync(RecognizeMode.Multiple);
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("NO");
			}

		}
		Boolean segons = true; //Utilitzo aquesta variable per contar els 30 segons
		public void Lector(object sender, SpeechRecognizedEventArgs e)
		{
			String nexussube = "";


			foreach (RecognizedWordUnit paraula in e.Result.Words)
			{
		
				nexussube += paraula.Text;

				if (segons == true)
				{
					if (nexussube == "lexusV." || nexussube == "ynexosV." || nexussube == "lexussobre" || nexussube == "nexossuvez" || nexussube == "nexosV." || nexussube == "lessuben" || nexussube == "lexussuben" || nexussube == "nexossobre" || nexussube == "nexosuren" || nexussube == "lexussube" || nexussube == "nexussube" || nexussube == "mesessobre" || nexussube == "nexosobre" || nexussube == "nexossuben" || nexussube == "nexossube" || nexussube == "lexussuvez" || nexussube == "naxossobre" || nexussube == "dexeussube" || nexussube == "lexussupe" || nexussube == "nexoshube" || nexussube == "lexusasuvez" || nexussube == "elluxussobre" || nexussube == "lluxussobre" || nexussube == "elluxussuvez" || nexussube == "ellexussobre")
					{
						
						System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\jordi\source\repos\lecturadeveu\lecturadeveu\upload_success.wav");
						player.Play();
						timer1.Start();
						segons = false;
						NotiForm notificacio = new NotiForm("¡LISTO! Tu clip se está procesando...", Color.FromArgb(63, 34, 82));
						notificacio.Show();
						this.Close();
					}
					else
					{
						//label2.Text = "COMANDO INCORRECTO";
					}
				}


			}


		}

		public void UpdateVolumeBar(int volume)
		{
			try
			{
				int destVolume = volume;

				if (destVolume > progressBar1.Maximum)
				{
					destVolume = progressBar1.Maximum;
				}
				else if (destVolume < progressBar1.Minimum)
				{
					destVolume = progressBar1.Minimum;
				}

				progressBar1.Invoke((MethodInvoker)(() => {
					progressBar1.Value = destVolume;
				}));
			}
			catch
			{

			}
		}

		private void muteCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Console.WriteLine("a");
			(this.Owner as MainForm).MuteRecorder(muteCheckBox.Checked);
		}
	}
}
