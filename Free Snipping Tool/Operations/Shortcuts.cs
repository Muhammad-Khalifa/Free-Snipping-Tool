using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


class Shortcuts
{
    public static string[] keys = { "PrintScreen", "Home", "End", "PageUp", "PageDown", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
    public static string[] Modifiers = { "Windows", "Shift", "Control", "Alt" };

    public const int HOTKEY_ID = 31197;
    public const int WM_HOTKEY = 0x0312;

    private enum KeyModifiers
    {
        None = 0,
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8
    }


    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    public static void ApplyHotKey(IntPtr handle, string Key, string Modfiers)
    {
        RemoveHotKey(handle);

        KeyModifiers modfierkey = (KeyModifiers)Enum.Parse(typeof(KeyModifiers), Modfiers);
        RegisterHotKey(handle, HOTKEY_ID, modfierkey, TypesConvertor.ConvertStringToKey(Key));
    }

    public static void RemoveHotKey(IntPtr handle)
    {
        UnregisterHotKey(handle, HOTKEY_ID);
    }
}

