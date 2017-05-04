﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    public static class SettingsLibrary
    {
        static double _trayOrigin2CenterX;
        static double _trayOrigin2CenterY;
        static double _trayCenter2CenterRow;
        static double _trayCenter2CenterCol;

        static double _trayHeight;
        static int _trayLength;
        static int _trayWidth;
        static int _trayStack;

        static string _invPathString;

        //encapsulated stubs begin here
        public static double TrayOrigin2CenterX { get { return _trayOrigin2CenterX; } set { _trayOrigin2CenterX = value; } }
        public static double TrayOrigin2CenterY { get { return _trayOrigin2CenterY; } set { _trayOrigin2CenterY = value; } }
        public static double TrayCenter2CenterRow { get { return _trayCenter2CenterRow; } set { _trayCenter2CenterRow = value; } }
        public static double TrayCenter2CenterCol { get { return _trayCenter2CenterCol; } set { _trayCenter2CenterCol = value; } }

        public static double TrayHeight { get { return _trayHeight; } set { _trayHeight = value; } }
        public static int TrayLength { get { return _trayLength; }  set { _trayLength = value; } }
        public static int TrayWidth { get { return _trayWidth; } set { _trayWidth = value; } }
        public static int TrayStack { get { return _trayStack; } set { _trayStack = value; } }
        
        public static string InvPathString { get { return _invPathString; } set { _invPathString = value; } }
        
    }
}
