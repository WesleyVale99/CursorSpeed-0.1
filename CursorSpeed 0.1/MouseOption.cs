using CursorSpeed_0._1.SPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorSpeed_0._1
{
    public class MouseOption
    {
        public static int[] mouseParams = new int[3];
        [DllImport("user32.dll")]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        [DllImport("kernel32.dll")]
        public static extern int GetLastError();


        public static int GetMouseSpeed()
        {
            IntPtr ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo((int)EnumParameters.SPI_GETMOUSESPEED, 0, ptr, 0);
            int intSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            return intSpeed;
        }
        public static int GetAcelerationKeyBoard()
        {
            IntPtr ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo((int)EnumParameters.SPI_GETKEYBOARDSPEED, 0, ptr, 0);
            int intSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            return intSpeed;
        }
        public static int GetPoimprovepointer()
        {
            SystemParametersInfo((int)EnumParameters.SPI_GETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            if (mouseParams[2] > 0)
            {
                return mouseParams[2];
            }
            return 0;
        }
        public static bool GetPointerAcelerarion()
        {
            SystemParametersInfo((int)EnumParameters.SPI_GETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            if (mouseParams[0] > 0 || mouseParams[1] > 0 || (mouseParams[0] > 0 && mouseParams[1] > 0))
            {
                return true;
            }
            return false;
        }
        public static int GetDelayKeyBoard()
        {
            IntPtr ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo((int)EnumParameters.SPI_GETKEYBOARDDELAY, 0, ptr, 0);
            int intSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            return intSpeed;
        }

        public static void SetMouseSpeed(int intSpeed)
        {
            IntPtr ptr = new IntPtr(intSpeed);

            SystemParametersInfo((int)EnumParameters.SPI_SETMOUSESPEED, 0, ptr, 0);
        }
        public static int SetPoimprovepointer(int value)
        {
            mouseParams[0] = 0;
            mouseParams[1] = 0;
            mouseParams[2] = value;
            int vay = SystemParametersInfo((int)EnumParameters.SPI_SETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 1);
            MessageBox.Show(vay.ToString());
            return vay;
        }
        public static void SetPointerAcelerarion(int x, int y)
        {
            mouseParams[0] = x;
            mouseParams[1] = y;
            mouseParams[2] = 0;
            SystemParametersInfo((int)EnumParameters.SPI_SETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 1);
        }
        public static void SetAcelerationKeyBoard(int count, int count1)
        {
            IntPtr ptr = new IntPtr(count);
            IntPtr ptr1 = new IntPtr(count1);

            SystemParametersInfo((int)EnumParameters.SPI_SETKEYBOARDSPEED, 0, ptr, 1);
            SystemParametersInfo((int)EnumParameters.SPI_SETKEYBOARDDELAY, 0, ptr1, 1);
        }
    }
}
