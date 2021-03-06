﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace Fireasy.Windows.Forms
{
    internal class NativeMethods
    {
        [DllImport("user32", EntryPoint = "GetWindowDC")]
        internal static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        internal static extern bool MessageBeep(MessageBoxIcon mbi);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint SendMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint SetWindowText(IntPtr hWnd, string text);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder sb, int maxCount);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int ReleaseDC(IntPtr hWnd, IntPtr dc);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern int CombineRgn(IntPtr dest, IntPtr src1, IntPtr src2, int flags);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateBrushIndirect(ref LOGBRUSH brush);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateRectRgnIndirect(ref RECT rect);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DeleteDC(IntPtr hDC);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr DeleteObject(IntPtr hObject);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern bool FillRgn(IntPtr hDC, IntPtr hrgn, IntPtr hBrush);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetClipBox(IntPtr hDC, ref RECT rectBox);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern bool PatBlt(IntPtr hDC, int x, int y, int width, int height, uint flags);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern int SelectClipRgn(IntPtr hDC, IntPtr hRgn);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool AnimateWindow(IntPtr hWnd, uint dwTime, FlagsAnimateWindow dwFlags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool ClientToScreen(IntPtr hWnd, ref POINT pt);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DispatchMessage(ref MSG msg);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DragDetect(IntPtr hWnd, Point pt);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DrawFocusRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetFocus();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern ushort GetKeyState(int virtKey);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool GetMessage(ref MSG msg, int hWnd, uint wFilterMin, uint wFilterMax);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetParent(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetSysColorBrush(int index);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool HideCaret(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool InvalidateRect(IntPtr hWnd, ref RECT rect, bool erase);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr LoadCursor(IntPtr hInstance, uint cursor);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool PeekMessage(ref MSG msg, int hWnd, uint wFilterMin, uint wFilterMax, uint wFlag);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool PostMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool ReleaseCapture();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool ScreenToClient(IntPtr hWnd, ref POINT pt);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SetCursor(IntPtr hCursor);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SetFocus(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndAfter, int X, int Y, int Width, int Height, FlagsSetWindowPos flags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool redraw);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool ShowCaret(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int ShowWindow(IntPtr hWnd, short cmdShow);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool SystemParametersInfo(SystemParametersInfoActions uAction, uint uParam, ref uint lpvParam, uint fuWinIni);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool TrackMouseEvent(ref TRACKMOUSEEVENTS tme);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool TranslateMessage(ref MSG msg);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pprSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool WaitMessage();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr WindowFromPoint(POINT point);
        [DllImport("user32.dll")]
        internal static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32.dll")]
        internal static extern IntPtr GetActiveWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern void GetCursorPos(ref POINT point);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "0")]
        internal static extern IntPtr WindowFromPoint(Point point);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal extern static IntPtr FindWindow(string className, string caption);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal extern static IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string caption);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc callback, IntPtr param);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal extern static IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetClassName(IntPtr hWnd, StringBuilder className, int maxCount);

        internal delegate bool EnumChildProc(IntPtr hWnd, IntPtr param);

        internal static int HIWORD(int n)
        {
            return (short)((n >> 16) & 0xffff);
        }

        internal static int HIWORD(IntPtr n)
        {
            return HIWORD(unchecked((int)(long)n));
        }

        internal static IntPtr MakeWParam(int lowWord, int highWord)
        {
            int wparam = highWord << 16;
            wparam |= (lowWord & 0xffff);

            return new IntPtr(wparam);
        }

        internal static uint MakeLong(int low, int high)
        {
            return (uint)((high << 16) + low);
        }

        internal static int LOWORD(int n)
        {
            return (short)(n & 0xffff);
        }

        internal static int LOWORD(IntPtr n)
        {
            return LOWORD(unchecked((int)(long)n));
        }

        internal const int WM_ACTIVATE = 6;
        internal const int WM_ACTIVATEAPP = 0x1c;
        internal const int WM_AFXFIRST = 0x360;
        internal const int WM_AFXLAST = 0x37f;
        internal const int WM_APP = 0x8000;
        internal const int WM_ASKCBFORMATNAME = 780;
        internal const int WM_CANCELJOURNAL = 0x4b;
        internal const int WM_CANCELMODE = 0x1f;
        internal const int WM_CAPTURECHANGED = 0x215;
        internal const int WM_CHANGECBCHAIN = 0x30d;
        internal const int WM_CHAR = 0x102;
        internal const int WM_CHARTOITEM = 0x2f;
        internal const int WM_CHILDACTIVATE = 0x22;
        internal const int WM_CLEAR = 0x303;
        internal const int WM_CLOSE = 0x10;
        internal const int WM_COMMAND = 0x111;
        internal const int WM_COMMNOTIFY = 0x44;
        internal const int WM_COMPACTING = 0x41;
        internal const int WM_COMPAREITEM = 0x39;
        internal const int WM_CONTEXTMENU = 0x7b;
        internal const int WM_COPY = 0x301;
        internal const int WM_COPYDATA = 0x4a;
        internal const int WM_CREATE = 1;
        internal const int WM_CTLCOLORBTN = 0x135;
        internal const int WM_CTLCOLORDLG = 310;
        internal const int WM_CTLCOLOREDIT = 0x133;
        internal const int WM_CTLCOLORLISTBOX = 0x134;
        internal const int WM_CTLCOLORMSGBOX = 0x132;
        internal const int WM_CTLCOLORSCROLLBAR = 0x137;
        internal const int WM_CTLCOLORSTATIC = 0x138;
        internal const int WM_CUT = 0x300;
        internal const int WM_DEADCHAR = 0x103;
        internal const int WM_DELETEITEM = 0x2d;
        internal const int WM_DESTROY = 2;
        internal const int WM_DESTROYCLIPBOARD = 0x307;
        internal const int WM_DEVICECHANGE = 0x219;
        internal const int WM_DEVMODECHANGE = 0x1b;
        internal const int WM_DISPLAYCHANGE = 0x7e;
        internal const int WM_DRAWCLIPBOARD = 0x308;
        internal const int WM_DRAWITEM = 0x2b;
        internal const int WM_DROPFILES = 0x233;
        internal const int WM_ENABLE = 10;
        internal const int WM_ENDSESSION = 0x16;
        internal const int WM_ENTERIDLE = 0x121;
        internal const int WM_ENTERMENULOOP = 0x211;
        internal const int WM_ENTERSIZEMOVE = 0x231;
        internal const int WM_ERASEBKGND = 20;
        internal const int WM_EXITMENULOOP = 530;
        internal const int WM_EXITSIZEMOVE = 0x232;
        internal const int WM_FONTCHANGE = 0x1d;
        internal const int WM_GETDLGCODE = 0x87;
        internal const int WM_GETFONT = 0x31;
        internal const int WM_GETHOTKEY = 0x33;
        internal const int WM_GETICON = 0x7f;
        internal const int WM_GETMINMAXINFO = 0x24;
        internal const int WM_GETOBJECT = 0x3d;
        internal const int WM_GETTEXT = 13;
        internal const int WM_GETTEXTLENGTH = 14;
        internal const int WM_HANDHELDFIRST = 0x358;
        internal const int WM_HANDHELDLAST = 0x35f;
        internal const int WM_HELP = 0x53;
        internal const int WM_HOTKEY = 0x312;
        internal const int WM_HSCROLL = 0x114;
        internal const int WM_HSCROLLCLIPBOARD = 0x30e;
        internal const int WM_ICONERASEBKGND = 0x27;
        internal const int WM_IME_CHAR = 0x286;
        internal const int WM_IME_COMPOSITION = 0x10f;
        internal const int WM_IME_COMPOSITIONFULL = 0x284;
        internal const int WM_IME_CONTROL = 0x283;
        internal const int WM_IME_ENDCOMPOSITION = 270;
        internal const int WM_IME_KEYDOWN = 0x290;
        internal const int WM_IME_KEYLAST = 0x10f;
        internal const int WM_IME_KEYUP = 0x291;
        internal const int WM_IME_NOTIFY = 0x282;
        internal const int WM_IME_REQUEST = 0x288;
        internal const int WM_IME_SELECT = 0x285;
        internal const int WM_IME_SETCONTEXT = 0x281;
        internal const int WM_IME_STARTCOMPOSITION = 0x10d;
        internal const int WM_INITDIALOG = 0x110;
        internal const int WM_INITMENU = 0x116;
        internal const int WM_INITMENUPOPUP = 0x117;
        internal const int WM_INPUTLANGCHANGE = 0x51;
        internal const int WM_INPUTLANGCHANGEREQUEST = 80;
        internal const int WM_KEYDOWN = 0x100;
        internal const int WM_KEYLAST = 0x108;
        internal const int WM_KEYUP = 0x101;
        internal const int WM_KILLFOCUS = 8;
        internal const int WM_LBUTTONDBLCLK = 0x203;
        internal const int WM_LBUTTONDOWN = 0x201;
        internal const int WM_LBUTTONUP = 0x202;
        internal const int WM_MBUTTONDBLCLK = 0x209;
        internal const int WM_MBUTTONDOWN = 0x207;
        internal const int WM_MBUTTONUP = 520;
        internal const int WM_MDIACTIVATE = 0x222;
        internal const int WM_MDICASCADE = 0x227;
        internal const int WM_MDICREATE = 0x220;
        internal const int WM_MDIDESTROY = 0x221;
        internal const int WM_MDIGETACTIVE = 0x229;
        internal const int WM_MDIICONARRANGE = 0x228;
        internal const int WM_MDIMAXIMIZE = 0x225;
        internal const int WM_MDINEXT = 0x224;
        internal const int WM_MDIREFRESHMENU = 0x234;
        internal const int WM_MDIRESTORE = 0x223;
        internal const int WM_MDISETMENU = 560;
        internal const int WM_MDITILE = 550;
        internal const int WM_MEASUREITEM = 0x2c;
        internal const int WM_MENUCHAR = 0x120;
        internal const int WM_MENUCOMMAND = 0x126;
        internal const int WM_MENUDRAG = 0x123;
        internal const int WM_MENUGETOBJECT = 0x124;
        internal const int WM_MENURBUTTONUP = 290;
        internal const int WM_MENUSELECT = 0x11f;
        internal const int WM_MOUSEACTIVATE = 0x21;
        internal const int WM_MOUSEHOVER = 0x2a1;
        internal const int WM_MOUSELEAVE = 0x2a3;
        internal const int WM_MOUSEMOVE = 0x200;
        internal const int WM_MOUSEWHEEL = 0x20a;
        internal const int WM_MOVE = 3;
        internal const int WM_MOVING = 0x216;
        internal const int WM_NCACTIVATE = 0x86;
        internal const int WM_NCCALCSIZE = 0x83;
        internal const int WM_NCCREATE = 0x81;
        internal const int WM_NCDESTROY = 130;
        internal const int WM_NCHITTEST = 0x84;
        internal const int WM_NCLBUTTONDBLCLK = 0xa3;
        internal const int WM_NCLBUTTONDOWN = 0xa1;
        internal const int WM_NCLBUTTONUP = 0xa2;
        internal const int WM_NCMBUTTONDBLCLK = 0xa9;
        internal const int WM_NCMBUTTONDOWN = 0xa7;
        internal const int WM_NCMBUTTONUP = 0xa8;
        internal const int WM_NCMOUSEMOVE = 160;
        internal const int WM_NCPAINT = 0x85;
        internal const int WM_NCRBUTTONDBLCLK = 0xa6;
        internal const int WM_NCRBUTTONDOWN = 0xa4;
        internal const int WM_NCRBUTTONUP = 0xa5;
        internal const int WM_NEXTDLGCTL = 40;
        internal const int WM_NEXTMENU = 0x213;
        internal const int WM_NOTIFY = 0x4e;
        internal const int WM_NOTIFYFORMAT = 0x55;
        internal const int WM_NULL = 0;
        internal const int WM_PAINT = 15;
        internal const int WM_PAINTCLIPBOARD = 0x309;
        internal const int WM_PAINTICON = 0x26;
        internal const int WM_PALETTECHANGED = 0x311;
        internal const int WM_PALETTEISCHANGING = 0x310;
        internal const int WM_PARENTNOTIFY = 0x210;
        internal const int WM_PASTE = 770;
        internal const int WM_PENWINFIRST = 0x380;
        internal const int WM_PENWINLAST = 0x38f;
        internal const int WM_POWER = 0x48;
        internal const int WM_PRINT = 0x317;
        internal const int WM_PRINTCLIENT = 0x318;
        internal const int WM_QUERYDRAGICON = 0x37;
        internal const int WM_QUERYENDSESSION = 0x11;
        internal const int WM_QUERYNEWPALETTE = 0x30f;
        internal const int WM_QUERYOPEN = 0x13;
        internal const int WM_QUEUESYNC = 0x23;
        internal const int WM_QUIT = 0x12;
        internal const int WM_RBUTTONDBLCLK = 0x206;
        internal const int WM_RBUTTONDOWN = 0x204;
        internal const int WM_RBUTTONUP = 0x205;
        internal const int WM_RENDERALLFORMATS = 0x306;
        internal const int WM_RENDERFORMAT = 0x305;
        internal const int WM_SETCURSOR = 0x20;
        internal const int WM_SETFOCUS = 7;
        internal const int WM_SETFONT = 0x30;
        internal const int WM_SETHOTKEY = 50;
        internal const int WM_SETICON = 0x80;
        internal const int WM_SETREDRAW = 11;
        internal const int WM_SETTEXT = 12;
        internal const int WM_SETTINGCHANGE = 0x1a;
        internal const int WM_SHOWWINDOW = 0x18;
        internal const int WM_SIZE = 5;
        internal const int WM_SIZECLIPBOARD = 0x30b;
        internal const int WM_SIZING = 0x214;
        internal const int WM_SPOOLERSTATUS = 0x2a;
        internal const int WM_STYLECHANGED = 0x7d;
        internal const int WM_STYLECHANGING = 0x7c;
        internal const int WM_SYNCPAINT = 0x88;
        internal const int WM_SYSCHAR = 0x106;
        internal const int WM_SYSCOLORCHANGE = 0x15;
        internal const int WM_SYSCOMMAND = 0x112;
        internal const int WM_SYSDEADCHAR = 0x107;
        internal const int WM_SYSKEYDOWN = 260;
        internal const int WM_SYSKEYUP = 0x105;
        internal const int WM_TCARD = 0x52;
        internal const int WM_TIMECHANGE = 30;
        internal const int WM_TIMER = 0x113;
        internal const int WM_UNDO = 0x304;
        internal const int WM_UNINITMENUPOPUP = 0x125;
        internal const int WM_USER = 0x400;
        internal const int WM_USERCHANGED = 0x54;
        internal const int WM_VKEYTOITEM = 0x2e;
        internal const int WM_VSCROLL = 0x115;
        internal const int WM_VSCROLLCLIPBOARD = 0x30a;
        internal const int WM_WINDOWPOSCHANGED = 0x47;
        internal const int WM_WINDOWPOSCHANGING = 70;
        internal const int WM_WININICHANGE = 0x1a;
        internal const int WM_NC_HITTEST = 0x84;
        internal const int WM_NC_PAINT = 0x85;
        internal const int WS_EX_TRANSPARENT = 0x00000020;
        internal const int WS_EX_TOOLWINDOW = 0x00000080;
        internal const int WS_EX_LAYERED = 0x00080000;
        internal const int WS_EX_NOACTIVATE = 0x08000000;
        internal const int HTTRANSPARENT = -1;
        internal const int HTLEFT = 10;
        internal const int HTRIGHT = 11;
        internal const int HTTOP = 12;
        internal const int HTTOPLEFT = 13;
        internal const int HTTOPRIGHT = 14;
        internal const int HTBOTTOM = 15;
        internal const int HTBOTTOMLEFT = 16;
        internal const int HTBOTTOMRIGHT = 17;
        internal const int WM_REFLECT = WM_USER + 0x1C00;
        internal const int CBN_DROPDOWN = 7;

        internal const string CLS_BUTTON = "BUTTON";
        internal const string CLS_STATIC = "STATIC";

        internal const int SS_ICON = 3;

        internal const int GWL_STYLE = -16;
        internal const int GWL_ID = -12;

        //  Dialog Box Command IDs
        internal const int IDOK = 1;
        internal const int IDCANCEL = 2;
        internal const int IDABORT = 3;
        internal const int IDRETRY = 4;
        internal const int IDIGNORE = 5;
        internal const int IDYES = 6;
        internal const int IDNO = 7;
        internal const int IDCLOSE = 8;
        internal const int IDHELP = 9;
        internal const int IDTRYAGAIN = 10;
        internal const int IDCONTINUE = 11;

        // Button notification code
        internal const int BN_CLICKED = 0;

        [StructLayout(LayoutKind.Sequential)]
        internal struct MINMAXINFO
        {
            public Point reserved;
            public Size maxSize;
            public Point maxPosition;
            public Size minTrackSize;
            public Size maxTrackSize;
        }

        private static HandleRef HWND_TOPMOST = new HandleRef(null, new IntPtr(-1));

        [Flags]
        internal enum AnimationFlags : int
        {
            Roll = 0x0000,
            HorizontalPositive = 0x00001,
            HorizontalNegative = 0x00002,
            VerticalPositive = 0x00004,
            VerticalNegative = 0x00008,
            Center = 0x00010,
            Hide = 0x10000,
            Activate = 0x20000,
            Slide = 0x40000,
            Blend = 0x80000,
            Mask = 0xfffff,
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow(HandleRef windowHandle, int time, AnimationFlags flags);

        internal static void AnimateWindow(Control control, int time, AnimationFlags flags)
        {
            try
            {
                SecurityPermission sp = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
                sp.Demand();
                AnimateWindow(new HandleRef(control, control.Handle), time, flags);
            }
            catch (SecurityException) { }
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetWindowPos(HandleRef hWnd, HandleRef hWndInsertAfter, int x, int y, int cx, int cy, int flags);

        internal static void SetTopMost(Control control)
        {
            try
            {
                SecurityPermission sp = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
                sp.Demand();
                SetWindowPos(new HandleRef(control, control.Handle), HWND_TOPMOST, 0, 0, 0, 0, 0x13);
            }
            catch (SecurityException) { }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            public override string ToString()
            {
                return ("{left=" + this.left.ToString() + ", top=" + this.top.ToString() + ", right=" + this.right.ToString() + ", bottom=" + this.bottom.ToString() + "}");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct LOGBRUSH
        {
            public uint lbStyle;
            public uint lbColor;
            public uint lbHatch;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MSG
        {
            public IntPtr hwnd;
            public int message;
            public IntPtr wParam;
            public IntPtr lParam;
            public int time;
            public int pt_x;
            public int pt_y;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SIZE
        {
            public int cx;
            public int cy;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct TRACKMOUSEEVENTS
        {
            public const uint TME_HOVER = 1;
            public const uint TME_LEAVE = 2;
            public const uint TME_NONCLIENT = 0x10;
            public const uint TME_QUERY = 0x40000000;
            public const uint TME_CANCEL = 0x80000000;
            public const uint HOVER_DEFAULT = uint.MaxValue;
            private uint cbSize;
            private uint dwFlags;
            private IntPtr hWnd;
            private uint dwHoverTime;
            public TRACKMOUSEEVENTS(uint dwFlags, IntPtr hWnd, uint dwHoverTime)
            {
                this.cbSize = 0x10;
                this.dwFlags = dwFlags;
                this.hWnd = hWnd;
                this.dwHoverTime = dwHoverTime;
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public int fErase;
            public Rectangle rcPaint;
            public int fRestore;
            public int fIncUpdate;
            public int Reserved1;
            public int Reserved2;
            public int Reserved3;
            public int Reserved4;
            public int Reserved5;
            public int Reserved6;
            public int Reserved7;
            public int Reserved8;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }
        internal enum ShowWindowStyles : short
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        internal enum WindowStyles : uint
        {
            WS_OVERLAPPED = 0x00000000,
            WS_POPUP = 0x80000000,
            WS_CHILD = 0x40000000,
            WS_MINIMIZE = 0x20000000,
            WS_VISIBLE = 0x10000000,
            WS_DISABLED = 0x08000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_MAXIMIZE = 0x01000000,
            WS_CAPTION = 0x00C00000,
            WS_BORDER = 0x00800000,
            WS_DLGFRAME = 0x00400000,
            WS_VSCROLL = 0x00200000,
            WS_HSCROLL = 0x00100000,
            WS_SYSMENU = 0x00080000,
            WS_THICKFRAME = 0x00040000,
            WS_GROUP = 0x00020000,
            WS_TABSTOP = 0x00010000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_TILED = 0x00000000,
            WS_ICONIC = 0x20000000,
            WS_SIZEBOX = 0x00040000,
            WS_POPUPWINDOW = 0x80880000,
            WS_OVERLAPPEDWINDOW = 0x00CF0000,
            WS_TILEDWINDOW = 0x00CF0000,
            WS_CHILDWINDOW = 0x40000000
        }

        internal enum WindowExStyles
        {
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_ACCEPTFILES = 0x00000010,
            WS_EX_TRANSPARENT = 0x00000020,
            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_WINDOWEDGE = 0x00000100,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,
            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LTRREADING = 0x00000000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_RIGHTSCROLLBAR = 0x00000000,
            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,
            WS_EX_OVERLAPPEDWINDOW = 0x00000300,
            WS_EX_PALETTEWINDOW = 0x00000188,
            WS_EX_LAYERED = 0x00080000
        }

        internal enum Msgs
        {
            WM_NULL = 0x0000,
            WM_CREATE = 0x0001,
            WM_DESTROY = 0x0002,
            WM_MOVE = 0x0003,
            WM_SIZE = 0x0005,
            WM_ACTIVATE = 0x0006,
            WM_SETFOCUS = 0x0007,
            WM_KILLFOCUS = 0x0008,
            WM_ENABLE = 0x000A,
            WM_SETREDRAW = 0x000B,
            WM_SETTEXT = 0x000C,
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,
            WM_PAINT = 0x000F,
            WM_CLOSE = 0x0010,
            WM_QUERYENDSESSION = 0x0011,
            WM_QUIT = 0x0012,
            WM_QUERYOPEN = 0x0013,
            WM_ERASEBKGND = 0x0014,
            WM_SYSCOLORCHANGE = 0x0015,
            WM_ENDSESSION = 0x0016,
            WM_SHOWWINDOW = 0x0018,
            WM_WININICHANGE = 0x001A,
            WM_SETTINGCHANGE = 0x001A,
            WM_DEVMODECHANGE = 0x001B,
            WM_ACTIVATEAPP = 0x001C,
            WM_FONTCHANGE = 0x001D,
            WM_TIMECHANGE = 0x001E,
            WM_CANCELMODE = 0x001F,
            WM_SETCURSOR = 0x0020,
            WM_MOUSEACTIVATE = 0x0021,
            WM_CHILDACTIVATE = 0x0022,
            WM_QUEUESYNC = 0x0023,
            WM_GETMINMAXINFO = 0x0024,
            WM_PAINTICON = 0x0026,
            WM_ICONERASEBKGND = 0x0027,
            WM_NEXTDLGCTL = 0x0028,
            WM_SPOOLERSTATUS = 0x002A,
            WM_DRAWITEM = 0x002B,
            WM_MEASUREITEM = 0x002C,
            WM_DELETEITEM = 0x002D,
            WM_VKEYTOITEM = 0x002E,
            WM_CHARTOITEM = 0x002F,
            WM_SETFONT = 0x0030,
            WM_GETFONT = 0x0031,
            WM_SETHOTKEY = 0x0032,
            WM_GETHOTKEY = 0x0033,
            WM_QUERYDRAGICON = 0x0037,
            WM_COMPAREITEM = 0x0039,
            WM_GETOBJECT = 0x003D,
            WM_COMPACTING = 0x0041,
            WM_COMMNOTIFY = 0x0044,
            WM_WINDOWPOSCHANGING = 0x0046,
            WM_WINDOWPOSCHANGED = 0x0047,
            WM_POWER = 0x0048,
            WM_COPYDATA = 0x004A,
            WM_CANCELJOURNAL = 0x004B,
            WM_NOTIFY = 0x004E,
            WM_INPUTLANGCHANGEREQUEST = 0x0050,
            WM_INPUTLANGCHANGE = 0x0051,
            WM_TCARD = 0x0052,
            WM_HELP = 0x0053,
            WM_USERCHANGED = 0x0054,
            WM_NOTIFYFORMAT = 0x0055,
            WM_CONTEXTMENU = 0x007B,
            WM_STYLECHANGING = 0x007C,
            WM_STYLECHANGED = 0x007D,
            WM_DISPLAYCHANGE = 0x007E,
            WM_GETICON = 0x007F,
            WM_SETICON = 0x0080,
            WM_NCCREATE = 0x0081,
            WM_NCDESTROY = 0x0082,
            WM_NCCALCSIZE = 0x0083,
            WM_NCHITTEST = 0x0084,
            WM_NCPAINT = 0x0085,
            WM_NCACTIVATE = 0x0086,
            WM_GETDLGCODE = 0x0087,
            WM_SYNCPAINT = 0x0088,
            WM_NCMOUSEMOVE = 0x00A0,
            WM_NCLBUTTONDOWN = 0x00A1,
            WM_NCLBUTTONUP = 0x00A2,
            WM_NCLBUTTONDBLCLK = 0x00A3,
            WM_NCRBUTTONDOWN = 0x00A4,
            WM_NCRBUTTONUP = 0x00A5,
            WM_NCRBUTTONDBLCLK = 0x00A6,
            WM_NCMBUTTONDOWN = 0x00A7,
            WM_NCMBUTTONUP = 0x00A8,
            WM_NCMBUTTONDBLCLK = 0x00A9,
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_DEADCHAR = 0x0103,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105,
            WM_SYSCHAR = 0x0106,
            WM_SYSDEADCHAR = 0x0107,
            WM_KEYLAST = 0x0108,
            WM_IME_STARTCOMPOSITION = 0x010D,
            WM_IME_ENDCOMPOSITION = 0x010E,
            WM_IME_COMPOSITION = 0x010F,
            WM_IME_KEYLAST = 0x010F,
            WM_INITDIALOG = 0x0110,
            WM_COMMAND = 0x0111,
            WM_SYSCOMMAND = 0x0112,
            WM_TIMER = 0x0113,
            WM_HSCROLL = 0x0114,
            WM_VSCROLL = 0x0115,
            WM_INITMENU = 0x0116,
            WM_INITMENUPOPUP = 0x0117,
            WM_MENUSELECT = 0x011F,
            WM_MENUCHAR = 0x0120,
            WM_ENTERIDLE = 0x0121,
            WM_MENURBUTTONUP = 0x0122,
            WM_MENUDRAG = 0x0123,
            WM_MENUGETOBJECT = 0x0124,
            WM_UNINITMENUPOPUP = 0x0125,
            WM_MENUCOMMAND = 0x0126,
            WM_CTLCOLORMSGBOX = 0x0132,
            WM_CTLCOLOREDIT = 0x0133,
            WM_CTLCOLORLISTBOX = 0x0134,
            WM_CTLCOLORBTN = 0x0135,
            WM_CTLCOLORDLG = 0x0136,
            WM_CTLCOLORSCROLLBAR = 0x0137,
            WM_CTLCOLORSTATIC = 0x0138,
            WM_MOUSEMOVE = 0x0200,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_LBUTTONDBLCLK = 0x0203,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_RBUTTONDBLCLK = 0x0206,
            WM_MBUTTONDOWN = 0x0207,
            WM_MBUTTONUP = 0x0208,
            WM_MBUTTONDBLCLK = 0x0209,
            WM_MOUSEWHEEL = 0x020A,
            WM_PARENTNOTIFY = 0x0210,
            WM_ENTERMENULOOP = 0x0211,
            WM_EXITMENULOOP = 0x0212,
            WM_NEXTMENU = 0x0213,
            WM_SIZING = 0x0214,
            WM_CAPTURECHANGED = 0x0215,
            WM_MOVING = 0x0216,
            WM_DEVICECHANGE = 0x0219,
            WM_MDICREATE = 0x0220,
            WM_MDIDESTROY = 0x0221,
            WM_MDIACTIVATE = 0x0222,
            WM_MDIRESTORE = 0x0223,
            WM_MDINEXT = 0x0224,
            WM_MDIMAXIMIZE = 0x0225,
            WM_MDITILE = 0x0226,
            WM_MDICASCADE = 0x0227,
            WM_MDIICONARRANGE = 0x0228,
            WM_MDIGETACTIVE = 0x0229,
            WM_MDISETMENU = 0x0230,
            WM_ENTERSIZEMOVE = 0x0231,
            WM_EXITSIZEMOVE = 0x0232,
            WM_DROPFILES = 0x0233,
            WM_MDIREFRESHMENU = 0x0234,
            WM_IME_SETCONTEXT = 0x0281,
            WM_IME_NOTIFY = 0x0282,
            WM_IME_CONTROL = 0x0283,
            WM_IME_COMPOSITIONFULL = 0x0284,
            WM_IME_SELECT = 0x0285,
            WM_IME_CHAR = 0x0286,
            WM_IME_REQUEST = 0x0288,
            WM_IME_KEYDOWN = 0x0290,
            WM_IME_KEYUP = 0x0291,
            WM_MOUSEHOVER = 0x02A1,
            WM_MOUSELEAVE = 0x02A3,
            WM_CUT = 0x0300,
            WM_COPY = 0x0301,
            WM_PASTE = 0x0302,
            WM_CLEAR = 0x0303,
            WM_UNDO = 0x0304,
            WM_RENDERFORMAT = 0x0305,
            WM_RENDERALLFORMATS = 0x0306,
            WM_DESTROYCLIPBOARD = 0x0307,
            WM_DRAWCLIPBOARD = 0x0308,
            WM_PAINTCLIPBOARD = 0x0309,
            WM_VSCROLLCLIPBOARD = 0x030A,
            WM_SIZECLIPBOARD = 0x030B,
            WM_ASKCBFORMATNAME = 0x030C,
            WM_CHANGECBCHAIN = 0x030D,
            WM_HSCROLLCLIPBOARD = 0x030E,
            WM_QUERYNEWPALETTE = 0x030F,
            WM_PALETTEISCHANGING = 0x0310,
            WM_PALETTECHANGED = 0x0311,
            WM_HOTKEY = 0x0312,
            WM_PRINT = 0x0317,
            WM_PRINTCLIENT = 0x0318,
            WM_HANDHELDFIRST = 0x0358,
            WM_HANDHELDLAST = 0x035F,
            WM_AFXFIRST = 0x0360,
            WM_AFXLAST = 0x037F,
            WM_PENWINFIRST = 0x0380,
            WM_PENWINLAST = 0x038F,
            WM_APP = 0x8000,
            WM_USER = 0x0400
        }

        internal enum HitTest
        {
            HTERROR = -2,
            HTTRANSPARENT = -1,
            HTNOWHERE = 0,
            HTCLIENT = 1,
            HTCAPTION = 2,
            HTSYSMENU = 3,
            HTGROWBOX = 4,
            HTSIZE = 4,
            HTMENU = 5,
            HTHSCROLL = 6,
            HTVSCROLL = 7,
            HTMINBUTTON = 8,
            HTMAXBUTTON = 9,
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17,
            HTBORDER = 18,
            HTREDUCE = 8,
            HTZOOM = 9,
            HTSIZEFIRST = 10,
            HTSIZELAST = 17,
            HTOBJECT = 19,
            HTCLOSE = 20,
            HTHELP = 21
        }

        internal enum ScrollBars : uint
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3
        }

        internal enum GetWindowLongIndex : int
        {
            GWL_STYLE = -16,
            GWL_EXSTYLE = -20
        }

        internal enum FlagsAnimateWindow : uint
        {
            AW_ACTIVATE = 0x20000,
            AW_BLEND = 0x80000,
            AW_CENTER = 0x10,
            AW_HIDE = 0x10000,
            AW_HOR_NEGATIVE = 2,
            AW_HOR_POSITIVE = 1,
            AW_SLIDE = 0x40000,
            AW_VER_NEGATIVE = 8,
            AW_VER_POSITIVE = 4
        }

        internal enum SystemParametersInfoActions : uint
        {
            GetAccessTimeout = 60,
            GetAnimation = 0x48,
            GetBeep = 1,
            GetBorder = 5,
            GetDefaultInputLang = 0x59,
            GetDragFullWindows = 0x26,
            GetFastTaskSwitch = 0x23,
            GetFilterKeys = 50,
            GetFontSmoothing = 0x4a,
            GetGridGranularity = 0x12,
            GetHighContrast = 0x42,
            GetIconMetrics = 0x2d,
            GetIconTitleLogFont = 0x1f,
            GetIconTitleWrap = 0x19,
            GetKeyboardDelay = 0x16,
            GetKeyboardPref = 0x44,
            GetKeyboardSpeed = 10,
            GetLowPowerActive = 0x53,
            GetLowPowerTimeout = 0x4f,
            GetMenuDropAlignment = 0x1b,
            GetMinimizedMetrics = 0x2b,
            GetMouse = 3,
            GetMouseHoverTime = 0x66,
            GetMouseKeys = 0x36,
            GetMouseTrails = 0x5e,
            GetNonClientMetrics = 0x29,
            GetPowerOffActive = 0x54,
            GetPowerOffTimeout = 80,
            GetScreenReader = 70,
            GetScreenSaveActive = 0x10,
            GetScreenSaveTimeout = 14,
            GetSerialKeys = 0x3e,
            GetShowSounds = 0x38,
            GetSoundsEntry = 0x40,
            GetStickyKeys = 0x3a,
            GetToggleKeys = 0x34,
            GetWindwosExtension = 0x5c,
            GetWorkArea = 0x30,
            IconHorizontalSpacing = 13,
            IconVerticalSpacing = 0x18,
            LangDriver = 12,
            ScreenSaverRunning = 0x61,
            SetAccessTimeout = 0x3d,
            SetAnimation = 0x49,
            SetBeep = 2,
            SetBorder = 6,
            SetCursors = 0x57,
            SetDefaultInputLang = 90,
            SetDeskPattern = 0x15,
            SetDeskWallPaper = 20,
            SetDoubleClickTime = 0x20,
            SetDoubleClkHeight = 30,
            SetDoubleClkWidth = 0x1d,
            SetDragFullWindows = 0x25,
            SetDragHeight = 0x4d,
            SetDragWidth = 0x4c,
            SetFastTaskSwitch = 0x24,
            SetFilterKeys = 0x33,
            SetFontSmoothing = 0x4b,
            SetGridGranularity = 0x13,
            SetHandHeld = 0x4e,
            SetHighContrast = 0x43,
            SetIconMetrics = 0x2e,
            SetIcons = 0x58,
            SetIconTitleLogFont = 0x22,
            SetIconTitleWrap = 0x1a,
            SetKeyboardDelay = 0x17,
            SetKeyboardPref = 0x45,
            SetKeyboardSpeed = 11,
            SetLangToggle = 0x5b,
            SetLowPowerActive = 0x55,
            SetLowPowerTimeout = 0x51,
            SetMenuDropAlignment = 0x1c,
            SetMinimizedMetrics = 0x2c,
            SetMouse = 4,
            SetMouseButtonSwap = 0x21,
            SetMouseKeys = 0x37,
            SetMouseTrails = 0x5d,
            SetNonClientMetrics = 0x2a,
            SetPenWindows = 0x31,
            SetPowerOffActive = 0x56,
            SetPowerOffTimeout = 0x52,
            SetScreenReader = 0x47,
            SetScreenSaveActive = 0x11,
            SetScreenSaveTimeout = 15,
            SetSerialKeys = 0x3f,
            SetShowSounds = 0x39,
            SetSoundsEntry = 0x41,
            SetStickyKeys = 0x3b,
            SetToggleKeys = 0x35,
            SetWorkArea = 0x2f
        }

        internal enum FlagsSetWindowPos : uint
        {
            SWP_ASYNCWINDOWPOS = 0x4000,
            SWP_DEFERERASE = 0x2000,
            SWP_DRAWFRAME = 0x20,
            SWP_FRAMECHANGED = 0x20,
            SWP_HIDEWINDOW = 0x80,
            SWP_NOACTIVATE = 0x10,
            SWP_NOCOPYBITS = 0x100,
            SWP_NOMOVE = 2,
            SWP_NOOWNERZORDER = 0x200,
            SWP_NOREDRAW = 8,
            SWP_NOREPOSITION = 0x200,
            SWP_NOSENDCHANGING = 0x400,
            SWP_NOSIZE = 1,
            SWP_NOZORDER = 4,
            SWP_SHOWWINDOW = 0x40
        }

        internal enum HookType : int
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }
    }

}
