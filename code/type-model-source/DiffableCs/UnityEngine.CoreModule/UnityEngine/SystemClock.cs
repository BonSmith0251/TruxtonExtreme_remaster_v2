namespace UnityEngine;

[Token(Token = "0x20001EC")]
[VisibleToOtherModules]
internal class SystemClock
{
	[Token(Token = "0x40006DE")]
	private static readonly DateTime s_Epoch; //Field offset: 0x0

	[Token(Token = "0x1700032D")]
	public static DateTime now
	{
		[Address(RVA = "0x308A0F0", Offset = "0x30894F0", Length = "0x40")]
		[Token(Token = "0x60015CB")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x308A070", Offset = "0x3089470", Length = "0x73")]
	[Token(Token = "0x60015CC")]
	private static SystemClock() { }

	[Address(RVA = "0x308A0F0", Offset = "0x30894F0", Length = "0x40")]
	[Token(Token = "0x60015CB")]
	public static DateTime get_now() { }

}

