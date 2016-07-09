using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;

public class Settings
{
    private const string Keypath = "Software\\SmartArab\\Suar Snipping Tool";

    public static bool ReadSettings(Options opt)
    {
        RegistryKey rKey = Registry.CurrentUser.OpenSubKey(Keypath);

        if (rKey != null)
        {
            try
            {
                opt.lang = rKey.GetValue("lang", opt.lang).ToString();
            }
            catch
            {
                opt.lang = "en";
            }
            opt.closeafterclipboard = Convert.ToBoolean(rKey.GetValue("closeafterclipboard", opt.closeafterclipboard));
            opt.copylinkafterupload = Convert.ToBoolean(rKey.GetValue("copylinkafterupload", opt.copylinkafterupload));
            opt.modifierhotkey = rKey.GetValue("modifierhotkey", opt.modifierhotkey).ToString();
            opt.hotkey = rKey.GetValue("hotkey", opt.hotkey).ToString();
            rKey.Close();
            return true;
        }
        else
            return false;

    }

    public static void SaveSettings(Options opt)
    {
        RegistryKey rKey = Registry.CurrentUser.OpenSubKey(Keypath, true);

        if (rKey == null)
            rKey = Registry.CurrentUser.CreateSubKey(Keypath);

        rKey.SetValue("closeafterclipboard", opt.closeafterclipboard);
        rKey.SetValue("lang", opt.lang);
        rKey.SetValue("copylinkafterupload", opt.copylinkafterupload);
        rKey.SetValue("modifierhotkey", opt.modifierhotkey);
        rKey.SetValue("hotkey", opt.hotkey);
        rKey.SetValue("lang", opt.lang);

        rKey.Close();
    }
}