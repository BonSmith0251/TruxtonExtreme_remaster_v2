namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000010")]
public sealed class Rigidbody2D : Component
{

	[Token(Token = "0x17000017")]
	public RigidbodyType2D bodyType
	{
		[Address(RVA = "0x31331B0", Offset = "0x31325B0", Length = "0x83")]
		[NativeMethod("SetBodyType_Binding")]
		[Token(Token = "0x600004F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000019")]
	public RigidbodyInterpolation2D interpolation
	{
		[Address(RVA = "0x3133280", Offset = "0x3132680", Length = "0x83")]
		[Token(Token = "0x6000052")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000015")]
	public Vector2 linearVelocity
	{
		[Address(RVA = "0x3132D90", Offset = "0x3132190", Length = "0x87")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700001B")]
	public Matrix4x4 localToWorldMatrix
	{
		[Address(RVA = "0x3132E70", Offset = "0x3132270", Length = "0x9A")]
		[Token(Token = "0x6000054")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000016")]
	public float mass
	{
		[Address(RVA = "0x3132F50", Offset = "0x3132350", Length = "0x76")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000013")]
	public Vector2 position
	{
		[Address(RVA = "0x3133020", Offset = "0x3132420", Length = "0x87")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 135
		[Address(RVA = "0x3133360", Offset = "0x3132760", Length = "0x80")]
		[Token(Token = "0x6000048")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000014")]
	public float rotation
	{
		[Address(RVA = "0x31330F0", Offset = "0x31324F0", Length = "0x76")]
		[Token(Token = "0x6000049")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000018")]
	public bool simulated
	{
		[Address(RVA = "0x3133440", Offset = "0x3132840", Length = "0x86")]
		[NativeMethod("SetSimulated_Binding")]
		[Token(Token = "0x6000051")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700001A")]
	public RigidbodySleepMode2D sleepMode
	{
		[Address(RVA = "0x3133510", Offset = "0x3132910", Length = "0x83")]
		[Token(Token = "0x6000053")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000055")]
	public Rigidbody2D() { }

	[Address(RVA = "0x3132D90", Offset = "0x3132190", Length = "0x87")]
	[Token(Token = "0x600004D")]
	public Vector2 get_linearVelocity() { }

	[Address(RVA = "0x3132D40", Offset = "0x3132140", Length = "0x42")]
	[Token(Token = "0x600005B")]
	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3132E70", Offset = "0x3132270", Length = "0x9A")]
	[Token(Token = "0x6000054")]
	public Matrix4x4 get_localToWorldMatrix() { }

	[Address(RVA = "0x3132E20", Offset = "0x3132220", Length = "0x42")]
	[Token(Token = "0x6000062")]
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x3132F50", Offset = "0x3132350", Length = "0x76")]
	[Token(Token = "0x600004E")]
	public float get_mass() { }

	[Address(RVA = "0x3132F10", Offset = "0x3132310", Length = "0x33")]
	[Token(Token = "0x600005C")]
	private static float get_mass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3133020", Offset = "0x3132420", Length = "0x87")]
	[Token(Token = "0x6000047")]
	public Vector2 get_position() { }

	[Address(RVA = "0x3132FD0", Offset = "0x31323D0", Length = "0x42")]
	[Token(Token = "0x6000056")]
	private static void get_position_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x31330F0", Offset = "0x31324F0", Length = "0x76")]
	[Token(Token = "0x6000049")]
	public float get_rotation() { }

	[Address(RVA = "0x31330B0", Offset = "0x31324B0", Length = "0x33")]
	[Token(Token = "0x6000058")]
	private static float get_rotation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3132B10", Offset = "0x3131F10", Length = "0x80")]
	[Token(Token = "0x600004A")]
	public void MovePosition(Vector2 position) { }

	[Address(RVA = "0x3132AC0", Offset = "0x3131EC0", Length = "0x42")]
	[Token(Token = "0x6000059")]
	private static void MovePosition_Injected(IntPtr _unity_self, in Vector2 position) { }

	[Address(RVA = "0x3132BF0", Offset = "0x3131FF0", Length = "0x86")]
	[Token(Token = "0x600004B")]
	public void MoveRotation(float angle) { }

	[Address(RVA = "0x3132BF0", Offset = "0x3131FF0", Length = "0x86")]
	[NativeMethod("MoveRotation")]
	[Token(Token = "0x600004C")]
	private void MoveRotation_Angle(float angle) { }

	[Address(RVA = "0x3132BA0", Offset = "0x3131FA0", Length = "0x43")]
	[Token(Token = "0x600005A")]
	private static void MoveRotation_Angle_Injected(IntPtr _unity_self, float angle) { }

	[Address(RVA = "0x31331B0", Offset = "0x31325B0", Length = "0x83")]
	[NativeMethod("SetBodyType_Binding")]
	[Token(Token = "0x600004F")]
	public void set_bodyType(RigidbodyType2D value) { }

	[Address(RVA = "0x3133170", Offset = "0x3132570", Length = "0x40")]
	[Token(Token = "0x600005D")]
	private static void set_bodyType_Injected(IntPtr _unity_self, RigidbodyType2D value) { }

	[Address(RVA = "0x3133280", Offset = "0x3132680", Length = "0x83")]
	[Token(Token = "0x6000052")]
	public void set_interpolation(RigidbodyInterpolation2D value) { }

	[Address(RVA = "0x3133240", Offset = "0x3132640", Length = "0x40")]
	[Token(Token = "0x6000060")]
	private static void set_interpolation_Injected(IntPtr _unity_self, RigidbodyInterpolation2D value) { }

	[Address(RVA = "0x3133360", Offset = "0x3132760", Length = "0x80")]
	[Token(Token = "0x6000048")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x3133310", Offset = "0x3132710", Length = "0x42")]
	[Token(Token = "0x6000057")]
	private static void set_position_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3133440", Offset = "0x3132840", Length = "0x86")]
	[NativeMethod("SetSimulated_Binding")]
	[Token(Token = "0x6000051")]
	public void set_simulated(bool value) { }

	[Address(RVA = "0x31333F0", Offset = "0x31327F0", Length = "0x42")]
	[Token(Token = "0x600005F")]
	private static void set_simulated_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3133510", Offset = "0x3132910", Length = "0x83")]
	[Token(Token = "0x6000053")]
	public void set_sleepMode(RigidbodySleepMode2D value) { }

	[Address(RVA = "0x31334D0", Offset = "0x31328D0", Length = "0x40")]
	[Token(Token = "0x6000061")]
	private static void set_sleepMode_Injected(IntPtr _unity_self, RigidbodySleepMode2D value) { }

	[Address(RVA = "0x3132CC0", Offset = "0x31320C0", Length = "0x76")]
	[Token(Token = "0x6000050")]
	public void Sleep() { }

	[Address(RVA = "0x3132C80", Offset = "0x3132080", Length = "0x33")]
	[Token(Token = "0x600005E")]
	private static void Sleep_Injected(IntPtr _unity_self) { }

}

