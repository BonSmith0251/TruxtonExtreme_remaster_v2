namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000417")]
public static class Lightmapping
{
	[CompilerGenerated]
	[Token(Token = "0x2000419")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E0E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x30D0360", Offset = "0x30CF760", Length = "0x67")]
		[Token(Token = "0x6001F50")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001F51")]
		public <>c() { }

		[Address(RVA = "0x30CFDC0", Offset = "0x30CF1C0", Length = "0x596")]
		[Token(Token = "0x6001F52")]
		internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	[Token(Token = "0x2000418")]
	internal sealed class RequestLightsDelegate : MulticastDelegate
	{

		[Address(RVA = "0x30C7FE0", Offset = "0x30C73E0", Length = "0xB5")]
		[Token(Token = "0x6001F4E")]
		public RequestLightsDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x169F5F0", Offset = "0x169E9F0", Length = "0x25")]
		[Token(Token = "0x6001F4F")]
		public override void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	[RequiredByNativeCode]
	[Token(Token = "0x4000E0C")]
	private static readonly RequestLightsDelegate s_DefaultDelegate; //Field offset: 0x0
	[RequiredByNativeCode]
	[Token(Token = "0x4000E0D")]
	private static RequestLightsDelegate s_RequestLightsDelegate; //Field offset: 0x8

	[Address(RVA = "0x30C1DA0", Offset = "0x30C11A0", Length = "0x187")]
	[Token(Token = "0x6001F4D")]
	private static Lightmapping() { }

	[Address(RVA = "0x30C1B70", Offset = "0x30C0F70", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F4A")]
	public static RequestLightsDelegate GetDelegate() { }

	[Address(RVA = "0x30C1BC0", Offset = "0x30C0FC0", Length = "0xD1")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F4C")]
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	[Address(RVA = "0x30C1CA0", Offset = "0x30C10A0", Length = "0x65")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F4B")]
	public static void ResetDelegate() { }

	[Address(RVA = "0x30C1D10", Offset = "0x30C1110", Length = "0x8E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F49")]
	public static void SetDelegate(RequestLightsDelegate del) { }

}

