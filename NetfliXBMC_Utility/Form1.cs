using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace NetfliXBMC_Utility
{
    public partial class Form1 : Form
    {
        private int acceleration;
        private int minMouseSpeed;
        private int maxMouseSpeed;
        private Point lastMousePosition;
        private long lastMousePositionChange;
        private bool config;

        private ArrayList allKeys;
        private String keyMapUp, keyMapDown, keyMapLeft, keyMapRight, keyMapUpLeft, keyMapUpRight, keyMapDownLeft, keyMapDownRight, keyMapClick, keyMapDoubleClick, keyMapConfig, keyMapQuit, keyMapPlayPause, keyMapSeekBackward, keyMapSeekForward, keyMapVolumeUp, keyMapVolumeDown;

        private const UInt32 MOUSEEVENTF_MOVE = 0x0001;
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("User32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, int dwData, uint dwExtraInf);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("User32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public Form1(String[] args)
        {
            InitializeComponent();

            foreach (Process p in Process.GetProcessesByName("netflixbmc_utility"))
            {
                if (p.Id != Process.GetCurrentProcess().Id)
                    p.Kill();
            }

            buttonCancel.BackColor = Color.LightSteelBlue;

            minMouseSpeed = 10;
            maxMouseSpeed = 10;
            keyMapQuit = "NumPad0";
            keyMapConfig = "Decimal";
            keyMapUp = "NumPad8";
            keyMapDown = "NumPad2";
            keyMapLeft = "NumPad4";
            keyMapRight = "NumPad6";
            keyMapUpLeft = "NumPad7";
            keyMapUpRight = "NumPad9";
            keyMapDownLeft = "NumPad1";
            keyMapDownRight = "NumPad3";
            keyMapClick = "NumPad5";
            keyMapDoubleClick = "Add";
            keyMapPlayPause = "";
            keyMapSeekBackward = "";
            keyMapSeekForward = "";
            keyMapVolumeUp = "";
            keyMapVolumeDown = "";
            textBoxKeyClose.Text = keyMapQuit;
            textBoxKeyConfigure.Text = keyMapConfig;
            textBoxKeyUp.Text = keyMapUp;
            textBoxKeyDown.Text = keyMapDown;
            textBoxKeyLeft.Text = keyMapLeft;
            textBoxKeyRight.Text = keyMapRight;
            textBoxKeyUpLeft.Text = keyMapUpLeft;
            textBoxKeyUpRight.Text = keyMapUpRight;
            textBoxKeyDownLeft.Text = keyMapDownLeft;
            textBoxKeyDownRight.Text = keyMapDownRight;
            textBoxKeyClick.Text = keyMapClick;
            textBoxKeyDoubleClick.Text = keyMapDoubleClick;
            textBoxKeyPlayPause.Text = keyMapPlayPause;
            textBoxKeySeekBackward.Text = keyMapSeekBackward;
            textBoxKeySeekForward.Text = keyMapSeekForward;
            textBoxKeyVolumeUp.Text = keyMapVolumeUp;
            textBoxKeyVolumeDown.Text = keyMapVolumeDown;

            loadSettings();

            allKeys = new ArrayList();
            allKeys.Add(keyMapQuit);
            allKeys.Add(keyMapConfig);

            lastMousePositionChange = 0;
            acceleration = minMouseSpeed;

            config = false;
            if (args.Length > 0)
            {
                config = (args[0] == "yes");
                //hideCursor = (args[1] == "yes");
            }
            if (config)
            {
                this.Show();
            }
            else
            {
                Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                System.Threading.Thread.Sleep(10000);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(5000);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(5000);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }

        private void setAcceleration()
        {
            if ((DateTime.Now.Ticks - lastMousePositionChange) <= 1000000)
            {
                if (acceleration <= maxMouseSpeed)
                    acceleration++;
            }
            else
                acceleration = minMouseSpeed;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position != lastMousePosition)
            {
                lastMousePosition = Cursor.Position;
            }
            try
            {
                String keys = "";
                foreach (int i in Enum.GetValues(typeof(Keys)))
                {
                    if (GetAsyncKeyState(i) == -32767)
                    {
                        keys += Enum.GetName(typeof(Keys), i) + " ";
                    }
                }
                if (this.Visible)
                {
                    keys = keys.Trim();
                    if (keys == "Down")
                    {
                        this.SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    else if (keys == "Up")
                    {
                        this.SelectNextControl(ActiveControl, false, true, true, true);
                    }
                    else if (keys == "Enter" && !buttonSave.Focused && !buttonCancel.Focused)
                    {
                        ((TextBox)ActiveControl).Text = "";
                    }
                    else if (keys == "Enter" && (buttonSave.Focused))
                    {
                        saveSettings();
                        this.Hide();
                    }
                    else if (keys == "Enter" && (buttonCancel.Focused))
                    {
                        this.Hide();
                    }
                    else if (keys != "" && keys != "Left" & keys != "Right")
                    {
                        foreach (Control control in this.Controls)
                        {
                            if (control is TextBox && ((TextBox)control).Focused)
                            {
                                String temp = keys;
                                if (temp.StartsWith("ShiftKey "))
                                    temp = temp.Substring(9);
                                if (temp.StartsWith("Menu "))
                                    temp = temp.Substring(5);
                                ((TextBox)control).Text = temp;
                                this.SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            }
                        }
                    }
                    highlightButton();
                }
                else
                {
                    keys = keys.Trim();
                    if (keys.StartsWith("ShiftKey "))
                        keys = keys.Substring(9);
                    if (keys.StartsWith("Menu "))
                        keys = keys.Substring(5);

                    if (keys != "")
                    {
                        if (keys == keyMapLeft)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X - acceleration, Cursor.Position.Y);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapUp)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapRight)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X + acceleration, Cursor.Position.Y);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapDown)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapUpLeft)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X - acceleration, Cursor.Position.Y - acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapUpRight)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X + acceleration, Cursor.Position.Y - acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapDownLeft)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X - acceleration, Cursor.Position.Y + acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapDownRight)
                        {
                            setAcceleration();
                            Cursor.Position = new Point(Cursor.Position.X + acceleration, Cursor.Position.Y + acceleration);
                            lastMousePositionChange = DateTime.Now.Ticks;
                        }
                        else if (keys == keyMapClick)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        else if (keys == keyMapDoubleClick)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        else if (keys == keyMapQuit)
                        {
                            SendKeys.Send("%{F4}");
                            System.Threading.Thread.Sleep(500);
                            Process[] p = Process.GetProcessesByName("xbmc");
                            if (p.Length > 0)
                            {
                                ShowWindow(p[0].MainWindowHandle, SW_SHOWMAXIMIZED);
                                SetForegroundWindow(p[0].MainWindowHandle);
                            }
                            Process.GetCurrentProcess().Kill();
                        }
                        else if (keys == keyMapConfig)
                        {
                            this.Show();
                            buttonCancel.Focus();
                            buttonCancel.BackColor = Color.LightSteelBlue;
                        }
                        else if (keys == keyMapQuit)
                        {
                            SendKeys.Send("%{F4}");
                        }
                        else if (keys == keyMapPlayPause)
                        {
                            SendKeys.Send("{ENTER}");
                        }
                        else if (keys == keyMapSeekBackward)
                        {
                            SendKeys.Send("{LEFT}");
                        }
                        else if (keys == keyMapSeekForward)
                        {
                            SendKeys.Send("{RIGHT}");
                        }
                        else if (keys == keyMapVolumeUp)
                        {
                            SendKeys.Send("{UP}");
                        }
                        else if (keys == keyMapVolumeDown)
                        {
                            SendKeys.Send("{DOWN}");
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void highlightButton()
        {
            if (buttonSave.Focused)
                buttonSave.BackColor = Color.LightSteelBlue;
            else
                buttonSave.BackColor = Color.White;
            if (buttonCancel.Focused)
                buttonCancel.BackColor = Color.LightSteelBlue;
            else
                buttonCancel.BackColor = Color.White;
        }

        private void button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.IsInputKey = true;
            }
        }

        private void loadSettings()
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("NetfliXBMC_Utility");
                textBoxKeyClose.Text = key.GetValue("keyMapQuit").ToString();
                textBoxKeyConfigure.Text = key.GetValue("keyMapConfig").ToString();
                textBoxKeyUp.Text = key.GetValue("keyMapUp").ToString();
                textBoxKeyDown.Text = key.GetValue("keyMapDown").ToString();
                textBoxKeyLeft.Text = key.GetValue("keyMapLeft").ToString();
                textBoxKeyRight.Text = key.GetValue("keyMapRight").ToString();
                textBoxKeyUpLeft.Text = key.GetValue("keyMapUpLeft").ToString();
                textBoxKeyUpRight.Text = key.GetValue("keyMapUpRight").ToString();
                textBoxKeyDownLeft.Text = key.GetValue("keyMapDownLeft").ToString();
                textBoxKeyDownRight.Text = key.GetValue("keyMapDownRight").ToString();
                textBoxKeyClick.Text = key.GetValue("keyMapClick").ToString();
                textBoxKeyDoubleClick.Text = key.GetValue("keyMapDoubleClick").ToString();
                textBoxKeyPlayPause.Text = key.GetValue("keyMapPlayPause").ToString();
                textBoxKeySeekBackward.Text = key.GetValue("keyMapSeekBackward").ToString();
                textBoxKeySeekForward.Text = key.GetValue("keyMapSeekForward").ToString();
                textBoxKeyVolumeUp.Text = key.GetValue("keyMapVolumeUp").ToString();
                textBoxKeyVolumeDown.Text = key.GetValue("keyMapVolumeDown").ToString();
                keyMapPlayPause = textBoxKeyPlayPause.Text;
                keyMapSeekBackward = textBoxKeySeekBackward.Text;
                keyMapSeekForward = textBoxKeySeekForward.Text;
                keyMapVolumeUp = textBoxKeyVolumeUp.Text;
                keyMapVolumeDown = textBoxKeyVolumeDown.Text;
                keyMapQuit = textBoxKeyClose.Text;
                keyMapConfig = textBoxKeyConfigure.Text;
                keyMapUp = textBoxKeyUp.Text;
                keyMapDown = textBoxKeyDown.Text;
                keyMapLeft = textBoxKeyLeft.Text;
                keyMapRight = textBoxKeyRight.Text;
                keyMapUpLeft = textBoxKeyUpLeft.Text;
                keyMapUpRight = textBoxKeyUpRight.Text;
                keyMapDownLeft = textBoxKeyDownLeft.Text;
                keyMapDownRight = textBoxKeyDownRight.Text;
                keyMapClick = textBoxKeyClick.Text;
                keyMapDoubleClick = textBoxKeyDoubleClick.Text;
                key.Close();
            }
            catch
            {
            }
        }

        private void saveSettings()
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("NetfliXBMC_Utility");
                key.SetValue("keyMapQuit", textBoxKeyClose.Text);
                key.SetValue("keyMapConfig", textBoxKeyConfigure.Text);
                key.SetValue("keyMapUp", textBoxKeyUp.Text);
                key.SetValue("keyMapDown", textBoxKeyDown.Text);
                key.SetValue("keyMapLeft", textBoxKeyLeft.Text);
                key.SetValue("keyMapRight", textBoxKeyRight.Text);
                key.SetValue("keyMapUpLeft", textBoxKeyUpLeft.Text);
                key.SetValue("keyMapUpRight", textBoxKeyUpRight.Text);
                key.SetValue("keyMapDownLeft", textBoxKeyDownLeft.Text);
                key.SetValue("keyMapDownRight", textBoxKeyDownRight.Text);
                key.SetValue("keyMapClick", textBoxKeyClick.Text);
                key.SetValue("keyMapDoubleClick", textBoxKeyDoubleClick.Text);
                key.SetValue("keyMapPlayPause", textBoxKeyPlayPause.Text);
                key.SetValue("keyMapSeekBackward", textBoxKeySeekBackward.Text);
                key.SetValue("keyMapSeekForward", textBoxKeySeekForward.Text);
                key.SetValue("keyMapVolumeUp", textBoxKeyVolumeUp.Text);
                key.SetValue("keyMapVolumeDown", textBoxKeyVolumeDown.Text);
                keyMapPlayPause = textBoxKeyPlayPause.Text;
                keyMapSeekBackward =textBoxKeySeekBackward.Text ;
                keyMapSeekForward = textBoxKeySeekForward.Text;
                keyMapVolumeUp = textBoxKeyVolumeUp.Text;
                keyMapVolumeDown = textBoxKeyVolumeDown.Text;
                keyMapQuit = textBoxKeyClose.Text;
                keyMapConfig = textBoxKeyConfigure.Text;
                keyMapUp = textBoxKeyUp.Text;
                keyMapDown = textBoxKeyDown.Text;
                keyMapLeft = textBoxKeyLeft.Text;
                keyMapRight = textBoxKeyRight.Text;
                keyMapUpLeft = textBoxKeyUpLeft.Text;
                keyMapUpRight = textBoxKeyUpRight.Text;
                keyMapDownLeft = textBoxKeyDownLeft.Text;
                keyMapDownRight = textBoxKeyDownRight.Text;
                keyMapClick = textBoxKeyClick.Text;
                keyMapDoubleClick = textBoxKeyDoubleClick.Text;
                key.Close();
            }
            catch
            {
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveSettings();
            if (config)
                Process.GetCurrentProcess().Kill();
            else
            {
                buttonSave.BackColor = Color.White;
                this.Hide();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (config)
                Process.GetCurrentProcess().Kill();
            else
                this.Hide();
        }
    }
}
