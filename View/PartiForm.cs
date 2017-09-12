﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Room8.View
{
    public partial class PartiForm : Form
    {
        public PartiForm()
        {
            InitializeComponent();
        }

		public Label PartiLabel
		{
			get { return _partiLabel; }
		}

		public Panel ScrollPanel
		{
			get { return _scrollPanel; }
		}

		public Button ConfermaButton
		{
			get { return _confermaButton; }
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}
    }
}
