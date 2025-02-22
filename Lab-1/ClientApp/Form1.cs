﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ClassLibrary1;


namespace ClientApp
{
    public partial class Form1 : Form
    {

        ITranslator translator = null;

        public Form1()
        {
            InitializeComponent();
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan, false);
            translator = (ITranslator)Activator.GetObject(typeof(ITranslator), "tcp://localhost:5000/translator");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string translated = translator.Translate(textBox1.Text.ToString());
            textBox2.Text = translated;
        }
    }
}
