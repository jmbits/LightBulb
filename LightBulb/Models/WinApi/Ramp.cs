﻿using System.Runtime.InteropServices;

namespace LightBulb.Models.WinApi
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ramp
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public ushort[] Red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public ushort[] Green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public ushort[] Blue;

        public void Init()
        {
            Red = new ushort[256];
            Green = new ushort[256];
            Blue = new ushort[256];
        }
    }
}