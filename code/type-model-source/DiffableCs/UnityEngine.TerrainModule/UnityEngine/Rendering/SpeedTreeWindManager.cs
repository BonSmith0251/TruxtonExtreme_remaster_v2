namespace UnityEngine.Rendering;

[NativeHeader("Modules/Terrain/Public/SpeedTreeWindManager.h")]
[StaticAccessor("GetSpeedTreeWindManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000011")]
internal static class SpeedTreeWindManager
{

	[Address(RVA = "0x3167C00", Offset = "0x3167000", Length = "0xB4")]
	[Token(Token = "0x6000048")]
	public static void UpdateWindAndWriteBufferWindParams(ReadOnlySpan<Int32> renderersID, SpeedTreeWindParamsBufferIterator windParams, bool history) { }

	[Address(RVA = "0x3167BA0", Offset = "0x3166FA0", Length = "0x54")]
	[Token(Token = "0x6000049")]
	private static void UpdateWindAndWriteBufferWindParams_Injected(ref ManagedSpanWrapper renderersID, in SpeedTreeWindParamsBufferIterator windParams, bool history) { }

}

