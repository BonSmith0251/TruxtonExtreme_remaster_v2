namespace Unity.Audio;

[NativeType(Header = "Modules/Audio/Public/AudioHandle.h")]
[Token(Token = "0x200002E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.DSPGraphModule"})]
internal struct Handle : IEquatable<Handle>
{
	[Token(Token = "0x200002F")]
	public struct Node
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		private Void* Next; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400005F")]
		public int Id; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000060")]
		public int Version; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000061")]
		public int AllocationFlags; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400005C")]
	private IntPtr m_Node; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005D")]
	public int Version; //Field offset: 0x8

	[Token(Token = "0x17000022")]
	internal Node* AtomicNode
	{
		[Address(RVA = "0x2FCA800", Offset = "0x2FC9C00", Length = "0xC")]
		[IsReadOnly]
		[Token(Token = "0x60000CF")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000023")]
	public bool ValidAndNotDisposed
	{
		[Address(RVA = "0x2FCA810", Offset = "0x2FC9C10", Length = "0x53")]
		[IsReadOnly]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x2FCA6C0", Offset = "0x2FC9AC0", Length = "0x8F")]
	[IsReadOnly]
	[Token(Token = "0x60000D3")]
	public void CheckValidOrThrow() { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[IsReadOnly]
	[Token(Token = "0x60000D0")]
	public override bool Equals(Handle other) { }

	[Address(RVA = "0x2FCA750", Offset = "0x2FC9B50", Length = "0xA3")]
	[IsReadOnly]
	[Token(Token = "0x60000D1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FCA800", Offset = "0x2FC9C00", Length = "0xC")]
	[IsReadOnly]
	[Token(Token = "0x60000CF")]
	internal Node* get_AtomicNode() { }

	[Address(RVA = "0x2FCA810", Offset = "0x2FC9C10", Length = "0x53")]
	[IsReadOnly]
	[Token(Token = "0x60000D4")]
	public bool get_ValidAndNotDisposed() { }

	[Address(RVA = "0x2FCA690", Offset = "0x2FC9A90", Length = "0x22")]
	[IsReadOnly]
	[Token(Token = "0x60000D2")]
	public virtual int GetHashCode() { }

}

