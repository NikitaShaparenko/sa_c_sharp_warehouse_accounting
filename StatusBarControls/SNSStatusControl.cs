using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.StatusBarControls
{
    public partial class SNSStatusControl : UserControl
    {

        List<ServicesList> Waiting_list= new List<ServicesList>() {};

        int lst_percents = -1;
        int percs = 0;

        public SNSStatusControl()
        {
            InitializeComponent();

            picEmailOK.Visible = true;
            picSMSOK.Visible = true;
            picWhatsAppOK.Visible = true;
            picViberOK.Visible = true;
            picTelegramOK.Visible = true;

            picEmailError.Visible = false;
            picSMSError.Visible = false;
            picTelegramError.Visible = false;
            picWhatsAppError.Visible = false;
            picViberError.Visible = false;

            SetAndStartTimer();
            CheckForIllegalCrossThreadCalls = false;

            //picEmailOK.Location = new Point(picEmail.Location.X - picEmailOK.Width / 2, picEmail.Location.Y - picEmailOK.Height / 2);
            //picEmailError.Location = new Point(picEmail.Location.X - picEmailError.Width / 2, picEmail.Location.Y - picEmailError.Height / 2);
            //picTelegramOK.Location = new Point(picTelegram.Location.X - picTelegramOK.Width / 2, picTelegram.Location.Y - picTelegramOK.Height / 2);
            //picTelegramError.Location = new Point(picTelegram.Location.X - picTelegramError.Width / 2, picTelegram.Location.Y - picTelegramError.Height / 2);
            //picSMSOK.Location = new Point(picSMS.Location.X - picSMSOK.Width / 2, picSMS.Location.Y - picSMSOK.Height / 2);
            //picSMSError.Location = new Point(picSMS.Location.X - picSMSError.Width / 2, picSMS.Location.Y - picSMSError.Height / 2);
            //picViberOK.Location = new Point(picViber.Location.X - picViberOK.Width / 2, picViber.Location.Y - picViberOK.Height / 2);
            //picViberError.Location = new Point(picViber.Location.X - picViberError.Width / 2, picViber.Location.Y - picViberError.Height / 2);
            //picWhatsAppOK.Location = new Point(picWhatsApp.Location.X - picWhatsAppOK.Width / 2, picWhatsApp.Location.Y - picWhatsAppOK.Height / 2);
            //picWhatsAppError.Location = new Point(picWhatsApp.Location.X - picWhatsAppError.Width / 2, picWhatsApp.Location.Y - picWhatsAppError.Height / 2);

        }

        Timer timer = new Timer();

        private void SetAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {

            if (count <= percs && count < 100)
            {
                count += 4;
                txtpb.Text = count + "%";

            }

            if (txtpb.Text == "100")
            {
                timer.Stop();
                StandByMode();
            }
        }


        private void SetStatusTelegramOK()
        {
            picTelegramError.Visible = false;
            picTelegramOK.Visible = true;
        }
        private void SetStatusTelegramError()
        {
            picTelegramOK.Visible = false;
            picTelegramError.Visible = true;
        }

        private void SetStatusWhatsAppOK()
        {
            picWhatsAppError.Visible = false;
            picWhatsAppOK.Visible = true;
        }
        private void SetStatusWhatsAppError()
        {
            picWhatsAppOK.Visible = false;
            picWhatsAppError.Visible = true;
        }

        private void SetStatusViberOK()
        {
            picViberError.Visible = false;
            picViberOK.Visible = true;
        }
        private void SetStatusViberError()
        {
            picViberOK.Visible = false;
            picViberError.Visible = true;
        }

        private void SetStatusSMSOK()
        {
            picSMSError.Visible = false;
            picSMSOK.Visible = true;
        }
        private void SetStatusSMSError()
        {
            picSMSOK.Visible = false;
            picSMSError.Visible = true;
        }

        private void SetStatusEmailOK()
        {
            picEmailError.Visible = false;
            picEmailOK.Visible = true;
        }
        private void SetStatusEmailError()
        {
            picEmailOK.Visible = false;
            picEmailError.Visible = true;
        }

        public void AddToWaitingListTelegram()
        {
            Waiting_list.Add(ServicesList.Telegram);
        }

        public void AddToWaitingListWhatsApp()
        {
            Waiting_list.Add(ServicesList.WhatsApp);
        }

        public void AddToWaitingListViber()
        {
            Waiting_list.Add(ServicesList.Viber);
        }

        public void AddToWaitingListEmail()
        {
            Waiting_list.Add(ServicesList.Email);
        }

        public void AddToWaitingListSMS()
        {
            Waiting_list.Add(ServicesList.SMS);
        }

        private bool isAwaitingEmail()
        {
            if (Waiting_list.Contains(ServicesList.Email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isAwaitingSMS()
        {
            if (Waiting_list.Contains(ServicesList.SMS))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isAwaitingTelegram()
        {
            if (Waiting_list.Contains(ServicesList.Telegram))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isAwaitingWhatsApp()
        {
            if (Waiting_list.Contains(ServicesList.WhatsApp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isAwaitingViber()
        {
            if (Waiting_list.Contains(ServicesList.Viber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public enum ServicesList
        {
            Email,
            Telegram,
            SMS,
            Viber,
            WhatsApp,

        }

        private void PicSMS_Click(object sender, EventArgs e)
        {

        }

        private void SMSText_Click(object sender, EventArgs e)
        {

        }

        private void PicViber_Click(object sender, EventArgs e)
        {

        }

        private void ViberText_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_Click(object sender, EventArgs e)
        {

        }

        private void PicWhatsApp_Click(object sender, EventArgs e)
        {

        }

        private void WhatsAppText_Click(object sender, EventArgs e)
        {

        }

        private void PicTelegram_Click(object sender, EventArgs e)
        {

        }

        private void TelegramText_Click(object sender, EventArgs e)
        {

        }

        private void SNSStatusControl_Load(object sender, EventArgs e)
        {

        }

        public void SetSNSProgress(int percents)
        {
            pb.Value = percents;
            txtpb.Text = percents.ToString();
        }

        
        private void ButtonZ_Telegram_Click(object sender, EventArgs e)
        {
            if (Waiting_list.Contains(ServicesList.Telegram))
            {
                Waiting_list.Remove(ServicesList.Telegram);
            }
        }

        private void ButtonZ_WhatsApp_Click(object sender, EventArgs e)
        {
            if (Waiting_list.Contains(ServicesList.WhatsApp))
            {
                Waiting_list.Remove(ServicesList.WhatsApp);
            }
        }

        private void ButtonZ_Viber_Click(object sender, EventArgs e)
        {
            if (Waiting_list.Contains(ServicesList.Viber))
            {
                Waiting_list.Remove(ServicesList.Viber);
            }
        }

        private void ButtonZ_Email_Click(object sender, EventArgs e)
        {
            if (Waiting_list.Contains(ServicesList.Email))
            {
                Waiting_list.Remove(ServicesList.Email);
            }
        }

        private void ButtonZ_SMS_Click(object sender, EventArgs e)
        {
            if (Waiting_list.Contains(ServicesList.SMS))
            {
                Waiting_list.Remove(ServicesList.SMS);
            }
        }

        private void BwTelegramSend_DoWork(object sender, DoWorkEventArgs e)
        {
            percs = 0;
            //===================
            // Go code:

            //==================
            percs = 15;
        }

        private void BwWhatsAppSend_DoWork(object sender, DoWorkEventArgs e)
        {
            percs = 16;
            //===================
            // Go code:

            //==================
            percs = 40;
        }

        private void BwViberSend_DoWork(object sender, DoWorkEventArgs e)
        {
            percs = 41;
            //===================
            // Go code:

            //==================
            percs = 65;
        }

        private void BwSMSSend_DoWork(object sender, DoWorkEventArgs e)
        {
            percs = 66;
            //===================
            // Go code:

            //==================
            percs = 85;
        }

        private void BwEmailSend_DoWork(object sender, DoWorkEventArgs e)
        {
            percs = 86;
            //===================
            // Go code:

            //==================
            percs = 100;
        }

        private void TProgressBar_Tick(object sender, EventArgs e)
        {
            lst_percents = percs;
        }

        void StandByMode()
        {

        }
    }
}
