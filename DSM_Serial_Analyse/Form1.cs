using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTD2XX_NET;


namespace DSM_Serial_Analyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxValues = new TextBox[] { tbxVal1, tbxVal2, tbxVal3, tbxVal4, tbxVal5, tbxVal6 };
            tbxChannel = new TextBox[] { tbxCH0, tbxCH1, tbxCH2, tbxCH3, tbxCH4, tbxCH5 };
            barValues = new ProgressBar[] {progressBar1,progressBar2,progressBar3,progressBar4,progressBar5,progressBar6};
            tbxPercents = new TextBox[] {tbxPercent1,tbxPercent2,tbxPercent3,tbxPercent4,tbxPercent5,tbxPercent6};
        }
        FTDI myFtdiDevice = new FTDI();
        private TextBox[] tbxValues;
        private TextBox[] tbxChannel;
        private TextBox[] tbxPercents;
        private ProgressBar[] barValues;
        protected UInt32 dwListDescFlags;
        FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList;

        private bool ListUnopenDevices()
        {
            UInt32 numDevs = 0;
            // Determine the number of FTDI devices connected to the machine
            FTDI.FT_STATUS ftStatus = myFtdiDevice.GetNumberOfDevices(ref numDevs);
            int i;
            int iCurrentIndex;

            iCurrentIndex = cmbDevList.SelectedIndex;
            cmbDevList.Items.Clear();

            // Allocate storage for device info list
            ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[numDevs];

            // Populate our device list
            ftStatus = myFtdiDevice.GetDeviceList(ftdiDeviceList);

            if (ftStatus == FTDI.FT_STATUS.FT_OK)
            {
                for (i = 0; i < numDevs; i++)
                {
                    if (radDescription.Checked)
                        cmbDevList.Items.Add(ftdiDeviceList[i].Description.ToString());
                    else if (radSerial.Checked)
                        cmbDevList.Items.Add(ftdiDeviceList[i].SerialNumber.ToString());
                    else if(radNumber.Checked)
                        cmbDevList.Items.Add(i);
                    else if(radID.Checked)
                        cmbDevList.Items.Add(ftdiDeviceList[i].ID.ToString());
                }
            }
            else
            {
					MessageBox.Show("Error list devices" + Convert.ToString(ftStatus), "Error");
					return false;
            }
            cmbDevList.SelectedIndex = iCurrentIndex;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListUnopenDevices();
            cmbBaud.SelectedIndex = 12;
        }

        private void radx_CheckedChanged(object sender, EventArgs e)
        {
            if (ListUnopenDevices() == false)
            {
                MessageBox.Show("Error Listing Devices");
            }

        }

        private void cmbDevList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnOpen.Enabled = true;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            FTDI.FT_STATUS ftStatus = myFtdiDevice.OpenBySerialNumber(ftdiDeviceList[cmbDevList.SelectedIndex].SerialNumber);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show("Error open devices" + Convert.ToString(ftStatus), "Error");
                return;
            }
            // Set up device data parameters
            // Set Baud rate
            uint rate = uint.Parse(cmbBaud.SelectedItem.ToString());
            ftStatus = myFtdiDevice.SetBaudRate(rate);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show("Error Set Baud Rate" + Convert.ToString(ftStatus), "Error");
                myFtdiDevice.Close();
                return;
            }
            // Set data characteristics - Data bits, Stop bits, Parity
            ftStatus = myFtdiDevice.SetDataCharacteristics(FTDI.FT_DATA_BITS.FT_BITS_8, FTDI.FT_STOP_BITS.FT_STOP_BITS_1, FTDI.FT_PARITY.FT_PARITY_NONE);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show("Error Set Data Characteristics" + Convert.ToString(ftStatus), "Error");
                myFtdiDevice.Close();
                return;
            }
            // Set flow control - set RTS/CTS flow control
            ftStatus = myFtdiDevice.SetFlowControl(FTDI.FT_FLOW_CONTROL.FT_FLOW_NONE,0, 0);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show("Error Set Flow Control" + Convert.ToString(ftStatus), "Error");
                myFtdiDevice.Close();
                return;
            }
            // Set read timeout to 100 milliseconds, write timeout to 1 second
            ftStatus = myFtdiDevice.SetTimeouts(100, 1000);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show("Error Set Timeouts" + Convert.ToString(ftStatus), "Error");
                myFtdiDevice.Close();
                return;
            }
            btnClose.Enabled = true;
            BtnOpen.Enabled = false;
            timer1.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            myFtdiDevice.Close();
            BtnOpen.Enabled = true;
            btnClose.Enabled = false;
            for (int n = 0; n < 6; n++)
            {
                tbxValues[n].Text = "";
                barValues[n].Value = 0;
                tbxChannel[n].Text = "";
                tbxMode.Text = "";
            }

        }

        private void AnalysData(byte[] buffer)
        {
            byte Mode = buffer[0];
            tbxMode.Text = Mode.ToString("X2");
            if (((Mode >> 3) & 0x3) == 2)
                tbxMode2.Text = "DSM2";
            if (((Mode >> 3) & 0x3) == 3)
                tbxMode2.Text = "DSMX";
            if (((Mode >> 3) & 0x3) == 0)
                tbxMode2.Text = "france";
            if (((Mode >> 3) & 0x3) == 0)
                tbxMode2.Text = "Err";
            
            if ((Mode & 0x80) == 0x80)
                lblBind.Visible  = true;
            else
                lblBind.Visible = false;

            if ((Mode & 0x20) == 0x20)
                LblRange.Visible = true;
            else
                LblRange.Visible = false;


            for (int n = 0; n < 6; n ++)
            {
                byte byte0 = buffer[n*2 + 2];
                byte byte1 = buffer[n*2 + 3];
                int val = byte0 & 0x3;
                int chan = byte0 >> 2;
                val *= 256;
                val += byte1;
                tbxValues[n].Text = val.ToString();
                barValues[n].Value = val;
                tbxPercents[n].Text = ((val-512L)*125/(512L)).ToString() ;
                tbxChannel[n].Text = chan.ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myFtdiDevice.IsOpen)
            {
                UInt32 n=0;
                FTDI.FT_STATUS ftStatus = myFtdiDevice.GetRxBytesAvailable(ref n);
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                {
                    MessageBox.Show("Error reading bytes avaliabel" + Convert.ToString(ftStatus), "Error");
                    timer1.Enabled = false;
                    myFtdiDevice.Close();
                    BtnOpen.Enabled = true;
                    btnClose.Enabled = false;
                    return;
                }
                if (n > (4*14))
                {
                    ftStatus = myFtdiDevice.Purge(FTDI.FT_PURGE.FT_PURGE_RX);
                    if (ftStatus != FTDI.FT_STATUS.FT_OK)
                    {
                        MessageBox.Show("Error Purging in Buffer" + Convert.ToString(ftStatus), "Error");
                        timer1.Enabled = false;
                        myFtdiDevice.Close();
                        BtnOpen.Enabled = true;
                        btnClose.Enabled = false;
                        return;
                    }
                }
                else if (n>0 && (n % 14) == 0)
                {
                    byte[] buffer=new byte[n];
                    UInt32 read=0;
                    ftStatus = myFtdiDevice.Read(buffer, 14, ref read);
                    if (ftStatus != FTDI.FT_STATUS.FT_OK)
                    {
                        MessageBox.Show("Error reading data" + Convert.ToString(ftStatus), "Error");
                        timer1.Enabled = false;
                        myFtdiDevice.Close();
                        BtnOpen.Enabled = true;
                        btnClose.Enabled = false;
                        return;
                    }
                    if (read == 14)
                    {
                        AnalysData(buffer);
                    } //if (read == 14)
                }//else if (n == 14)
            }//is open
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myFtdiDevice.IsOpen)
            {
            timer1.Enabled = false;
            myFtdiDevice.Close();
            myFtdiDevice=null;
            BtnOpen.Enabled = true;
            btnClose.Enabled = false;
            }
        }//timer1_Tick


    }
}
