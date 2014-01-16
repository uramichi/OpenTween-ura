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

        private bool CommandEval(string command){
            return true;
        }

        private void CommandComplete()
        {
        }

        private void CommandWindows_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Modifiers){
                case Keys.Control:
                    switch(e.KeyCode){
                        case Keys.C:
                            this.Close();
                            return;
                        case Keys.J:
                        case Keys.M:
                            CommandEval(textBox1.Text);
                            return;
                        case Keys.U:
                            textBox1.Text = "";
                            return;
                        case Keys.I:
                            CommandComplete();
                            return;
                    }
                    return;
            }
        }
    }
}
