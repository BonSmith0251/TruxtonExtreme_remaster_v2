namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000083")]
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x1E7C710", Offset = "0x1E7BB10", Length = "0x29")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000223")]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) { }

	[Address(RVA = "0x1E7CB30", Offset = "0x1E7BF30", Length = "0x16")]
	[Token(Token = "0x6000224")]
	protected virtual bool ReleaseHandle() { }

}

