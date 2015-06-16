#define TEST_MODE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thrift;
using Thrift.Transport;
using Thrift.Protocol;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using Controller;
using Thrift.GameCall;
namespace Controller
{
    
    static class Program
    {
    //    [DllImport("MapServer.dll", EntryPoint = "GGGGGG", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    //    public static extern Int32 StartCheck(string uid);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public static TTransport transport = null;
        public static TProtocol protocol = null;
        public static GameFuncCall.Client client = null;

        public static ConfigData config = new ConfigData();//配置数据
        public static GlobeData gdata = new GlobeData();//全局数据
        public static RuntimeData rdata = new RuntimeData();//运行期数据,记忆数据
        public static Control UI = null;//界面
        public static HashSet<char> NumberChar = new HashSet<char>();
        public static FileStream selflock = null;
        [STAThread]
        static void Main()
        {
         //   LockMySelf();
            string strUID = null;
            string strPID = null;
            //获取启动参数
            String[] args = System.Environment.GetCommandLineArgs();
            string StartParam = null;
            int n = args.Length;
            //MessageBox.Show(commandLineString);
            if (n > 1)
            {
                StartParam = args[1];
       //         MessageBox.Show(StartParam);
                string[] param=StartParam.Split('*');

                strUID = param[0];
                strPID = param[1];
                MessageBox.Show(strUID+"---"+strPID);
        //        return;
            }
            //else
            //    MessageBox.Show("Test");
            //return;

            //初始化全局数据
            InitGlobalData();

            //获取启动字符串

            //启动
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if TEST_MODE//测试模式
            //
            strUID="GGGG";
            //strPWD="";
             //连接客户端
            ConnectToWorker(strPID);
            //连接验证服务器
      //      StartCheck(strUID);
            Application.Run(new Test());
#else
            UI = new Control();
            if (null == strUID)//获取验证账号
            {
                Login login = new Login();
                // 登陆界面
                DialogResult ret = login.ShowDialog();
                if (ret == DialogResult.Cancel)
                    return;
            //    strUID = login.strUID;
            //    strPWD = login.strPWD;
            }
            else
                UI.AutoStart = true;

            //连接客户端
            ConnectToWorker(strPID);

            //连接验证服务器
            StartCheck(strUID);

            //创建UI
            Application.Run(UI);
#endif
        }
        static void LockMySelf()
        {
            selflock = new FileStream("Controller.exe", FileMode.Open, FileAccess.Read, FileShare.None, 8);
            MessageBox.Show("Lock Success!");
        }
        static int ConnectToWorker(string strConnectKey)
        {
            string strKey ="GGGG";
           // Program.transport = new TPipe(@".", strKey);
            Program.transport = new TSocket("192.168.137.197",9992);
            Program.protocol = new TBinaryProtocol(Program.transport);
            Program.client = new GameFuncCall.Client(Program.protocol);
            Program.transport.Open();
            return 0;
        }
        static bool InitGlobalData()
        {
            NumberChar.Add('0');
            NumberChar.Add('1');
            NumberChar.Add('2');
            NumberChar.Add('3');
            NumberChar.Add('4');
            NumberChar.Add('5');
            NumberChar.Add('6');
            NumberChar.Add('7');
            NumberChar.Add('8');
            NumberChar.Add('9');

            //初始化脚本
            //gdata.AllScript.Add("辅助模式",);
            //gdata.AllScript.Add("辅助模式",);

            return true;
        }
    }
}
