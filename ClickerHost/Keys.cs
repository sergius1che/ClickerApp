using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHost
{
    public enum Keys
    {
        ///<summary>LBUTTON</summary>
        Left_mouse_button = 0x01,

        ///<summary>RBUTTON</summary>
        Right_mouse_button = 0x02,

        ///<summary>CANCEL</summary>
        Control_break_processing = 0x03,

        ///<summary>MBUTTON (three-button mouse)</summary>
        Middle_mouse_button = 0x04,

        ///<summary>XBUTTON1</summary>
        X1_mouse_button = 0x05,

        ///<summary>XBUTTON2</summary>
        X2_mouse_button = 0x06,

        ///<summary>BACK</summary>
        Backspace_key = 0x08,

        ///<summary>TAB</summary>
        Tab_key = 0x09,

        ///<summary>CLEAR</summary>
        Clear_key = 0x0C,

        ///<summary>RETURN</summary>
        Enter_key = 0x0D,

        ///<summary>SHIFT</summary>
        Shift_key = 0x10,

        ///<summary>CONTROL</summary>
        Ctrl_key = 0x11,

        ///<summary>MENU</summary>
        Alt_key = 0x12,

        ///<summary>PAUSE</summary>
        Pause_key = 0x13,

        ///<summary>CAPITAL</summary>
        Caps_Lock_key = 0x14,

        ///<summary>KANA</summary>
        Ime_Kana_mode = 0x15,

        ///<summary>HANGUEL (maintained for compatibility; use HANGUL)</summary>
        Ime_Hanguel_mode = 0x15,

        ///<summary>HANGUL</summary>
        Ime_Hangul_mode = 0x15,

        ///<summary>JUNJA</summary>
        Ime_Junja_mode = 0x17,

        ///<summary>FINAL</summary>
        Ime_final_mode = 0x18,

        ///<summary>HANJA</summary>
        Ime_Hanja_mode = 0x19,

        ///<summary>KANJI</summary>
        Ime_Kanji_mode = 0x19,

        ///<summary>ESCAPE</summary>
        Esc_key = 0x1B,

        ///<summary>CONVERT</summary>
        Ime_convert = 0x1C,

        ///<summary>NONCONVERT</summary>
        Ime_nonconvert = 0x1D,

        ///<summary>ACCEPT</summary>
        Ime_accept = 0x1E,

        ///<summary>MODECHANGE</summary>
        Ime_mode_change_request = 0x1F,

        ///<summary>SPACE</summary>
        Spacebar = 0x20,

        ///<summary>PRIOR</summary>
        Page_Up_key = 0x21,

        ///<summary>NEXT</summary>
        Page_Down_key = 0x22,

        ///<summary>END</summary>
        End_key = 0x23,

        ///<summary>HOME</summary>
        Home_key = 0x24,

        ///<summary>LEFT</summary>
        Left_Arrow_key = 0x25,

        ///<summary>UP</summary>
        Up_Arrow_key = 0x26,

        ///<summary>RIGHT</summary>
        Right_Arrow_key = 0x27,

        ///<summary>DOWN</summary>
        Down_Arrow_key = 0x28,

        ///<summary>SELECT</summary>
        Select_key = 0x29,

        ///<summary>PRINT</summary>
        Print_key = 0x2A,

        ///<summary>EXECUTE</summary>
        Execute_key = 0x2B,

        ///<summary>SNAPSHOT</summary>
        Print_Screen_key = 0x2C,

        ///<summary>INSERT</summary>
        Ins_key = 0x2D,

        ///<summary>DELETE</summary>
0x2E
DEL key
///<summary>HELP</summary>
0x2F
HELP key

0x30
0 key
0x31
1 key
0x32
2 key
0x33
3 key
0x34
4 key
0x35
5 key
0x36
6 key
0x37
7 key
0x38
8 key
0x39
9 key
-
0x3A-40
Undefined
0x41
A key
0x42
B key
0x43
C key
0x44
D key
0x45
E key
0x46
F key
0x47
G key
0x48
H key
0x49
I key
0x4A
J key
0x4B
K key
0x4C
L key
0x4D
M key
0x4E
N key
0x4F
O key
0x50
P key
0x51
Q key
0x52
R key
0x53
S key
0x54
T key
0x55
U key
0x56
V key
0x57
W key
0x58
X key
0x59
Y key
0x5A
Z key
///<summary>LWIN
0x5B
Left Windows key (Natural keyboard) 
///<summary>RWIN
0x5C
Right Windows key (Natural keyboard)
///<summary>APPS
0x5D
Applications key (Natural keyboard)
-
0x5E
Reserved
///<summary>SLEEP
0x5F
Computer Sleep key
///<summary>NUMPAD0
0x60
Numeric keypad 0 key
///<summary>NUMPAD1
0x61
Numeric keypad 1 key
///<summary>NUMPAD2
0x62
Numeric keypad 2 key
///<summary>NUMPAD3
0x63
Numeric keypad 3 key
///<summary>NUMPAD4
0x64
Numeric keypad 4 key
///<summary>NUMPAD5
0x65
Numeric keypad 5 key
///<summary>NUMPAD6
0x66
Numeric keypad 6 key
///<summary>NUMPAD7
0x67
Numeric keypad 7 key
///<summary>NUMPAD8
0x68
Numeric keypad 8 key
///<summary>NUMPAD9
0x69
Numeric keypad 9 key
///<summary>MULTIPLY
0x6A
Multiply key
///<summary>ADD
0x6B
Add key
///<summary>SEPARATOR
0x6C
Separator key
///<summary>SUBTRACT
0x6D
Subtract key
///<summary>DECIMAL
0x6E
Decimal key
///<summary>DIVIDE
0x6F
Divide key
///<summary>F1
0x70
F1 key
///<summary>F2
0x71
F2 key
///<summary>F3
0x72
F3 key
///<summary>F4
0x73
F4 key
///<summary>F5
0x74
F5 key
///<summary>F6
0x75
F6 key
///<summary>F7
0x76
F7 key
///<summary>F8
0x77
F8 key
///<summary>F9
0x78
F9 key
///<summary>F10
0x79
F10 key
///<summary>F11
0x7A
F11 key
///<summary>F12
0x7B
F12 key
///<summary>F13
0x7C
F13 key
///<summary>F14
0x7D
F14 key
///<summary>F15
0x7E
F15 key
///<summary>F16
0x7F
F16 key
///<summary>F17
0x80
F17 key
///<summary>F18
0x81
F18 key
///<summary>F19
0x82
F19 key
///<summary>F20
0x83
F20 key
///<summary>F21
0x84
F21 key
///<summary>F22
0x85
F22 key
///<summary>F23
0x86
F23 key
///<summary>F24
0x87
F24 key
-
0x88-8F
Unassigned
///<summary>NUMLOCK
0x90
NUM LOCK key
///<summary>SCROLL
0x91
SCROLL LOCK key
0x92-96
OEM specific
-
0x97-9F
Unassigned
///<summary>LSHIFT
0xA0
Left SHIFT key
///<summary>RSHIFT
0xA1
Right SHIFT key
///<summary>LCONTROL
0xA2
Left CONTROL key
///<summary>RCONTROL
0xA3
Right CONTROL key
///<summary>LMENU
0xA4
Left MENU key
///<summary>RMENU
0xA5
Right MENU key
///<summary>BROWSER_BACK
0xA6
Browser Back key
///<summary>BROWSER_FORWARD
0xA7
Browser Forward key
///<summary>BROWSER_REFRESH
0xA8
Browser Refresh key
///<summary>BROWSER_STOP
0xA9
Browser Stop key
///<summary>BROWSER_SEARCH
0xAA
Browser Search key
///<summary>BROWSER_FAVORITES
0xAB
Browser Favorites key
///<summary>BROWSER_HOME
0xAC
Browser Start and Home key
///<summary>VOLUME_MUTE
0xAD
Volume Mute key
///<summary>VOLUME_DOWN
0xAE
Volume Down key
///<summary>VOLUME_UP
0xAF
Volume Up key
///<summary>MEDIA_NEXT_TRACK
0xB0
Next Track key
///<summary>MEDIA_PREV_TRACK
0xB1
Previous Track key
///<summary>MEDIA_STOP
0xB2
Stop Media key
///<summary>MEDIA_PLAY_PAUSE
0xB3
Play/Pause Media key
///<summary>LAUNCH_MAIL
0xB4
Start Mail key
///<summary>LAUNCH_MEDIA_SELECT
0xB5
Select Media key
///<summary>LAUNCH_APP1
0xB6
Start Application 1 key
///<summary>LAUNCH_APP2
0xB7
Start Application 2 key
-
0xB8-B9
Reserved
///<summary>OEM_1
0xBA
Used for miscellaneous characters; it can vary by keyboard.
For the US standard keyboard, the ';:' key
///<summary>OEM_PLUS
0xBB
For any country/region, the '+' key
///<summary>OEM_COMMA
0xBC
For any country/region, the ',' key
///<summary>OEM_MINUS
0xBD
For any country/region, the '-' key
///<summary>OEM_PERIOD
0xBE
For any country/region, the '.' key
///<summary>OEM_2
0xBF
Used for miscellaneous characters; it can vary by keyboard.
For the US standard keyboard, the '/?' key
///<summary>OEM_3
0xC0
Used for miscellaneous characters; it can vary by keyboard. 
For the US standard keyboard, the '`~' key 
-
0xC1-D7
Reserved
-
0xD8-DA
Unassigned
///<summary>OEM_4
0xDB
Used for miscellaneous characters; it can vary by keyboard. 
For the US standard keyboard, the '[{' key
///<summary>OEM_5
0xDC
Used for miscellaneous characters; it can vary by keyboard. 
For the US standard keyboard, the '\|' key
///<summary>OEM_6
0xDD
Used for miscellaneous characters; it can vary by keyboard. 
For the US standard keyboard, the ']}' key
///<summary>OEM_7
0xDE
Used for miscellaneous characters; it can vary by keyboard. 
For the US standard keyboard, the 'single-quote/double-quote' key
///<summary>OEM_8
0xDF
Used for miscellaneous characters; it can vary by keyboard.
-
0xE0
Reserved
0xE1
OEM specific
///<summary>OEM_102
0xE2
Either the angle bracket key or the backslash key on the RT 102-key keyboard
0xE3-E4
OEM specific
///<summary>PROCESSKEY
0xE5
IME PROCESS key
0xE6
OEM specific
///<summary>PACKET
0xE7
Used to pass Unicode characters as if they were keystrokes. The ///<summary>PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
-
0xE8
Unassigned
0xE9-F5
OEM specific
///<summary>ATTN
0xF6
Attn key
///<summary>CRSEL
0xF7
CrSel key
///<summary>EXSEL
0xF8
ExSel key
///<summary>EREOF
0xF9
Erase EOF key
///<summary>PLAY
0xFA
Play key
///<summary>ZOOM
0xFB
Zoom key
///<summary>NONAME
0xFC
Reserved
///<summary>PA1
0xFD
PA1 key
///<summary>OEM_CLEAR
0xFE
Clear key
    }
}
