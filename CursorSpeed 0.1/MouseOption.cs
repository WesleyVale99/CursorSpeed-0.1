using CursorSpeed_0._1.SPI;
using System;
using System.Runtime.InteropServices;

namespace CursorSpeed_0._1
{
    public class MouseOption
    {
        private static uint FKEYSize = sizeof(uint) * 6;
        public static FILTERKEY StartupFilterKeys;
        public static int[] mouseParams = new int[3];

        [DllImport("user32.dll")]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", SetLastError = false)]
        private static extern bool SystemParametersInfo(uint action, uint param, ref FILTERKEY vparam, uint init);

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
            return vay;
        }
        public static void SetPointerAcelerarion(int x, int y)
        {
            mouseParams[0] = x;
            mouseParams[1] = y;
            mouseParams[2] = 0;
            SystemParametersInfo((int)EnumParameters.SPI_SETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 1);
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct FILTERKEY
        {
            public uint cbSize;
            public uint dwFlags;
            public uint iWaitMSec;
            public uint iDelayMSec;
            public uint iRepeatMSec;
            public uint iBounceMSec;
        }
        public static bool SetAcelerationKeyBoard(uint Delay, uint Repeat, uint Flags, uint Wait)
        {
            StartupFilterKeys.cbSize = FKEYSize;
            StartupFilterKeys.iWaitMSec = Wait;
            StartupFilterKeys.iDelayMSec = Delay;
            StartupFilterKeys.iRepeatMSec = Repeat;
            StartupFilterKeys.dwFlags = Flags;
           

            return SystemParametersInfo((int)EnumParameters.SPI_SETFILTERKEYS, FKEYSize, ref StartupFilterKeys, 0);
        }
    }
}
