﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursorSpeed_0._1
{
    public class MouseOption
    {
        [DllImport("user32.dll")]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        [DllImport("kernel32.dll")]
        public static extern int GetLastError();

        public const int SPI_GETMOUSESPEED = 112;
        public const int SPI_SETMOUSESPEED = 113;
        public const int SPI_SETMOUSE = 4;

        public static int GetMouseSpeed()
        {
            int intSpeed = 0;
            IntPtr ptr;
            ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, ptr, 0);
            intSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            return intSpeed;
        }

        public static void SetMouseSpeed(int intSpeed)
        {
            IntPtr ptr = new IntPtr(intSpeed);

            SystemParametersInfo(SPI_SETMOUSESPEED, 0, ptr, 0);
        }
        public static void SetAcelerationMouse()
        {
            IntPtr ptr = new IntPtr(0x8000);

            SystemParametersInfo(SPI_SETMOUSE, 0, ptr, 0);
        }
    }
}
