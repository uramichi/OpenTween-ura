using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenTween.kt7kry
{
    public partial class CommandWindow : Form
    {
        private TweenMain target;
        public CommandWindow(TweenMain tweenObj)
        {
            InitializeComponent();
            target = tweenObj;
            textBox1.Focus();
        }
    }
}
