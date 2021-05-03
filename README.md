# Arduino-Taiko-Serial
DIY a arduino hardware to playing osu! taiko mode via USB serial port communication.

## Introduction

This program for 2021 workshop at **university of Macau** and present by Mane.

This Demo be used to explain how to communicate between software and chip via serial port.

Only work on Windows, If you need to simulate the keyboard, you need to use the software to listen what data send back to serial port.

If you are using MAC OS, you need to reference how to simulate the keyboard via bluetooth.

## Structure

**Application**

- Main Program : Using **C#** depend on **.Net Framework 4.7.2** Compile successfully in **visual studio 2019**. Available in [releases](https://github.com/Mane-Network-Team/Arduino-Taiko-Serial/releases).

**Arduino**

- Test : random send 4 key to serial port.

## Test

Flash the **test.ino** to chip, and open the main program. Be sure that **NO DEBUG OUTPUT** for serial port.

## Note

For simulate the keyboard, I found that using Win32 API **DO NOT WORK** on osu!

```C#
[DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
```

So I change the code using `System.Windows.Forms.SendKeys` to simulation the keyboard which is [SendKeys.SendWait(String) Method](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.sendwait?view=netframework-4.7.2). 

## Depend

- [XamlBehaviorsWpf](https://github.com/microsoft/XamlBehaviorsWpf)
- [ControlzEx](https://github.com/ControlzEx/ControlzEx)
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro)
- [MahApps.Metro.IconPacks](https://github.com/MahApps/MahApps.Metro.IconPacks)

## License

- Base of the version 3 of the GNU General Public License.

**Addition**

- Commercial use is not allowed.