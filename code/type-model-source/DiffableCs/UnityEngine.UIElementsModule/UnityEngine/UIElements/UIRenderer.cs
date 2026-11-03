namespace UnityEngine.UIElements;

[NativeType(Header = "Modules/UIElements/Core/Native/Renderer/UIRenderer.h")]
[Token(Token = "0x20002A8")]
public sealed class UIRenderer : Renderer
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A7E")]
	internal List<CommandList>[] commandLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A7F")]
	internal bool skipRendering; //Field offset: 0x20

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x600125F")]
	public UIRenderer() { }

	[Address(RVA = "0x3410880", Offset = "0x340FC80", Length = "0xD2")]
	[Token(Token = "0x600125C")]
	internal void AddDrawCallData(int safeFrameIndex, int cmdListIndex, Material mat, uint textureSlotCount, uint forceRenderType) { }

	[Address(RVA = "0x3410820", Offset = "0x340FC20", Length = "0x60")]
	[Token(Token = "0x6001260")]
	private static void AddDrawCallData_Injected(IntPtr _unity_self, int safeFrameIndex, int cmdListIndex, IntPtr mat, uint textureSlotCount, uint forceRenderType) { }

	[Address(RVA = "0x3410960", Offset = "0x340FD60", Length = "0xB6")]
	[RequiredByNativeCode]
	[Token(Token = "0x600125E")]
	private static void OnRenderNodeExecute(UIRenderer renderer, int safeFrameIndex, int cmdListIndex) { }

	[Address(RVA = "0x3410A60", Offset = "0x340FE60", Length = "0x76")]
	[Token(Token = "0x600125D")]
	internal void ResetDrawCallData() { }

	[Address(RVA = "0x3410A20", Offset = "0x340FE20", Length = "0x33")]
	[Token(Token = "0x6001261")]
	private static void ResetDrawCallData_Injected(IntPtr _unity_self) { }

}

