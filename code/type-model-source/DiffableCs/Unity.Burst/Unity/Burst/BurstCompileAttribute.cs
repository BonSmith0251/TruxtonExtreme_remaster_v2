namespace Unity.Burst;

[AttributeUsage(77)]
[Token(Token = "0x2000009")]
public class BurstCompileAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000016")]
	private FloatMode <FloatMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000017")]
	private FloatPrecision <FloatPrecision>k__BackingField; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000018")]
	internal Nullable<Boolean> _compileSynchronously; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000019")]
	internal Nullable<Boolean> _debug; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400001A")]
	internal Nullable<Boolean> _disableSafetyChecks; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1E")]
	[Token(Token = "0x400001B")]
	internal Nullable<Boolean> _disableDirectCall; //Field offset: 0x1E
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	private OptimizeFor <OptimizeFor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001D")]
	private String[] <Options>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000003")]
	public bool CompileSynchronously
	{
		[Address(RVA = "0x27B9D10", Offset = "0x27B9110", Length = "0x54")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 84
		[Address(RVA = "0x27B9E90", Offset = "0x27B9290", Length = "0x5B")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000004")]
	public bool Debug
	{
		[Address(RVA = "0x27B9D70", Offset = "0x27B9170", Length = "0x54")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 84
		[Address(RVA = "0x27B9EF0", Offset = "0x27B92F0", Length = "0x5B")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000006")]
	public bool DisableDirectCall
	{
		[Address(RVA = "0x27B9DD0", Offset = "0x27B91D0", Length = "0x54")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 84
		[Address(RVA = "0x27B9F50", Offset = "0x27B9350", Length = "0x5B")]
		[Token(Token = "0x6000010")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000005")]
	public bool DisableSafetyChecks
	{
		[Address(RVA = "0x27B9E30", Offset = "0x27B9230", Length = "0x54")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 84
		[Address(RVA = "0x27B9FB0", Offset = "0x27B93B0", Length = "0x5B")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000001")]
	public FloatMode FloatMode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public FloatPrecision FloatPrecision
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public OptimizeFor OptimizeFor
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000011")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000012")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	internal String[] Options
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000013")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000014")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x268FE20", Offset = "0x268F220", Length = "0x31")]
	[Token(Token = "0x6000017")]
	internal BurstCompileAttribute(String[] options) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000015")]
	public BurstCompileAttribute() { }

	[Address(RVA = "0x27B9CD0", Offset = "0x27B90D0", Length = "0x34")]
	[Token(Token = "0x6000016")]
	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) { }

	[Address(RVA = "0x27B9D10", Offset = "0x27B9110", Length = "0x54")]
	[Token(Token = "0x6000009")]
	public bool get_CompileSynchronously() { }

	[Address(RVA = "0x27B9D70", Offset = "0x27B9170", Length = "0x54")]
	[Token(Token = "0x600000B")]
	public bool get_Debug() { }

	[Address(RVA = "0x27B9DD0", Offset = "0x27B91D0", Length = "0x54")]
	[Token(Token = "0x600000F")]
	public bool get_DisableDirectCall() { }

	[Address(RVA = "0x27B9E30", Offset = "0x27B9230", Length = "0x54")]
	[Token(Token = "0x600000D")]
	public bool get_DisableSafetyChecks() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	public FloatMode get_FloatMode() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public FloatPrecision get_FloatPrecision() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000011")]
	public OptimizeFor get_OptimizeFor() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000013")]
	internal String[] get_Options() { }

	[Address(RVA = "0x27B9E90", Offset = "0x27B9290", Length = "0x5B")]
	[Token(Token = "0x600000A")]
	public void set_CompileSynchronously(bool value) { }

	[Address(RVA = "0x27B9EF0", Offset = "0x27B92F0", Length = "0x5B")]
	[Token(Token = "0x600000C")]
	public void set_Debug(bool value) { }

	[Address(RVA = "0x27B9F50", Offset = "0x27B9350", Length = "0x5B")]
	[Token(Token = "0x6000010")]
	public void set_DisableDirectCall(bool value) { }

	[Address(RVA = "0x27B9FB0", Offset = "0x27B93B0", Length = "0x5B")]
	[Token(Token = "0x600000E")]
	public void set_DisableSafetyChecks(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public void set_FloatMode(FloatMode value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public void set_FloatPrecision(FloatPrecision value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000012")]
	public void set_OptimizeFor(OptimizeFor value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000014")]
	internal void set_Options(String[] value) { }

}

