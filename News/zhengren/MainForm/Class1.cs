/// <summary>
/// NativeWIN32 ��ժҪ˵����
/// </summary>
using System.Runtime.InteropServices;
using System;
namespace MainForm
{
    public class NativeWIN32
    {
        public NativeWIN32()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr parent /*HWND*/,
         IntPtr next /*HWND*/,
         IntPtr sClassName,
         string sWindowTitle);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void SetForegroundWindow(int hwnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(int hWnd, nCmdShow nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int CreateMutex(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("HK_KeyBoardCtr.dll", CharSet = CharSet.Auto)]
        private static extern void hideHotKey();

        [DllImport("HK_KeyBoardCtr.dll", CharSet = CharSet.Auto)]
        private static extern void showHotKey();

        public static bool hideSysKey(bool bHide)
        {
            try
            {
                if (bHide)
                {
                    hideHotKey();
                }
                else
                {
                    showHotKey();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //SendMessage(Handle2, WM_GETTEXT, 1024, Integer(@Buf));

        /// <summary>
        /// �Ҵ���
        /// </summary>
        /// <param name="windowTittle">���ڱ���</param>
        /// <returns>�������ʾ�ҵ���,����Ϊ�ٱ�ʾδ�ҵ�</returns>
        public static bool FindThisWindow(string windowTittle)
        {
            IntPtr hParent = IntPtr.Zero;
            IntPtr hNext = IntPtr.Zero;
            hNext = NativeWIN32.FindWindowEx(hParent, hNext, IntPtr.Zero, windowTittle);
            if (hNext.ToInt32() > 0)
            {
                NativeWIN32.SetForegroundWindow(hNext.ToInt32());
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isExists(string strMutex)
        {

            bool createdNew;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, strMutex, out createdNew);
            return !createdNew; //createNewΪ��,���ʾmutex�����ɹ�,û�г�ͻ,��������Ϊ������û������
        }

        public static bool CloseTheWindows(string strWindowName)
        {
            try
            {
                IntPtr hParent = IntPtr.Zero;
                IntPtr hNext = IntPtr.Zero;
                hNext = NativeWIN32.FindWindowEx(hParent, hNext, IntPtr.Zero, strWindowName);
                if (hNext.ToInt32() > 0)
                {
                    //�رմ���
                    NativeWIN32.SendMessage(hNext, 16, 0, 0);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public enum nCmdShow : uint
        {
            SW_FORCEMINIMIZE = 0x0,
            SW_HIDE = 0x1,
            SW_MAXIMIZE = 0x2,
            SW_MINIMIZE = 0x3,
            SW_RESTORE = 0x4,
            SW_SHOW = 0x5,
            SW_SHOWDEFAULT = 0x6,
            SW_SHOWMAXIMIZED = 0x7,
            SW_SHOWMINIMIZED = 0x8,
            SW_SHOWMINNOACTIVE = 0x9,
            SW_SHOWNA = 0xA,
            SW_SHOWNOACTIVATE = 0xB,
            SW_SHOWNORMAL = 0xC,
            WM_CLOSE = 0x10,
            //    WM_GETTEXT=0x11,
        }
    }
}

