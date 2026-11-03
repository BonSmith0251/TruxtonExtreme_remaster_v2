namespace UnityEngine.Rendering;

[Token(Token = "0x200022A")]
public sealed class VolumeStack : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AB")]
	internal readonly Dictionary<Type, VolumeComponent> components; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AC")]
	internal VolumeParameter[] parameters; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009AD")]
	internal bool requiresReset; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40009AE")]
	internal bool requiresResetForAllProperties; //Field offset: 0x21
	[CompilerGenerated]
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x40009AF")]
	private bool <isValid>k__BackingField; //Field offset: 0x22

	[Token(Token = "0x170001FD")]
	public private bool isValid
	{
		[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000F93")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F94")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C6B170", Offset = "0x2C6A570", Length = "0x7D")]
	[Token(Token = "0x6000F8D")]
	internal VolumeStack() { }

	[Address(RVA = "0x2C6ACA0", Offset = "0x2C6A0A0", Length = "0x205")]
	[Token(Token = "0x6000F8E")]
	internal void Clear() { }

	[Address(RVA = "0x2C6AEB0", Offset = "0x2C6A2B0", Length = "0x1A")]
	[Token(Token = "0x6000F92")]
	public override void Dispose() { }

	[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000F93")]
	public bool get_isValid() { }

	[Address(RVA = "0x9E6A10", Offset = "0x9E5E10", Length = "0xA9")]
	[Token(Token = "0x6000F90")]
	public T GetComponent() { }

	[Address(RVA = "0x2C6AED0", Offset = "0x2C6A2D0", Length = "0x67")]
	[Token(Token = "0x6000F91")]
	public VolumeComponent GetComponent(Type type) { }

	[Address(RVA = "0x2C6AF40", Offset = "0x2C6A340", Length = "0x22C")]
	[Token(Token = "0x6000F8F")]
	internal void Reload(Type[] componentTypes) { }

	[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F94")]
	private void set_isValid(bool value) { }

}

