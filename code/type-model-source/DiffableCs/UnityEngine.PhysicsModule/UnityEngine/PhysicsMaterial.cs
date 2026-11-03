namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsMaterial.h")]
[Token(Token = "0x200001B")]
public class PhysicsMaterial : object
{

	[Token(Token = "0x1700002B")]
	public PhysicsMaterialCombine bounceCombine
	{
		[Address(RVA = "0x31369D0", Offset = "0x3135DD0", Length = "0x76")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 118
		[Address(RVA = "0x3136D90", Offset = "0x3136190", Length = "0x83")]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000027")]
	public float bounciness
	{
		[Address(RVA = "0x3136A90", Offset = "0x3135E90", Length = "0x76")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 118
		[Address(RVA = "0x3136E70", Offset = "0x3136270", Length = "0x86")]
		[Token(Token = "0x6000099")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000028")]
	public float dynamicFriction
	{
		[Address(RVA = "0x3136B50", Offset = "0x3135F50", Length = "0x76")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 118
		[Address(RVA = "0x3136F50", Offset = "0x3136350", Length = "0x86")]
		[Token(Token = "0x600009B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700002A")]
	public PhysicsMaterialCombine frictionCombine
	{
		[Address(RVA = "0x3136C10", Offset = "0x3136010", Length = "0x76")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 118
		[Address(RVA = "0x3137020", Offset = "0x3136420", Length = "0x83")]
		[Token(Token = "0x600009F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000029")]
	public float staticFriction
	{
		[Address(RVA = "0x3136CD0", Offset = "0x31360D0", Length = "0x76")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 118
		[Address(RVA = "0x3137100", Offset = "0x3136500", Length = "0x86")]
		[Token(Token = "0x600009D")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x31368B0", Offset = "0x3135CB0", Length = "0x67")]
	[Token(Token = "0x6000095")]
	public PhysicsMaterial() { }

	[Address(RVA = "0x3136920", Offset = "0x3135D20", Length = "0x63")]
	[Token(Token = "0x6000096")]
	public PhysicsMaterial(string name) { }

	[Address(RVA = "0x31369D0", Offset = "0x3135DD0", Length = "0x76")]
	[Token(Token = "0x60000A0")]
	public PhysicsMaterialCombine get_bounceCombine() { }

	[Address(RVA = "0x3136990", Offset = "0x3135D90", Length = "0x33")]
	[Token(Token = "0x60000AB")]
	private static PhysicsMaterialCombine get_bounceCombine_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136A90", Offset = "0x3135E90", Length = "0x76")]
	[Token(Token = "0x6000098")]
	public float get_bounciness() { }

	[Address(RVA = "0x3136A50", Offset = "0x3135E50", Length = "0x33")]
	[Token(Token = "0x60000A3")]
	private static float get_bounciness_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136B50", Offset = "0x3135F50", Length = "0x76")]
	[Token(Token = "0x600009A")]
	public float get_dynamicFriction() { }

	[Address(RVA = "0x3136B10", Offset = "0x3135F10", Length = "0x33")]
	[Token(Token = "0x60000A5")]
	private static float get_dynamicFriction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136C10", Offset = "0x3136010", Length = "0x76")]
	[Token(Token = "0x600009E")]
	public PhysicsMaterialCombine get_frictionCombine() { }

	[Address(RVA = "0x3136BD0", Offset = "0x3135FD0", Length = "0x33")]
	[Token(Token = "0x60000A9")]
	private static PhysicsMaterialCombine get_frictionCombine_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136CD0", Offset = "0x31360D0", Length = "0x76")]
	[Token(Token = "0x600009C")]
	public float get_staticFriction() { }

	[Address(RVA = "0x3136C90", Offset = "0x3136090", Length = "0x33")]
	[Token(Token = "0x60000A7")]
	private static float get_staticFriction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136720", Offset = "0x3135B20", Length = "0x187")]
	[Token(Token = "0x6000097")]
	private static void Internal_CreateDynamicsMaterial(PhysicsMaterial mat, string name) { }

	[Address(RVA = "0x31366D0", Offset = "0x3135AD0", Length = "0x42")]
	[Token(Token = "0x60000A2")]
	private static void Internal_CreateDynamicsMaterial_Injected(PhysicsMaterial mat, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x3136D90", Offset = "0x3136190", Length = "0x83")]
	[Token(Token = "0x60000A1")]
	public void set_bounceCombine(PhysicsMaterialCombine value) { }

	[Address(RVA = "0x3136D50", Offset = "0x3136150", Length = "0x40")]
	[Token(Token = "0x60000AC")]
	private static void set_bounceCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value) { }

	[Address(RVA = "0x3136E70", Offset = "0x3136270", Length = "0x86")]
	[Token(Token = "0x6000099")]
	public void set_bounciness(float value) { }

	[Address(RVA = "0x3136E20", Offset = "0x3136220", Length = "0x43")]
	[Token(Token = "0x60000A4")]
	private static void set_bounciness_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3136F50", Offset = "0x3136350", Length = "0x86")]
	[Token(Token = "0x600009B")]
	public void set_dynamicFriction(float value) { }

	[Address(RVA = "0x3136F00", Offset = "0x3136300", Length = "0x43")]
	[Token(Token = "0x60000A6")]
	private static void set_dynamicFriction_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3137020", Offset = "0x3136420", Length = "0x83")]
	[Token(Token = "0x600009F")]
	public void set_frictionCombine(PhysicsMaterialCombine value) { }

	[Address(RVA = "0x3136FE0", Offset = "0x31363E0", Length = "0x40")]
	[Token(Token = "0x60000AA")]
	private static void set_frictionCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value) { }

	[Address(RVA = "0x3137100", Offset = "0x3136500", Length = "0x86")]
	[Token(Token = "0x600009D")]
	public void set_staticFriction(float value) { }

	[Address(RVA = "0x31370B0", Offset = "0x31364B0", Length = "0x43")]
	[Token(Token = "0x60000A8")]
	private static void set_staticFriction_Injected(IntPtr _unity_self, float value) { }

}

