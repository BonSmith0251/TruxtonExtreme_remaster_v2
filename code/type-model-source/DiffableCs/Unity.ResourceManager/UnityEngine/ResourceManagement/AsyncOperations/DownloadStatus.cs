namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000084")]
public struct DownloadStatus
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000170")]
	public long TotalBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000171")]
	public long DownloadedBytes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000172")]
	public bool IsDone; //Field offset: 0x10

	[Token(Token = "0x170000C1")]
	public float Percent
	{
		[Address(RVA = "0x2E3EB10", Offset = "0x2E3DF10", Length = "0x2F")]
		[Token(Token = "0x600035E")]
		 get { } //Length: 47
	}

	[Address(RVA = "0x2E3EB10", Offset = "0x2E3DF10", Length = "0x2F")]
	[Token(Token = "0x600035E")]
	public float get_Percent() { }

}

