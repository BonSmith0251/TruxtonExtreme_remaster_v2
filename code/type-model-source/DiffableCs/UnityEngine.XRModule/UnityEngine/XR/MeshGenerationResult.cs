namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200001E")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008B")]
	private readonly MeshId <MeshId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008C")]
	private readonly Mesh <Mesh>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008D")]
	private readonly MeshCollider <MeshCollider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008E")]
	private readonly MeshGenerationStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400008F")]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000090")]
	private readonly ulong <Timestamp>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000091")]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000092")]
	private readonly Quaternion <Rotation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000093")]
	private readonly Vector3 <Scale>k__BackingField; //Field offset: 0x4C

	[Token(Token = "0x1700001A")]
	public MeshVertexAttributes Attributes
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000068")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	public Mesh Mesh
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000018")]
	public MeshCollider MeshCollider
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000066")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public MeshId MeshId
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000064")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700001B")]
	public Vector3 Position
	{
		[Address(RVA = "0x2BC3BF0", Offset = "0x2BC2FF0", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000069")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700001C")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x31E36F0", Offset = "0x31E2AF0", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600006A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700001D")]
	public Vector3 Scale
	{
		[Address(RVA = "0x3492450", Offset = "0x3491850", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600006B")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000019")]
	public MeshGenerationStatus Status
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000067")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x3491F00", Offset = "0x3491300", Length = "0xD2")]
	[Token(Token = "0x600006C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3491FE0", Offset = "0x34913E0", Length = "0x206")]
	[Token(Token = "0x600006D")]
	public override bool Equals(MeshGenerationResult other) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000068")]
	public MeshVertexAttributes get_Attributes() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000065")]
	public Mesh get_Mesh() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000066")]
	public MeshCollider get_MeshCollider() { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000064")]
	public MeshId get_MeshId() { }

	[Address(RVA = "0x2BC3BF0", Offset = "0x2BC2FF0", Length = "0x13")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000069")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x31E36F0", Offset = "0x31E2AF0", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600006A")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x3492450", Offset = "0x3491850", Length = "0x13")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600006B")]
	public Vector3 get_Scale() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000067")]
	public MeshGenerationStatus get_Status() { }

	[Address(RVA = "0x34921F0", Offset = "0x34915F0", Length = "0x25B")]
	[Token(Token = "0x600006E")]
	public virtual int GetHashCode() { }

}

