using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace UwpApp
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        ///===========================================================================================
        /// <summary>デバッグテキスト表示ボタンクリック</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///===========================================================================================
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("デバッグテキストの表示");                                 // 出力コンソールにテキストを表示させる。
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var test = new testView();
            Mdi.Show(test);
        }
    }
}
