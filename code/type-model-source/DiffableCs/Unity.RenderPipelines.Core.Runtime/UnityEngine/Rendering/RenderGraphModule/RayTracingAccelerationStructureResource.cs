namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RayTracingAccelerationStructureResource ({desc.name})")]
[Token(Token = "0x2000286")]
internal class RayTracingAccelerationStructureResource : RenderGraphResource<RayTracingAccelerationStructureDesc, RayTracingAccelerationStructure>
{

	[Address(RVA = "0x2C9C420", Offset = "0x2C9B820", Length = "0x39")]
	[Token(Token = "0x6001219")]
	public RayTracingAccelerationStructureResource() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001218")]
	public virtual string GetName() { }

}

