namespace System.Runtime.InteropServices;

[Token(Token = "0x2000459")]
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	[Token(Token = "0x4001227")]
	private const int RefCount_Mask = 2147483644; //Field offset: 0x0
	[Token(Token = "0x4001228")]
	private const int RefCount_One = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001223")]
	protected IntPtr handle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001224")]
	private int _state; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001225")]
	private bool _ownsHandle; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4001226")]
	private bool _fullyInitialized; //Field offset: 0x1D

	[Token(Token = "0x170003F0")]
	public bool IsClosed
	{
		[Address(RVA = "0x1F42120", Offset = "0x1F41520", Length = "0x7")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x600203D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003F1")]
	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x600203E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1F42090", Offset = "0x1F41490", Length = "0x86")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002039")]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle) { }

	[Address(RVA = "0x1F3F9C0", Offset = "0x1F3EDC0", Length = "0x16")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600203F")]
	public void Close() { }

	[Address(RVA = "0x1F41D00", Offset = "0x1F41100", Length = "0x67")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002044")]
	public void DangerousAddRef(ref bool success) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600203C")]
	public IntPtr DangerousGetHandle() { }

	[Address(RVA = "0x1F41E10", Offset = "0x1F41210", Length = "0xA")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002045")]
	public void DangerousRelease() { }

	[Address(RVA = "0x1F41D70", Offset = "0x1F41170", Length = "0x99")]
	[Token(Token = "0x6002048")]
	private void DangerousReleaseInternal(bool dispose) { }

	[Address(RVA = "0x1F3F9C0", Offset = "0x1F3EDC0", Length = "0x16")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002040")]
	public override void Dispose() { }

	[Address(RVA = "0x1F41E20", Offset = "0x1F41220", Length = "0xB2")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002041")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1F41EE0", Offset = "0x1F412E0", Length = "0x65")]
	[Token(Token = "0x600203A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1F42120", Offset = "0x1F41520", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600203D")]
	public bool get_IsClosed() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600203E")]
	public abstract bool get_IsInvalid() { }

	[Address(RVA = "0x1F41F50", Offset = "0x1F41350", Length = "0x94")]
	[Token(Token = "0x6002046")]
	private void InternalDispose() { }

	[Address(RVA = "0x1F41FF0", Offset = "0x1F413F0", Length = "0x11")]
	[Token(Token = "0x6002047")]
	private void InternalFinalize() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002042")]
	protected abstract bool ReleaseHandle() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600203B")]
	protected void SetHandle(IntPtr handle) { }

	[Address(RVA = "0x1F42010", Offset = "0x1F41410", Length = "0x7C")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002043")]
	public void SetHandleAsInvalid() { }

}

