namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RayTracingAccelerationStructure ({handle.index})")]
[IsReadOnly]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000284")]
public struct RayTracingAccelerationStructureHandle
{
	[Token(Token = "0x4000B57")]
	private static RayTracingAccelerationStructureHandle s_NullHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B58")]
	internal readonly ResourceHandle handle; //Field offset: 0x0

	[Token(Token = "0x17000253")]
	public static RayTracingAccelerationStructureHandle nullHandle
	{
		[Address(RVA = "0x2C9C160", Offset = "0x2C9B560", Length = "0x62")]
		[Token(Token = "0x6001213")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001217")]
	private static RayTracingAccelerationStructureHandle() { }

	[Address(RVA = "0x2C9C0D0", Offset = "0x2C9B4D0", Length = "0x85")]
	[Token(Token = "0x6001214")]
	internal RayTracingAccelerationStructureHandle(int handle) { }

	[Address(RVA = "0x2C9C160", Offset = "0x2C9B560", Length = "0x62")]
	[Token(Token = "0x6001213")]
	public static RayTracingAccelerationStructureHandle get_nullHandle() { }

	[Address(RVA = "0x2C9C080", Offset = "0x2C9B480", Length = "0x49")]
	[Token(Token = "0x6001216")]
	public bool IsValid() { }

	[Address(RVA = "0x2C9C1D0", Offset = "0x2C9B5D0", Length = "0x24C")]
	[Token(Token = "0x6001215")]
	public static RayTracingAccelerationStructure op_Implicit(RayTracingAccelerationStructureHandle handle) { }

}

