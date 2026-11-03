namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000084")]
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{

	[Token(Token = "0x17000030")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x1E7C840", Offset = "0x1E7BC40", Length = "0x4D")]
		[Token(Token = "0x6000226")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x1E7C830", Offset = "0x1E7BC30", Length = "0xE")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000225")]
	protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) { }

	[Address(RVA = "0x1E7C840", Offset = "0x1E7BC40", Length = "0x4D")]
	[Token(Token = "0x6000226")]
	public virtual bool get_IsInvalid() { }

}

