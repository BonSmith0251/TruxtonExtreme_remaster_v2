namespace UnityEngine.Audio;

[IsReadOnly]
[Token(Token = "0x200001B")]
public struct ProcessorInstance : IEquatable<ProcessorInstance>
{
	[Token(Token = "0x200001C")]
	internal struct CreationParameters
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		private UpdateSetting <controlUpdateSetting>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400003E")]
		private UpdateSetting <realtimeUpdateSetting>k__BackingField; //Field offset: 0x4

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200001E")]
	internal struct Message
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		internal long TypeHash; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000045")]
		internal Void* Data; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000046")]
		internal IntPtr ManagedHandle; //Field offset: 0x10

	}

	[Token(Token = "0x200001D")]
	internal enum UpdateSetting : int
	{
		Default = 0,
		NeverUpdate = 1,
		UpdateIfDataIsAvailable = 2,
		UpdateAlways = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003B")]
	internal readonly Handle Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003C")]
	internal readonly ProcessorHeader* Header; //Field offset: 0x10

	[Address(RVA = "0x2FCA5A0", Offset = "0x2FC99A0", Length = "0x33")]
	[Token(Token = "0x6000096")]
	public override bool Equals(ProcessorInstance other) { }

	[Address(RVA = "0x2FCA870", Offset = "0x2FC9C70", Length = "0xAB")]
	[Token(Token = "0x6000097")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FCA690", Offset = "0x2FC9A90", Length = "0x22")]
	[Token(Token = "0x6000098")]
	public virtual int GetHashCode() { }

}

