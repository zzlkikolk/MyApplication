using Microsoft.VisualBasic;
using System;
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

namespace WpfApp2 {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        protected override  void OnActivated(EventArgs e) {
            string str;
            //System.Windows.MessageBox.Show("叫爹", "警告");
             str = Interaction.InputBox("叫爹", "警告", "请输入爹", 400, 300);
            if("爹".Equals(str)){
                System.Windows.MessageBox.Show("儿子乖", "！！！");
                this.Close();
            }

        }
    }
}
