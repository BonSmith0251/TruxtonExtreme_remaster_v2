namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[Token(Token = "0x200058D")]
public class StackFrame
{
	[Token(Token = "0x4001764")]
	public const int OFFSET_UNKNOWN = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001765")]
	private int ilOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001766")]
	private int nativeOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001767")]
	private long methodAddress; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001768")]
	private uint methodIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001769")]
	private MethodBase methodBase; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400176A")]
	private string fileName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400176B")]
	private int lineNumber; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400176C")]
	private int columnNumber; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400176D")]
	private string internalMethodName; //Field offset: 0x40

	[Address(RVA = "0x1FCEBF0", Offset = "0x1FCDFF0", Length = "0x56")]
	[Token(Token = "0x60028F3")]
	public StackFrame() { }

	[Address(RVA = "0x1FCEB70", Offset = "0x1FCDF70", Length = "0x79")]
	[Token(Token = "0x60028F4")]
	public StackFrame(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCEC50", Offset = "0x1FCE050", Length = "0x5")]
	[Token(Token = "0x60028F2")]
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60028F5")]
	public override int GetFileLineNumber() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60028F6")]
	public override string GetFileName() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60028F8")]
	public override int GetILOffset() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60028FD")]
	internal string GetInternalMethodName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60028F9")]
	public override MethodBase GetMethod() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60028FB")]
	internal long GetMethodAddress() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60028FC")]
	internal uint GetMethodIndex() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60028FA")]
	public override int GetNativeOffset() { }

	[Address(RVA = "0x1FCE900", Offset = "0x1FCDD00", Length = "0x60")]
	[Token(Token = "0x60028F7")]
	internal string GetSecureFileName() { }

	[Address(RVA = "0x1FCE960", Offset = "0x1FCDD60", Length = "0x200")]
	[Token(Token = "0x60028FE")]
	public virtual string ToString() { }

}

