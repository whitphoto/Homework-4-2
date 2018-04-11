/********************************************************
*														*
*		Nathan Whitchurch								*
*		CIS 223 COMPUTER PROJECTS & APPLICATIONS    	*
*		Dr Whittle										*
*		Homework 4-2 Page Navigation					*
*														*
********************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework_4_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    class sport
        {
        int caloriesBurned;
        string name;
            public void ChangeName(string nameIn)
                {
                    //input scope set in XAML
                    name = nameIn;
                }
            public void ChangeCal(int calIn)
                {
                    //input scope set in XAML
                    caloriesBurned = calIn;
                    
                }

               public string GetName() { return name; }
               public int GetCal() { return caloriesBurned; }

    }

    
    public sealed partial class MainPage : Page
    {
        sport UserSport; 
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void InstClassButton_Click(object sender, RoutedEventArgs e)
        {
            UserSport = new sport();
        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            UserSport.ChangeName(NameTextBox.Text);
        }

        private void CalButton_Click(object sender, RoutedEventArgs e)
        {
            UserSport.ChangeCal(Convert.ToInt32(CalTextBox.Text));
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            UserInfo.Text = "Name: " + UserSport.GetName() + ".  \nCalories Burned: " + UserSport.GetCal() + "." ;

        }
    }
}
