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

namespace ExpertiseWPFApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GRNTI _GRNTI;
        Experts _Experts;
        ProjectCard _ProjectCard;
        Projects _Projects;
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public MainWindow()
        {
            InitializeComponent();
            client.GetListGRNTICompleted += Client_GetListGRNTICompleted;
            client.GethelloCompleted += Client_GethelloCompleted;
            client.GetListAuthorsCompleted += Client_GetListAuthorsCompleted;
            client.GetListFOSCompleted += Client_GetListFOSCompleted;

            client.testCompleted += Client_testCompleted;
            //client.testAsync();

            client.test2Completed += Client_test2Completed;
            //client.test2Async();
        }

        private void Client_GetListFOSCompleted(object sender, ServiceReference1.GetListFOSCompletedEventArgs e)
        {
            if (e.Error == null)
            {

                _ProjectCard.comboBox1.ItemsSource = e.Result.ToList();
            }
            else
                MessageBox.Show(e.Error.Message);
        }

        private void Client_GetListAuthorsCompleted(object sender, ServiceReference1.GetListAuthorsCompletedEventArgs e)
        {
            if (e.Error == null)
            {

                _ProjectCard.comboBox.ItemsSource = e.Result.ToList();
            }
            else
                MessageBox.Show(e.Error.Message);
        }

        private void Client_test2Completed(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                
                    MessageBox.Show("gfh");
                

            }


            else
                MessageBox.Show(e.Error.Message);
        }

        private void Client_testCompleted(object sender, ServiceReference1.testCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                for(int i = 0; i < e.Result.ToList().Count; i++)
                {
                    MessageBox.Show(e.Result[i].name_fos);
                }
                
            }


            else
                MessageBox.Show(e.Error.Message);
        }

        private void Client_GethelloCompleted(object sender, ServiceReference1.GethelloCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                
                MessageBox.Show(e.Result);
            }


            else
                MessageBox.Show(e.Error.Message);
        }

        private void Client_GetListGRNTICompleted(object sender, ServiceReference1.GetListGRNTICompletedEventArgs e)
        {
            if (e.Error == null)
            {
                _ProjectCard.comboBox2.ItemsSource = e.Result.ToList();
            }


            else
                MessageBox.Show(e.Error.Message);
        }

        private void bt_update_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
            //client.GethelloAsync();
            //client.GetListGRNTIAsync();
            _GRNTI = new GRNTI();
            _GRNTI.Owner = this;
            _GRNTI.ShowDialog();
        }
        //ГРНТИ
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            _GRNTI = new GRNTI();
            _GRNTI.Owner = this;
            _GRNTI.ShowDialog();
            
        }
        //Эксперты
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            _Experts = new Experts();
            _Experts.Owner = this;
            _Experts.ShowDialog();
        }
        //новый проект
        private void button_Click(object sender, RoutedEventArgs e)
        {
            _ProjectCard = new ProjectCard();
            _ProjectCard.Owner = this;
            client.GetListAuthorsAsync();
            client.GetListFOSAsync();
            client.GetListGRNTIAsync();
            _ProjectCard.ShowDialog();
        }
        //проект
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
                _Projects = new Projects();
            _Projects.Owner = this;
            _Projects.ShowDialog();
        }
    }
}
