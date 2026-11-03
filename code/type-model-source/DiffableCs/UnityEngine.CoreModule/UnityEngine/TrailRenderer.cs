namespace UnityEngine;

[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[Token(Token = "0x20000E8")]
public sealed class TrailRenderer : Renderer
{

	[Token(Token = "0x1700013F")]
	public float endWidth
	{
		[Address(RVA = "0x301B750", Offset = "0x301AB50", Length = "0x76")]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 118
		[Address(RVA = "0x301B9A0", Offset = "0x301ADA0", Length = "0x86")]
		[Token(Token = "0x60006C5")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700013E")]
	public float startWidth
	{
		[Address(RVA = "0x301B810", Offset = "0x301AC10", Length = "0x76")]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 118
		[Address(RVA = "0x301BA80", Offset = "0x301AE80", Length = "0x86")]
		[Token(Token = "0x60006C3")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700013D")]
	public float time
	{
		[Address(RVA = "0x301B8D0", Offset = "0x301ACD0", Length = "0x76")]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 118
		[Address(RVA = "0x301BB60", Offset = "0x301AF60", Length = "0x1D0")]
		[Token(Token = "0x60006C1")]
		 set { } //Length: 464
	}

	[Address(RVA = "0x301B750", Offset = "0x301AB50", Length = "0x76")]
	[Token(Token = "0x60006C4")]
	public float get_endWidth() { }

	[Address(RVA = "0x301B710", Offset = "0x301AB10", Length = "0x33")]
	[Token(Token = "0x60006CA")]
	private static float get_endWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B810", Offset = "0x301AC10", Length = "0x76")]
	[Token(Token = "0x60006C2")]
	public float get_startWidth() { }

	[Address(RVA = "0x301B7D0", Offset = "0x301ABD0", Length = "0x33")]
	[Token(Token = "0x60006C8")]
	private static float get_startWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B8D0", Offset = "0x301ACD0", Length = "0x76")]
	[Token(Token = "0x60006C0")]
	public float get_time() { }

	[Address(RVA = "0x301B890", Offset = "0x301AC90", Length = "0x33")]
	[Token(Token = "0x60006C6")]
	private static float get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B9A0", Offset = "0x301ADA0", Length = "0x86")]
	[Token(Token = "0x60006C5")]
	public void set_endWidth(float value) { }

	[Address(RVA = "0x301B950", Offset = "0x301AD50", Length = "0x43")]
	[Token(Token = "0x60006CB")]
	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x301BA80", Offset = "0x301AE80", Length = "0x86")]
	[Token(Token = "0x60006C3")]
	public void set_startWidth(float value) { }

	[Address(RVA = "0x301BA30", Offset = "0x301AE30", Length = "0x43")]
	[Token(Token = "0x60006C9")]
	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x301BB60", Offset = "0x301AF60", Length = "0x1D0")]
	[Token(Token = "0x60006C1")]
	public void set_time(float value) { }

	[Address(RVA = "0x301BB10", Offset = "0x301AF10", Length = "0x43")]
	[Token(Token = "0x60006C7")]
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

}

