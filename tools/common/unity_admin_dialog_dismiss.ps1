# Presses "I wish to continue at my own risk" on Unity's "Unity is running as administrator." dialog, which a GUI
# editor shows at startup when launched from an elevated (built-in Administrator) session. Unity has no switch to
# suppress it. The dialog is a Win32 #32770 box whose buttons are plain Button child windows (UI Automation does not
# expose them), so this finds that dialog by its title, finds the button by its text and sends it BM_CLICK.
# Only that dialog and that button are touched. Runs until -Seconds pass or the -StopFile appears.
param([int]$Seconds=1800,[string]$StopFile="")
Add-Type -TypeDefinition @'
using System;using System.Text;using System.Runtime.InteropServices;
public static class UnityAdminDialog{
 delegate bool EnumProc(IntPtr h,IntPtr l);
 [DllImport("user32.dll")] static extern bool EnumChildWindows(IntPtr p,EnumProc f,IntPtr l);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)] static extern int GetWindowText(IntPtr h,StringBuilder s,int n);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)] static extern IntPtr FindWindow(string c,string t);
 [DllImport("user32.dll")] static extern IntPtr SendMessage(IntPtr h,uint m,IntPtr w,IntPtr l);
 public static bool Continue(){
  var d=FindWindow("#32770","Unity is running as administrator.");if(d==IntPtr.Zero)return false;IntPtr btn=IntPtr.Zero;
  EnumChildWindows(d,(h,l)=>{var s=new StringBuilder(256);GetWindowText(h,s,256);if(s.ToString().Replace("&","")=="I wish to continue at my own risk"){btn=h;return false;}return true;},IntPtr.Zero);
  if(btn==IntPtr.Zero)return false;SendMessage(btn,0x00F5,IntPtr.Zero,IntPtr.Zero);return true;}
}
'@
$end=(Get-Date).AddSeconds($Seconds)
while((Get-Date) -lt $end){
    if($StopFile -and (Test-Path $StopFile)){break}
    if([UnityAdminDialog]::Continue()){Write-Output ("dismissed Unity admin dialog at "+(Get-Date -Format HH:mm:ss))}
    Start-Sleep -Milliseconds 500
}
