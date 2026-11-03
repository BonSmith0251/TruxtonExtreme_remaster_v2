namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/Marker.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[Token(Token = "0x2000204")]
[UsedByNativeCode]
public sealed class CustomSampler : Sampler
{
	[Token(Token = "0x2000205")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001720")]
		public static IntPtr ConvertToNative(CustomSampler customSampler) { }

	}

	[Token(Token = "0x400073A")]
	internal static CustomSampler s_InvalidCustomSampler; //Field offset: 0x0

	[Address(RVA = "0x3078520", Offset = "0x3077920", Length = "0x98")]
	[Token(Token = "0x600171F")]
	private static CustomSampler() { }

	[Address(RVA = "0x30785C0", Offset = "0x30779C0", Length = "0x49")]
	[Token(Token = "0x600171C")]
	internal CustomSampler() { }

	[Address(RVA = "0x3078610", Offset = "0x3077A10", Length = "0x5A")]
	[Token(Token = "0x600171D")]
	private CustomSampler(IntPtr ptr) { }

	[Address(RVA = "0x3078430", Offset = "0x3077830", Length = "0xEE")]
	[Token(Token = "0x600171E")]
	public static CustomSampler Create(string name, bool collectGpuData = false) { }

}

