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

namespace ScrollViewerLayout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string content = @"一度赚钱赚得不好意思的中国银行业，“躺着赚钱”的好日子已经到头了。

在刚刚披露的上市银行2014年报中，除平安银行和浦发银行外，其余8家上市银行净利润增速均低于10%，其中中信银行仅为3.87%。

包括工行在内的多家国有大行和股份制银行今年净利增速相较去年腰斩。中资银行的净利增速基本进入个位数时代。

 

是什么让银行业快车减速？除了去年不良贷款增加之下，各家银行加大拨备吞噬净利润外，利率市场化的推进、金融脱媒的加速，

以及互联网金融来势汹汹都令银行面临挑战。这些因素的叠加正在令银行告别躺着赚钱的好日子，低速增长成为银行的“新常态”。

 

事实上，除了资产质量的考验外，从更长时间的维度看，中国银行业所面临的政策环境的变化已经在过去几年不断令高歌猛进的银行业净利润慢慢减缓，

以“宇宙行”工行为例，2010年、2011年净利润仍维持28 .4%、25.6%的净利润增速，

但2012年开始大幅放缓至14.5%，2013年年报仍勉强维持在两位数，2014年进一步跌至5.1%。

 

 

那么银行该如何实现“互联网+”呢？在笔者看来，过去的两年时间里，

P2P、余额宝等新生产品尽管让互联网金融看起来格外热闹，

但对银行而言，互联网金融更大的意义并非在渠道的重新构建，

而在于价值链重构，“互联网+”或许将带领银行重新发现价值。

 

除了表面热闹的互联网渠道的应用外，对于银行而言，更为重要的是通过互联网激活大数据，重新构建银行的价值链。

 

首先，其基础应该在于，其底层的生态搭建，体现在支付清算体系、征信体系等的基础技术的改造上。

 

其次，在此过程中，银行可以实现再度的价值发现，如通过虚拟账户、远程账户的变革，

将零售业务往移动端迁移，开发长尾用户；并将利润从此前的规模导向转为资金的流转速度上，

同时利用大数据及供应链才能真正打开银行小微信用蓝海。

 

从上周工行发布的一系列互联网金融产品主要围绕支付、社交以及移动端的零售可以看出类似的思路。　";



        private void ShowArticle()

        {

            //获取私信信息



            StringBuilder strMessage = new StringBuilder();



            strMessage.Append("标题" + "失速的银行该如何实现“互联网+”？" + "\r\n");

            strMessage.Append("来源：" + "南方都市报" + "\r\n");

            strMessage.Append("发送时间：" + "2015-04-02 06:31:32" + "\r\n");

            strMessage.Append("发送内容：" + content + "\r\n\n");

            txtShowArticle.Text = strMessage.ToString();

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)

        {

            ShowArticle();

        }
    }
}
