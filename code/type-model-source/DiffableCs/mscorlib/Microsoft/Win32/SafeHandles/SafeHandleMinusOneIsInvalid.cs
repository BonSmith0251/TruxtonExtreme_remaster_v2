namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000085")]
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
{

	[Token(Token = "0x17000031")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x1E7C7F0", Offset = "0x1E7BBF0", Length = "0x33")]
		[Token(Token = "0x6000228")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x1E7C7A0", Offset = "0x1E7BBA0", Length = "0x4A")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000227")]
	protected SafeHandleMinusOneIsInvalid(bool ownsHandle) { }

	[Address(RVA = "0x1E7C7F0", Offset = "0x1E7BBF0", Length = "0x33")]
	[Token(Token = "0x6000228")]
	public virtual bool get_IsInvalid() { }

}

