﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LearnCode_Test.Example.ExtensionMethod;
namespace LearnCode_Test
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //扩展方法
            string str = "谢佳伟";
            str.WriteSelf(5);

            str = "5";
            int a = str.toInt32();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate = new MyDelegate();
            myDelegate.excuteDelegate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lambda mLambda = new Lambda();
            mLambda.LambdaTest();
        }
    }
}
