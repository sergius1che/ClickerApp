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
        Del_key = 0x2E,

        ///<summary>HELP</summary>
        Help_key = 0x2F,

        ///<summary>0 key</summary>
        Key_0 = 0x30,

        ///<summary>1 key</summary>
        Key_1 = 0x31,

        ///<summary>2 key</summary>
        Key_2 = 0x32,

        ///<summary>3 key</summary>
        Key_3 = 0x33,

        ///<summary>4 key</summary>
        Key_4 = 0x34,

        ///<summary>5 key</summary>
        Key_5 = 0x35,

        ///<summary>6 key</summary>
        Key_6 = 0x36,

        ///<summary>7 key</summary>
        Key_7 = 0x37,

        ///<summary>8 key</summary>
        Key_8 = 0x38,

        ///<summary>9 key</summary>
        Key_9 = 0x39,

        ///<summary>A key</summary>
        A_key = 0x41,

        ///<summary>B key</summary>
        B_key = 0x42,

        ///<summary>C key</summary>
        C_key = 0x43,

        ///<summary>D key</summary>
        D_key = 0x44,

        ///<summary>E key</summary>
        E_key = 0x45,

        ///<summary>F key</summary>
        F_key = 0x46,

        ///<summary>G key</summary>
        G_key = 0x47,

        ///<summary>H key</summary>
        H_key = 0x48,

        ///<summary>I key</summary>
        I_key = 0x49,

        ///<summary>J key</summary>
        J_key = 0x4A,

        ///<summary>K key</summary>
        K_key = 0x4B,

        ///<summary>L key</summary>
        L_key = 0x4C,

        ///<summary>M key</summary>
        M_key = 0x4D,

        ///<summary>N key</summary>
        N_key = 0x4E,

        ///<summary>O key</summary>
        O_key = 0x4F,

        ///<summary>P key</summary>
        P_key = 0x50,

        ///<summary>Q key</summary>
        Q_key = 0x51,

        ///<summary>R key</summary>
        R_key = 0x52,

        ///<summary>S key</summary>
        S_key = 0x53,

        ///<summary>T key</summary>
        T_key = 0x54,

        ///<summary>U key</summary>
        U_key = 0x55,

        ///<summary>V key</summary>
        V_key = 0x56,

        ///<summary>W key</summary>
        W_key = 0x57,

        ///<summary>X key</summary>
        X_key = 0x58,

        ///<summary>Y key</summary>
        Y_key = 0x59,

        ///<summary>Z key</summary>
        Z_key = 0x5A,

        ///<summary>Left WIN key</summary>
        LWin = 0x5B,

        ///<summary>Right WIN key</summary>
        RWin = 0x5C,

        ///<summary>Applications key (Natural keyboard)</summary>
        Apps = 0x5D,

        ///<summary>Computer Sleep key</summary>
        Sleep = 0x5F,

        ///<summary>NUMPAD0</summary>
        NumPad_0_key = 0x60,

        ///<summary>NUMPAD1</summary>
        NumPad_1_key = 0x61,

        ///<summary>NUMPAD2</summary>
        NumPad_2_key = 0x62,

        ///<summary>NUMPAD3</summary>
        NumPad_3_key = 0x63,

        ///<summary>NUMPAD4</summary>
        NumPad_4_key = 0x64,

        ///<summary>NUMPAD5</summary>
        NumPad_5_key = 0x65,

        ///<summary>NUMPAD6</summary>
        NumPad_6_key = 0x66,

        ///<summary>NUMPAD6</summary>
        NumPad_7_key = 0x67,

        ///<summary>NUMPAD8</summary>
        NumPad_8_key = 0x68D,

        ///<summary>NUMPAD9</summary>
        NumPad_9_key = 0x69,

        ///<summary>MULTIPLY</summary>
        Multiply_key = 0x6A,

        ///<summary>ADD Add key</summary>
        Add_key = 0x6B,

        ///<summary>SEPARATOR</summary>
        Separator_key = 0x6C,

        ///<summary>SUBTRACT</summary>
        Subtract_key = 0x6D,

        ///<summary>DECIMAL</summary>
        Decimal_key = 0x6E,

        ///<summary>DIVIDE</summary>
        Divide_key = 0x6F,

        ///<summary>F1</summary>
        F1_key = 0x70,

        ///<summary>F2</summary>
        F2_key = 0x71,

        ///<summary>F3</summary>
        F3_key = 0x72,

        ///<summary>F4</summary>
        F4_key = 0x73,

        ///<summary>F5</summary>
        F5_key = 0x74,

        ///<summary>F6</summary>
        F6_key = 0x75,

        ///<summary>F7</summary>
        F7_key = 0x76,

        ///<summary>F8</summary>
        F8_key = 0x77,

        ///<summary>F9</summary>
        F9_key = 0x78,

        ///<summary>F10</summary>
        F10_key = 0x79,

        ///<summary>F11</summary>
        F11_key = 0x7A,

        ///<summary>F12</summary>
        F12_key = 0x7B,

        ///<summary>F13</summary>
        F13_key = 0x7C,

        ///<summary>F14</summary>
        F14_key = 0x7D,

        ///<summary>F15</summary>
        F15_key = 0x7E,

        ///<summary>F16</summary>
        F16_key = 0x7F,

        ///<summary>F17</summary>
        F17_key = 0x80,

        ///<summary>F18</summary>
        F18_key = 0x81,

        ///<summary>F19</summary>
        F19_key = 0x82,

        ///<summary>F20</summary>
        F20_key = 0x83,

        ///<summary>F21</summary>
        F21_key = 0x84,

        ///<summary>F22</summary>
        F22_key = 0x85,

        ///<summary>F23</summary>
        F23_key = 0x86,

        ///<summary>F24</summary>
        F24_key = 0x87,

        ///<summary>NUMLOCK</summary>
        NUM_LOCK_key = 0x90,

        ///<summary>SCROLL</summary>
        Scroll_LOCK_key = 0x91,

        ///<summary>LSHIFT</summary>
        Left_SHIFT_key = 0xA0,

        ///<summary>RSHIFT</summary>
        Right_SHIFT_key = 0xA1,

        ///<summary>LCONTROL</summary>
        Left_CONTROL_key = 0xA2,

        ///<summary>RCONTROL</summary>
        Right_CONTROL_key = 0xA3,

        ///<summary>LMENU</summary>
        Left_MENU_key = 0xA4,

        ///<summary>RMENU</summary>
        Right_MENU_key = 0xA5,

        ///<summary>BROWSER_BACK</summary>
        Browser_Back_key = 0xA6,

        ///<summary>BROWSER_FORWARD</summary>
        Browser_Forward_key = 0xA7,

        ///<summary>BROWSER_REFRESH</summary>
        Browser_R_Refresh_key = 0xA8,

        ///<summary>BROWSER_STOP</summary>
        Browser_Stop_key = 0xA9,

        ///<summary>BROWSER_SEARCH</summary>
        Browser_Search_key = 0xAA,

        ///<summary>BROWSER_FAVORITES</summary>
        Browser_Favorites_key = 0xAB,

        ///<summary>BROWSER_HOME</summary>
        Browser_Start_and_Home_key = 0xAC,

        ///<summary>VOLUME_MUTE</summary>
        Volume_Mute_key = 0xAD,

        ///<summary>VOLUME_DOWN</summary>
        Volume_Down_key = 0xAE,

        ///<summary>VOLUME_UP</summary>
        Volume_Up_key = 0xAF,

        ///<summary>MEDIA_NEXT_TRACK</summary>
        Next_Track_key = 0xB0,

        ///<summary>MEDIA_PREV_TRACK</summary>
        Previous_Track_key = 0xB1,

        ///<summary>MEDIA_STOP</summary>
        Stop_Media_key = 0xB2,

        ///<summary>MEDIA_PLAY_PAUSE</summary>
        Play_Pause_Media_key = 0xB3,

        ///<summary>LAUNCH_MAIL</summary>
        Start_Mail_key = 0xB4,

        ///<summary>LAUNCH_MEDIA_SELECT</summary>
        Select_Media_key = 0xB5,

        ///<summary>Start Application 1 key</summary>
        LAUNCH_APP1 = 0xB6,

        ///<summary>Start Application 2 key</summary>
        LAUNCH_APP2 = 0xB7,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';:' key</summary>
        OEM_1 = 0xBA,

        ///<summary>For any country/region, the '+' key</summary>
        OEM_PLUS = 0xBB,

        ///<summary>For any country/region, the ',' key</summary>
        OEM_COMMA = 0xBC,

        ///<summary>For any country/region, the '-' key</summary>
        OEM_MINUS = 0xBD,

        ///<summary>For any country/region, the '.' key</summary>
        OEM_PERIOD = 0xBE,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key</summary>
        OEM_2 = 0xBF,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key</summary>
        OEM_3 = 0xC0,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key</summary>
        OEM_4 = 0xDB,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\|' key</summary>
        OEM_5 = 0xDC,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key</summary>
        OEM_6 = 0xDD,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key</summary>
        OEM_7 = 0xDE,

        ///<summary>Used for miscellaneous characters; it can vary by keyboard.</summary>
        OEM_8 = 0xDF,

        ///<summary>Either the angle bracket key or the backslash key on the RT 102-key keyboard</summary>
        OEM_102 = 0xE2,

        ///<summary>IME PROCESS key</summary>
        PROCESSKEY = 0xE5,

        ///<summary>Used to pass Unicode characters as if they were keystrokes. The PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP</summary>
        PACKET = 0xE7,

        ///<summary>Attn key</summary>
        ATTN = 0xF6,

        ///<summary>CrSel key</summary>
        CRSEL = 0xF7,

        ///<summary>ExSel key</
        EXSEL = 0xF8,

        ///<summary>Erase EOF key</summary>
        EREOF = 0xF9,

        ///<summary>Play key</summary>
        PLAY = 0xFA,

        ///<summary>Zoom key</summary>
        ZOOM = 0xFB,

        ///<summary>Reserved</summary>
        NONAME = 0xFC,

        ///<summary>PA1 key</summary>
        PA1 = 0xFD,

        ///<summary>Clear key</summary>
        OEM_CLEAR = 0xFE

    }
}
