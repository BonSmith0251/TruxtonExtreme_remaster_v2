namespace System.Diagnostics;

[Token(Token = "0x200010D")]
internal class ProcessWaitHandle : WaitHandle
{

	[Address(RVA = "0x262F9B0", Offset = "0x262EDB0", Length = "0x5F")]
	[Token(Token = "0x6000672")]
	internal ProcessWaitHandle(SafeProcessHandle processHandle) { }

}

