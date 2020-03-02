﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlNetCore
{
    public class MyButton : Button
    {
        public static readonly DependencyProperty DependencyPropertyTriggerProperty = DependencyProperty.Register(
  "DependencyPropertyTrigger", typeof(string), typeof(MyButton), new PropertyMetadata(""));

        static MyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyButton), new FrameworkPropertyMetadata(typeof(MyButton)));
        }

        public string DependencyPropertyTrigger
        {
            get 
            {
                return (string)this.GetValue(DependencyPropertyTriggerProperty);
            }
            set 
            {
                this.SetValue(DependencyPropertyTriggerProperty, value);
                if (value == "messagebox")
                    // Hopefully show Visual Studio design-time UI
                    MessageBox.Show(value, "DependencyPropertyTrigger");
            }
        }
    }
}