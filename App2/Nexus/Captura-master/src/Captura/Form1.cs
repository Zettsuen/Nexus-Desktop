using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using Captura.ViewModels;

namespace lecturadeveu
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine escolta = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                escolta.SetInputToDefaultAudioDevice();
                escolta.LoadGrammar(new DictationGrammar());
                escolta.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Lector);
                escolta.RecognizeAsync(RecognizeMode.Multiple);

                Captura.App app = new Captura.App();
                app.InitializeComponent();
                app.Run();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("NO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        Boolean segons = true; //Utilitzo aquesta variable per contar els 30 segons

        public void Lector(object sender, SpeechRecognizedEventArgs e)
        {
            String nexussube = "";
           

            foreach (RecognizedWordUnit paraula in e.Result.Words)
            {
                label3.Text += paraula.Text;
                nexussube += paraula.Text;

                if (segons == true)
                {
                    if (nexussube == "lexusV." || nexussube == "ynexosV." || nexussube == "lexussobre" || nexussube == "nexossuvez" || nexussube == "nexosV." || nexussube == "lessuben" || nexussube == "lexussuben" || nexussube == "nexossobre" || nexussube == "nexosuren" || nexussube == "lexussube" || nexussube == "nexussube" || nexussube == "mesessobre" || nexussube == "nexosobre" || nexussube == "nexossuben" || nexussube == "nexossube" || nexussube == "lexussuvez" || nexussube == "naxossobre" || nexussube == "dexeussube" || nexussube == "lexussupe" || nexussube == "nexoshube" || nexussube == "lexusasuvez" || nexussube == "elluxussobre" || nexussube == "lluxussobre" || nexussube == "elluxussuvez" || nexussube == "ellexussobre")
                    {
                        label2.Text = "COMANDO CORRECTO";
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\jordi\source\repos\lecturadeveu\lecturadeveu\upload_success.wav");
                        player.Play();
                        timer1.Start();
                        segons = false;
                        NotiForm notificacio = new NotiForm("¡LISTO! Tu clip se está procesando...",Color.FromArgb(63, 34, 82));
                        notificacio.Show();
                        //RecordingModel.StopRecording();


                    }
                    else
                    {
                        label2.Text = "COMANDO INCORRECTO";
                    }
                }

                
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = "30 SEGUNDOS VUELVE A FUNCIONAR";
            segons = true;
            timer1.Stop();
        }

    }
}
